using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
using System.Configuration;
using System.Data.SqlClient;

namespace XlsImporter
{
    public partial class frmMain : Form
    {
        string connectionString;
        public BindingList<Library.ColumnMapping> listColumns;
        Library.DataLayer libraryDataLayer;
        public frmMain()
        {
            InitializeComponent();
            timer1.Enabled = true;
        }

        public void OpenExcelFile(string fileName, ref string[] workSheetNames, string header)
        {
            //open the excel file using OLEDB  
            OleDbConnection con;
            string fileExt = Path.GetExtension(fileName);
            try
            {
                if (fileExt == ".xlsx")
                    //read a 2007 file  
                    connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" +
                        fileName + ";Extended Properties=\"Excel 12.0;HDR=" + header + ";\"";
                else
                    //read a 97-2003 file  
                    connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" +
                        fileName + ";Extended Properties=Excel 8.0;HDR=" + header + ";";

                con = new OleDbConnection(connectionString);
                con.Open();
            }
            catch (OleDbException ex)//Could not find installable ISAM. HDR özelliğinden dolayı veriyor
            {
                if (fileExt == ".xlsx")
                    //read a 2007 file  
                    connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" +
                        fileName + ";Extended Properties=\"Excel 12.0;\"";
                else
                    //read a 97-2003 file  
                    connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" +
                        fileName + ";Extended Properties=Excel 8.0;";

                con = new OleDbConnection(connectionString);
                con.Open();
            }
            catch (Exception ex2)
            {
                MessageBox.Show(ex2.Message);
                return;
            }
                

            //get all the available sheets  
            System.Data.DataTable dataSet = con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);

            //get the number of sheets in the file  
            workSheetNames = new String[dataSet.Rows.Count];
            int i = 0;
            foreach (DataRow row in dataSet.Rows)
            {
                //insert the sheet's name in the current element of the array  
                //and remove the $ sign at the end  
                workSheetNames[i] = row["TABLE_NAME"].ToString().Trim(new[] { '$' });
                i++;
            }

            if (con != null)
            {
                con.Close();
                con.Dispose();
            }

            if (dataSet != null)
                dataSet.Dispose();
        }

        public System.Data.DataTable GetWorksheet(string worksheetName)
        {
            if (!worksheetName.Contains("$")) worksheetName = worksheetName + "$";
            OleDbConnection con = new System.Data.OleDb.OleDbConnection(connectionString);
            OleDbDataAdapter cmd = new System.Data.OleDb.OleDbDataAdapter(
                "select * from [" + worksheetName + "]", con);

            con.Open();
            System.Data.DataSet excelDataSet = new DataSet();
            cmd.Fill(excelDataSet);
            con.Close();

            return excelDataSet.Tables[0];
        }  

        private void btnOpenFile_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            marqueProgress.Enabled = true;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.CheckFileExists = true;
            ofd.CheckPathExists = true;
            ofd.AddExtension = true;
            ofd.Filter = "Excel 97-2003(*.xls)|*.xls|Excel 2007(*.xlsx)|*.xlsx";
            if (ofd.ShowDialog()==DialogResult.OK)
            {
                string fileName = ofd.FileName;
                string[] workSheets = new String[1];
                if (radioHeader.EditValue == null)
                {
                    MessageBox.Show("Başlık satırı bilgisini mutlaka belirtmelisiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                OpenExcelFile(fileName, ref workSheets, radioHeader.EditValue.ToString());
                for (int i = 0; i < workSheets.Length; i++)
                    (cboxSheets.Edit as DevExpress.XtraEditors.Repository.RepositoryItemComboBox).Items.Add(workSheets[i]);
                cboxSheets.EditValue = workSheets[0];
                DataTable dtVeri = GetWorksheet(workSheets[0]);
                gridXlsFile.DataSource = dtVeri;
                bartextFile.Caption = fileName;
            }
            marqueProgress.Enabled = false;
        }

        private void cboxSheets_EditValueChanged(object sender, EventArgs e)
        {
            gridXlsFile.DataSource = null;
            gwXlsFile.Columns.Clear();
            //gridControl1.RefreshDataSource();
            DataTable dtVeri = GetWorksheet(cboxSheets.EditValue.ToString());
            gridXlsFile.DataSource = dtVeri;
            gwXlsFile.PopulateColumns();
            gridXlsFile.Refresh();
        }

        private void btnSave2Table_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmSQLConnector frmConn = new frmSQLConnector();
            DialogResult ret = frmConn.ShowDialog();
            if (ret == DialogResult.OK)
            {
                Cursor cursor = Cursor.Current;
                Cursor.Current = Cursors.WaitCursor;
                SqlConnection cnn = new SqlConnection(frmConn.GetDataBaseConnectionString());
                cnn.Open();
                string tableName = cboxSheets.EditValue.ToString();
                if (Library.InputBox("Tablo Oluştur", "Yeni tablo adı:", ref tableName) == DialogResult.OK)
                {
                    listColumns = new BindingList<Library.ColumnMapping>();
                    for (int i = 0; i <= gwXlsFile.Columns.Count - 1; i++)
                    {
                        Library.ColumnMapping map = new Library.ColumnMapping();
                        string sColumnName;
                        if ((int)radioHeader.EditValue == 1)
                        {
                            if (!gwXlsFile.Columns[i].Caption.Contains("[")) sColumnName = "[" + gwXlsFile.Columns[i].Caption + "]";
                            else sColumnName = gwXlsFile.Columns[i].Caption;
                        }
                        else
                            sColumnName = string.Format("Column{0}", i);
                        map.ColumnName = sColumnName; //((int)radioHeader.EditValue == 1) ? gwXlsFile.Columns[i].Caption : "Column" + Convert.ToString(i);
                        string dataType;
                        bool boolNull=true, boolNumeric=false;
                        int iSize=0, iPrecision=0, iScale=0;
                        switch (gwXlsFile.Columns[i].ColumnType.Name)
                        {
                            case "Default": dataType = "varchar"; iSize = 255; 
                                break;
                            case "String": dataType = "varchar"; iSize = 255;
                                break;
                            case "Boolean": dataType = "bit"; 
                                break;
                            case "DateTime": dataType = "datetime"; 
                                break;
                            case "Decimal": dataType = "decimal"; iPrecision = 18; iScale = 2; boolNumeric = true;
                                break;
                            case "Double": dataType = "float"; boolNumeric = true; 
                                break;
                            case "Integer": dataType = "int"; boolNumeric = true;
                                break;
                            default:
                                dataType = "varchar"; iSize = 255;
                                break;
                        }
                        map.ColumnType = dataType;
                        map.Nullable = boolNull;
                        map.Precision = iPrecision;
                        map.Size = iSize;
                        map.Scale = iScale;
                        map.IsNumeric = boolNumeric;
                        listColumns.Add(map);
                    }
                    frmColumnMapping frmMaps = new frmColumnMapping();
                    frmMaps.listColumns = listColumns;
                    frmMaps.tableName = tableName;
                    frmMaps.cnn = cnn;
                    frmMaps.ShowDialog();
                    libraryDataLayer = new Library.DataLayer();
                    DataTable dtVeri = (gridXlsFile.DataSource as DataTable);
                    foreach (DataRow row in dtVeri.Rows)
                    {
                        Library.DataLayer.InsertedFieldType[] arrFields = new Library.DataLayer.InsertedFieldType[listColumns.Count];
                        int i = 0;
                        foreach (Library.ColumnMapping mapColumn in listColumns)
                        {
                            arrFields[i].FieldName = mapColumn.ColumnName;
                            arrFields[i].FieldValue = row[i].ToString();
                            arrFields[i].IsNumeric = mapColumn.IsNumeric;
                            i = i + 1;
                        }
                        try
                        {
                            string retMsg = libraryDataLayer.InsertRow2Table(cnn, tableName, arrFields);
                            if (retMsg != "") throw new Exception(retMsg);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Hata oluştu(0x8800F56D).\nHata detayı : " + ex.Message, "Kayıt Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            if (MessageBox.Show("Diğer kayıtları aktarmaya devam edilsin mi?", "Onay", MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.No)
                                return;
                        }
                    }
                    MessageBox.Show("Aktarım tamamlandı!");
                }
                Cursor.Current = cursor;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
             //bar = DateTime.Now.TimeOfDay.ToString();
            bartextTime.Caption = DateTime.Now.TimeOfDay.ToString();
        }

        private void btnKapat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            bartextFile.Caption = "";
        }
    }
}
