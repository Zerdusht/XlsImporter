using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors.Repository;
using System.Data.Sql;
using System.Data.SqlClient;

namespace XlsImporter
{
    public partial class frmColumnMapping : Form
    {
        public BindingList<Library.ColumnMapping> listColumns;
        public string tableName = "";
        public SqlConnection cnn;
        public frmColumnMapping()
        {
            InitializeComponent();
            listColumns = new BindingList<Library.ColumnMapping>();
            cnn = new SqlConnection();
        }

        private void frmColumnMapping_Load(object sender, EventArgs e)
        {
            //for (int i=0; i<listColumns.Count;i++)
            //    MessageBox.Show(Convert.ToString(i)+" :: "+ listColumns[i].ColumnName+" : "+listColumns[i].ColumnType);
            BindData();
            lblKaynak.Text = tableName;
            lblHedef.Text = tableName;
        }

        private void BindData()
        {
            gridMapping.DataSource = listColumns;
            gwMapping.PopulateColumns();
            gridMapping.RefreshDataSource();
            
            //Create a repository item for a combo box editor 
            RepositoryItemComboBox riComboDataType = new RepositoryItemComboBox();
            //riComboDataType.Items.AddRange(new string[] { "London", "Berlin", "Paris" });
            riComboDataType.Items.AddRange(Library.GlobalVariables.arrayDataTypes);
            //Add the item to the internal repository
            gridMapping.RepositoryItems.Add(riComboDataType);
            //Now you can define the repository item as an in-place column editor
            gwMapping.Columns[1].ColumnEdit = riComboDataType;
        }

        private string GetTableCreateScript()
        {
            string sql = "CREATE TABLE [dbo].[" + tableName + "] (\n\r";
            //Library.ColumnMapping mapColumn = new Library.ColumnMapping();
            foreach (Library.ColumnMapping mapColumn in listColumns)
            {
                string sColumnName;
                if (!mapColumn.ColumnName.Contains("[")) sColumnName = "[" + mapColumn.ColumnName + "]";
                else sColumnName = mapColumn.ColumnName;
                sql = sql + sColumnName + " "
                    + mapColumn.ColumnType
                    + ((mapColumn.Size > 0) ? "(" + mapColumn.Size.ToString() + "),"
                        : (mapColumn.Precision > 0) ? "(" + mapColumn.Precision.ToString() + "," + mapColumn.Scale.ToString() + "),"
                        : ",\n\r");
            }
            sql = sql.Remove(sql.Length - 1);
            sql = sql + "\n)";
            return sql;
        }

        private void btnEditSql_Click(object sender, EventArgs e)
        {
            MessageBox.Show(GetTableCreateScript());
        }

        private void btnTamam_Click(object sender, EventArgs e)
        {
            try 
	        {
                SqlCommand cmd = new SqlCommand(GetTableCreateScript(), cnn);
                if (cnn.State == ConnectionState.Broken || cnn.State == ConnectionState.Closed || cnn.State == ConnectionState.Connecting) { cnn.Close(); cnn.Open(); }
                cmd.ExecuteNonQuery();
                frmMain formMain = new frmMain();
                formMain.listColumns = listColumns;
                Close();        		
	        }
	        catch (Exception ex)
	        {
                MessageBox.Show(ex.Message);
	        }
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
