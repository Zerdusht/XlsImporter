using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using DevExpress.Xpo.DB;
using DevExpress.Xpo;
using System.Xml;
using DevExpress.Data.Filtering;
using Microsoft.Win32;
using Microsoft.SqlServer.Management.Smo;


namespace XlsImporter
{
    public partial class frmSQLConnector : XtraForm {
        public struct ConnectionElements
        {
            public string ServerName;
            public string DatabaseName;
            public bool Sspi;
            public string UserName;
            public string Password;

            public ConnectionElements(string AServer, string ADatabase, string AUser, string APass)
            {
                ServerName = AServer;
                DatabaseName = ADatabase;
                Sspi = AUser == "" ? true : false;
                UserName = AUser;
                Password = APass;
            }
        }
        public ConnectionElements ConnParameters;
        string defaultDB = "";
        string serverParameters = "SQLParameters.xml";
        string serverParametersRegkey = "Software\\NCryptex\\"+Application.ProductName+"\\SQLParameters";
        bool bConnectionTrue;
        public frmSQLConnector()
            : this("SQL Baðlantý Ayarlarý")
        {
        }
        public frmSQLConnector(string demoString) {
            InitializeComponent();
            this.Text = demoString;
            bConnectionTrue = false;
            cbDatabase.Text = defaultDB;
            ShowParameters();
            cbServer.Focus(); 
        }

        void ShowParameters() {
            if (!System.IO.File.Exists(serverParameters) && Registry.CurrentUser.OpenSubKey(serverParametersRegkey) == null)
            { bConnectionTrue = false; return; }
            if(System.IO.File.Exists(serverParameters))
            {
                XmlDocument doc = new XmlDocument();
                try { 
                    doc.Load(serverParameters); 
                } catch { }
                if(doc.DocumentElement.Name == "Parameters") {
                    string[] prm = doc.DocumentElement.InnerText.Split(new char[] {';'} );
                    cbServer.Text = prm[0];
                    radioGroup1.SelectedIndex = Convert.ToInt32(prm[1]);
                    teLogin.Text = prm[2];
                    tePassword.Text = BaseEncryption.Decrypt(prm[3], Application.ProductName + "??a");
                    checkSavePass.Checked = Convert.ToInt32(prm[4])==1 ? true : false;
                    cbDatabase.Text = prm[5];
                }
            }
            else if (Registry.CurrentUser.OpenSubKey(serverParametersRegkey) != null)
            {
                try
                {
                    RegistryKey rk = Registry.CurrentUser;
                    RegistryKey reg = rk.OpenSubKey(serverParametersRegkey);
                    cbServer.Text = (string)reg.GetValue("Server","");
                    cbDatabase.Text = (string)reg.GetValue("Database");
                    teLogin.Text = (string)reg.GetValue("Login");
                    tePassword.Text = BaseEncryption.Decrypt((string)reg.GetValue("Password"), Application.ProductName + "??a");
                    radioGroup1.SelectedIndex = (Int32)reg.GetValue("SSPI",1);
                    checkSavePass.Checked = (int)reg.GetValue("SavePassword",false) == 0 ? false : true;
                    reg.Close(); rk.Close();
                } 
                catch (Exception ex) 
                {
                    XtraMessageBox.Show(ex.Message, "Open Config", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            ConnParameters = new ConnectionElements(cbServer.Text, cbDatabase.Text, teLogin.Text, tePassword.Text);
            bConnectionTrue = CorrectConnection(GetServerConnectionString(),false);
        }

        private void radioGroup1_SelectedIndexChanged(object sender, EventArgs e) {
            bool disable = radioGroup1.SelectedIndex == 0;
            DisableSQLServerAuthentication(disable);
        }

        void DisableSQLServerAuthentication(bool disable) {
            teLogin.Enabled = !disable;
            tePassword.Enabled = !disable;
        }
        public string ConnectionStringParameters {
            get {
                return string.Format("{0};{1};{2};{3};{4};{5}", cbServer.Text, radioGroup1.SelectedIndex, teLogin.Text, tePassword.Text,(checkSavePass.Checked ? "1":"0"),cbDatabase.Text);
            }
        }
        public string GetServerConnectionString() {
            if (string.IsNullOrEmpty(cbServer.Text))
            {
                return "";
            }
            string connectionString = String.Format("data source={0};integrated security=SSPI", cbServer.Text);
            if(radioGroup1.SelectedIndex == 1)
                connectionString = String.Format("data source={0};user id={1};password={2}", cbServer.Text, teLogin.Text, tePassword.Text);
            if (checkSavePass.Checked)
                connectionString = connectionString + ";Persist Security Info=True";
            return connectionString;
        }

        public string GetDataBaseConnectionString() {
            string connectionString = GetServerConnectionString();
            return connectionString + ";initial catalog=" + cbDatabase.Text;
        }

         void AddDatabaseNames() {
            using(SqlConnection connection = new SqlConnection(GetServerConnectionString())) {
                try {
                    connection.Open();
                }
                catch {
                    XtraMessageBox.Show(Library.ServerModeStrings.failedConnection, Library.ServerModeStrings.failedConnectionCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                using(SqlCommand command = new SqlCommand("select name from master..sysdatabases", connection)) {
                    using(SqlDataReader reader = command.ExecuteReader()) {
                        cbDatabase.Properties.Items.Clear();
                        while(reader.Read()) {
                            string name = reader.GetString(0);
                            if("master;model;tempdb;msdb;pubs".IndexOf(name) < 0)
                                cbDatabase.Properties.Items.Add(name);
                        }
                    }
                }
            }
        }

        public void GetSQLInstances() 
        {
            DataTable dt = SmoApplication.EnumAvailableSqlServers(false);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    if (cbServer.Properties.Items.IndexOf(dr["Name"]) == -1)
                        cbServer.Properties.Items.Add(dr["Name"]);
                }
            }
            return;
            //System.Data.Sql.SqlDataSourceEnumerator instance = System.Data.Sql.SqlDataSourceEnumerator.Instance; 
            //DataTable dataTable = instance.GetDataSources(); 
            //if (dataTable.Rows.Count > 0) 
            //{
            //    cbServer.Properties.Items.Clear();
            //    foreach (System.Data.DataRow row in dataTable.Rows)
            //        cbServer.Properties.Items.Add(row[0] + "\\" + row[1]);
            //} 
         } 

        private void cbDatabase_QueryPopUp(object sender, CancelEventArgs e) {
            AddDatabaseNames();
        }

        private void cbServer_EditValueChanged(object sender, EventArgs e) {
            cbDatabase.Text = "";
            cbDatabase.Properties.Items.Clear();
        }
        public bool IsConnectionAlive{
            get { return bConnectionTrue; }
            //set { bConnectionTrue = value; }
        }
        public static bool CorrectConnection(string serverConnectionString, bool ShowMessage) {
            Cursor cur = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            using(SqlConnection connection = new SqlConnection(serverConnectionString)) {
                try {
                    connection.Open();
                    connection.Close();
                }
                catch 
                {
                    if (ShowMessage)
                        XtraMessageBox.Show(Library.ServerModeStrings.failedConnection, Library.ServerModeStrings.failedConnectionCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Cursor.Current = cur; 
                    return false; 
                }
                finally {
                    Cursor.Current = cur;
                }
            }
            return true;
        }

        private void sbExit_Click(object sender, EventArgs e) {
            bConnectionTrue = CorrectConnection(GetServerConnectionString(), false); 
            if (bConnectionTrue)
                ConnParameters = new ConnectionElements(cbServer.Text, cbDatabase.Text, teLogin.Text, tePassword.Text);
            this.Dispose();
        }

        void SaveAndCloseForm() {
            if (!CorrectConnection(GetServerConnectionString(), true)) { bConnectionTrue = false; return; }
            else bConnectionTrue = true;
            try 
            {
                if (radioGroup2.SelectedIndex == 1)
                {
                    using (XmlTextWriter tw = new XmlTextWriter(serverParameters, System.Text.Encoding.UTF8))
                    {
                        tw.WriteElementString("Parameters", BaseEncryption.Encrypt(ConnectionStringParameters,Application.ProductName + "??a"));
                    }
                } 
                else {
                    RegistryKey rk = Registry.CurrentUser;
                    using(RegistryKey reg = rk.CreateSubKey(serverParametersRegkey))
                    {
                        reg.SetValue("Server", cbServer.Text, RegistryValueKind.String);
                        reg.SetValue("Database", cbDatabase.Text, RegistryValueKind.String);
                        reg.SetValue("SSPI", radioGroup1.SelectedIndex, RegistryValueKind.DWord);
                        reg.SetValue("Login", teLogin.Text, RegistryValueKind.String);
                        reg.SetValue("Password", BaseEncryption.Encrypt(tePassword.Text, Application.ProductName + "??a"), RegistryValueKind.String);
                        reg.SetValue("SavePassword",Convert.ToByte(checkSavePass.Checked), RegistryValueKind.DWord);
                        reg.Close();
                    }
                    rk.Close();
                }
                ConnParameters = new ConnectionElements(cbServer.Text, cbDatabase.Text, teLogin.Text, tePassword.Text);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message,"Save Config",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveAndCloseForm();
        }

        private void cbServer_QueryPopUp(object sender, CancelEventArgs e)
        {
            //GetSQLInstances();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Cursor cur = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            GetSQLInstances();
            Cursor.Current = cur;
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            if (CorrectConnection(GetServerConnectionString(), true))
            {
                bConnectionTrue = true;
                XtraMessageBox.Show("Sýnama baðlantýsý baþarýlý oldu.", "Sql Baðlantý Testi", MessageBoxButtons.OK);
            }
            else
            {
                bConnectionTrue = false;
                XtraMessageBox.Show("Sýnama baðlantýsý baþarýsýz oldu.", "Sql Baðlantý Testi", MessageBoxButtons.OK);
            }
        }
    }
}
