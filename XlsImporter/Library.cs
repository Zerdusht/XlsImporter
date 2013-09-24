using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.IO;
using System.Globalization;

namespace XlsImporter
{
    public class Library
    {
        public class GlobalVariables
        {
            public static Array arrayDataTypes = new string[17] {"datetime","bit"
                        ,"smallint","int","tinyint","bigint","real","float","money"
                        ,"decimal","numeric","char","varchar","text","nchar","nvarchar","ntext"};
        }
        public struct ColumnMapping2
        {
            public string ColumnName;
            public string ColumnType;
            public bool Nullable;
            public Int32 Size;
            public Int32 Precision;
            public Int32 Scale;
            public bool IsNumeric;

            public ColumnMapping2(string AColumnName, string AColumnType, bool ANullable,
                                        Int32 ASize, Int32 APrecision, Int32 AScale, bool AIsNumeric)
            {
                ColumnName = AColumnName;
                ColumnType = AColumnType;
                Nullable = ANullable;
                Size = ASize;
                Precision = APrecision;
                Scale = AScale;
                IsNumeric = AIsNumeric;
            }
        }
        public class ColumnMapping
        {
            public string ColumnName { get; set; }
            public string ColumnType { get; set; }
            public bool Nullable { get; set; }
            public Int32 Size { get; set; }
            public Int32 Precision { get; set; }
            public Int32 Scale { get; set; }
            public bool IsNumeric { get; set; }
        }

        public static DialogResult InputBox(string title, string promptText, ref string value)
        {
          Form form = new Form();
          Label label = new Label();
          TextBox textBox = new TextBox();
          Button buttonOk = new Button();
          Button buttonCancel = new Button();

          form.Text = title;
          label.Text = promptText;
          textBox.Text = value;

          buttonOk.Text = "OK";
          buttonCancel.Text = "Cancel";
          buttonOk.DialogResult = DialogResult.OK;
          buttonCancel.DialogResult = DialogResult.Cancel;

          label.SetBounds(9, 20, 372, 13);
          textBox.SetBounds(12, 36, 372, 20);
          buttonOk.SetBounds(228, 72, 75, 23);
          buttonCancel.SetBounds(309, 72, 75, 23);

          label.AutoSize = true;
          textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
          buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
          buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

          form.ClientSize = new Size(396, 107);
          form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
          form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
          form.FormBorderStyle = FormBorderStyle.FixedDialog;
          form.StartPosition = FormStartPosition.CenterScreen;
          form.MinimizeBox = false;
          form.MaximizeBox = false;
          form.AcceptButton = buttonOk;
          form.CancelButton = buttonCancel;

          DialogResult dialogResult = form.ShowDialog();
          value = textBox.Text;
          return dialogResult;
        }

        public class ServerModeStrings
        {
            public static string SQLConnectionString = string.Empty;
            public static string failedConnection = "Sql server'a bağlanırken hata oluştu!";
            public static string failedConnectionCaption = "Bağlantı Hatası";
            public static string dataAdding = "Adding next portion of data...";
            public static string recordCount = "Geçerli kayıt sayısı = {0}";
            public static string descriptionSQLConnection =
                "The Server Mode Demos demonstrate the XtraGrid and GridLookUpEdit controls' capabilities when they are bound to a large amount of data. In this demo the XtraGrid/GridLookUpEdit control needs to be connected to a data table on an MS SQL server. Please use this Configuration Window to configure data and connection settings.\r\n" +
                "On the first run:\r\n" +
                "1) Specify the name of an existing SQL Server which will contain the target database;\r\n" +
                "2) Specify the amount of records in the target table and click the Generate Table and Start Demo button. A new table will be generated and the demo will start with the XtraGrid control bound to the generated recordset.\r\n" +
                "On subsequent runs, you can add more records to the database or just start the demo without generating additional data.";
            public static string descriptionServerSide =
                "This application demonstrates the XtraGrid control functioning in server mode, which is specifically designed to handle large volumes of data. Data is supplied to the grid control in small portions when required; it is never loaded into memory in its entirety. In addition, all data-aware operations are performed on the server side. All of this guarantees rapid data display and processing.\r\n" +
                "Practice with scrolling records, sorting, grouping and filtering against columns, and calculating summaries. Specific operations that you execute may take some time. In server mode, performance is wholly dependent on the data transfer speed, and the performance of the data server which carries out requested operations.\r\n" +
                "All operations performed on data are logged, and can be seen in the Tracing pane. To slightly improve performance, you can disable tracing by clearing the Enable Tracing checkbox.";
            public static string descriptionLookUpServerSide =
                "This application demonstrates the GridLookUpEdit control functioning in server mode. Data is supplied to the control in small portions when required; it's never loaded into memory in its entirety. In addition, all data-aware operations are performed on the server side. All of this guarantees rapid data display and processing.\r\n" +
                "Open an in-place GridLookUpEdit editor (by clicking on the Issue column's cell) and practice with scrolling records, sorting, grouping and filtering against columns, and calculating summaries. Specific operations that you execute may take some time. In server mode, performance is wholly dependent on the data transfer speed, and the performance of the data server which carries out requested operations.\r\n" +
                "All operations performed on data are logged, and can be seen in the Tracing pane. To slightly improve performance, you can disable tracing by clearing the Enable Tracing checkbox.";

        }

        public class DataLayer
        {
            public struct InsertedFieldType
            {
                public string FieldName;
                public bool IsNumeric;
                public string FieldValue;

                public InsertedFieldType(string AFieldName, bool AIsNumeric, string AFieldValue)
                {
                    FieldName = AFieldName;
                    IsNumeric = AIsNumeric;
                    FieldValue = AFieldValue;
                }
            }

            public string FormatNumberForSql(string sayi, int decimalDigitCount)
            {
                NumberFormatInfo nf = NumberFormatInfo.CurrentInfo;
                string sayi2 = Math.Round(Convert.ToDecimal(sayi), decimalDigitCount).ToString();
                sayi = sayi2.Replace(nf.NumberGroupSeparator, "");
                sayi = sayi.Replace(nf.NumberDecimalSeparator, ".");
                return sayi;
            }
            public string FormatNumberForSql(string sayi, int decimalDigitCount, NumberFormatInfo nf)
            {
                sayi = Math.Round(Convert.ToDecimal(sayi), decimalDigitCount).ToString();
                sayi.Replace(nf.NumberGroupSeparator, "");
                sayi.Replace(nf.NumberDecimalSeparator, ".");
                return sayi;
            }

            public SqlConnection GetSqlConnection(string AServer, string ACatalog, string AUser, string APass)
            {
                try
                {
                    SqlConnection cnn;
                    SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                    builder.DataSource = AServer;
                    builder.InitialCatalog = ACatalog;
                    builder.IntegratedSecurity = AUser == "" ? true : false;
                    builder.UserID = AUser;
                    builder.Password = APass;
                    cnn = new SqlConnection(builder.ConnectionString);
                    return cnn;
                }
                catch { return null; }
            }
            public string InsertRow2Table(SqlConnection Conn, string tableName, InsertedFieldType[] AFieldArray)
            {
                try
                {
                    string sqlStr;
                    sqlStr = "INSERT INTO " + tableName + "(";
                    for (int x = 0; x < AFieldArray.Length; x++)
                        sqlStr = sqlStr + AFieldArray[x].FieldName + ",";
                    sqlStr = sqlStr.Substring(0, sqlStr.Length - 1) + ") VALUES(";
                    for (int x = 0; x < AFieldArray.Length; x++)
                    {
                        if (AFieldArray[x].IsNumeric)
                        {
                            //sqlStr = sqlStr + Convert.ToDecimal(AFieldArray[x].FieldValue).ToString().Replace(',', '.') + ",";
                            //sqlStr = sqlStr + Convert.ToDecimal(AFieldArray[x].FieldValue).ToString(numberFormatInfo) + ",";
                            sqlStr = sqlStr + FormatNumberForSql(AFieldArray[x].FieldValue, 4) + ",";
                        }
                        else
                            sqlStr = sqlStr + "'" + AFieldArray[x].FieldValue.Replace("'"," ") + "',";
                    }
                    sqlStr = sqlStr.Substring(0, sqlStr.Length - 1) + ")";
                    using (SqlCommand cmd = new SqlCommand(sqlStr, Conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        if (Conn.State != ConnectionState.Open) Conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (SqlException ex2)
                {
                    Conn.Close();
                    if (ex2.Number == 2601)
                        return "Mükerrer kayıt oluştu!\nBelirtilen tekil değerlere sahip bir kayıt veritabanında zaten mevcut.";
                    else
                        return ex2.Number.ToString() + " : " + ex2.Message;
                }
                catch (Exception ex)
                {
                    Conn.Close();
                    return ex.Message;
                }
                Conn.Close();
                return ""; //sqlStr.Substring(0, sqlStr.Length - 1) + ")";
            }
        }
    }
}
