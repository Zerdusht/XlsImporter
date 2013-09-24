namespace XlsImporter
{
    partial class frmSQLConnector {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.pnlMain = new DevExpress.XtraEditors.PanelControl();
            this.btnTest = new DevExpress.XtraEditors.SimpleButton();
            this.checkSavePass = new DevExpress.XtraEditors.CheckEdit();
            this.checkBosParola = new DevExpress.XtraEditors.CheckEdit();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.cbServer = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.radioGroup2 = new DevExpress.XtraEditors.RadioGroup();
            this.tePassword = new DevExpress.XtraEditors.TextEdit();
            this.teLogin = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.radioGroup1 = new DevExpress.XtraEditors.RadioGroup();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cbDatabase = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.sbExit = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMain)).BeginInit();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkSavePass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBosParola.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbServer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teLogin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDatabase.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlMain.Appearance.Options.UseBackColor = true;
            this.pnlMain.Controls.Add(this.btnTest);
            this.pnlMain.Controls.Add(this.checkSavePass);
            this.pnlMain.Controls.Add(this.checkBosParola);
            this.pnlMain.Controls.Add(this.btnRefresh);
            this.pnlMain.Controls.Add(this.cbServer);
            this.pnlMain.Controls.Add(this.labelControl6);
            this.pnlMain.Controls.Add(this.radioGroup2);
            this.pnlMain.Controls.Add(this.tePassword);
            this.pnlMain.Controls.Add(this.teLogin);
            this.pnlMain.Controls.Add(this.labelControl5);
            this.pnlMain.Controls.Add(this.labelControl4);
            this.pnlMain.Controls.Add(this.radioGroup1);
            this.pnlMain.Controls.Add(this.labelControl3);
            this.pnlMain.Controls.Add(this.labelControl2);
            this.pnlMain.Controls.Add(this.cbDatabase);
            this.pnlMain.Controls.Add(this.labelControl1);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMain.Location = new System.Drawing.Point(8, 8);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(364, 381);
            this.pnlMain.TabIndex = 2;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(267, 256);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(88, 27);
            this.btnTest.TabIndex = 29;
            this.btnTest.Text = "Baðlantýyý Sýna";
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // checkSavePass
            // 
            this.checkSavePass.Location = new System.Drawing.Point(200, 187);
            this.checkSavePass.Name = "checkSavePass";
            this.checkSavePass.Properties.Caption = "Parola kaydetmeye izin ver";
            this.checkSavePass.Size = new System.Drawing.Size(185, 19);
            this.checkSavePass.TabIndex = 28;
            // 
            // checkBosParola
            // 
            this.checkBosParola.Location = new System.Drawing.Point(68, 187);
            this.checkBosParola.Name = "checkBosParola";
            this.checkBosParola.Properties.Caption = "Boþ Parola";
            this.checkBosParola.Size = new System.Drawing.Size(75, 19);
            this.checkBosParola.TabIndex = 27;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(311, 34);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(44, 21);
            this.btnRefresh.TabIndex = 26;
            this.btnRefresh.Text = "Yenile";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // cbServer
            // 
            this.cbServer.Location = new System.Drawing.Point(37, 35);
            this.cbServer.Name = "cbServer";
            this.cbServer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbServer.Size = new System.Drawing.Size(268, 20);
            this.cbServer.TabIndex = 25;
            this.cbServer.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.cbServer_QueryPopUp);
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(12, 288);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(147, 13);
            this.labelControl6.TabIndex = 23;
            this.labelControl6.Text = "4. Baðlantý ayarlarýný kayýt þekli";
            // 
            // radioGroup2
            // 
            this.radioGroup2.EditValue = 0;
            this.radioGroup2.Location = new System.Drawing.Point(37, 307);
            this.radioGroup2.Name = "radioGroup2";
            this.radioGroup2.Properties.Columns = 1;
            this.radioGroup2.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Kayýt Defteri (Registry)"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Dosya Sistemi (.ini Dosyasý)")});
            this.radioGroup2.Size = new System.Drawing.Size(318, 58);
            this.radioGroup2.TabIndex = 22;
            // 
            // tePassword
            // 
            this.tePassword.Enabled = false;
            this.tePassword.Location = new System.Drawing.Point(133, 161);
            this.tePassword.Name = "tePassword";
            this.tePassword.Properties.PasswordChar = '*';
            this.tePassword.Size = new System.Drawing.Size(222, 20);
            this.tePassword.TabIndex = 4;
            // 
            // teLogin
            // 
            this.teLogin.EditValue = "sa";
            this.teLogin.Enabled = false;
            this.teLogin.Location = new System.Drawing.Point(133, 135);
            this.teLogin.Name = "teLogin";
            this.teLogin.Size = new System.Drawing.Size(222, 20);
            this.teLogin.TabIndex = 3;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(72, 164);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(22, 13);
            this.labelControl5.TabIndex = 21;
            this.labelControl5.Text = "Þifre";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(72, 138);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(37, 13);
            this.labelControl4.TabIndex = 20;
            this.labelControl4.Text = "Kullanýcý";
            // 
            // radioGroup1
            // 
            this.radioGroup1.EditValue = 0;
            this.radioGroup1.Location = new System.Drawing.Point(37, 77);
            this.radioGroup1.Name = "radioGroup1";
            this.radioGroup1.Properties.Columns = 1;
            this.radioGroup1.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Windows NT tümleþik güvenliðini kullan"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Belirli bir kullanýcý adý ve parolasý kullan")});
            this.radioGroup1.Size = new System.Drawing.Size(318, 52);
            this.radioGroup1.TabIndex = 2;
            this.radioGroup1.SelectedIndexChanged += new System.EventHandler(this.radioGroup1_SelectedIndexChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 60);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(206, 13);
            this.labelControl3.TabIndex = 18;
            this.labelControl3.Text = "2. Sunucuda oturum açmak için bilgileri girin";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 19);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(206, 13);
            this.labelControl2.TabIndex = 16;
            this.labelControl2.Text = "1. SQL Server sunucu adýný seçin veya girin";
            // 
            // cbDatabase
            // 
            this.cbDatabase.Location = new System.Drawing.Point(37, 231);
            this.cbDatabase.Name = "cbDatabase";
            this.cbDatabase.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbDatabase.Properties.ValidateOnEnterKey = true;
            this.cbDatabase.Size = new System.Drawing.Size(318, 20);
            this.cbDatabase.TabIndex = 1;
            this.cbDatabase.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.cbDatabase_QueryPopUp);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 212);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(153, 13);
            this.labelControl1.TabIndex = 14;
            this.labelControl1.Text = "3. Sunucudaki veritabanýný seçin";
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(206, 404);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 25);
            this.btnSave.TabIndex = 24;
            this.btnSave.Text = "Tamam";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // sbExit
            // 
            this.sbExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.sbExit.Location = new System.Drawing.Point(292, 404);
            this.sbExit.Name = "sbExit";
            this.sbExit.Size = new System.Drawing.Size(80, 25);
            this.sbExit.TabIndex = 12;
            this.sbExit.Text = "Ýptal";
            this.sbExit.Click += new System.EventHandler(this.sbExit_Click);
            // 
            // frmSQLConnector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 445);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.sbExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmSQLConnector";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sql Server- Configuration Window";
            ((System.ComponentModel.ISupportInitialize)(this.pnlMain)).EndInit();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkSavePass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBosParola.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbServer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teLogin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDatabase.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnlMain;
        private DevExpress.XtraEditors.TextEdit tePassword;
        private DevExpress.XtraEditors.TextEdit teLogin;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.RadioGroup radioGroup1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.ComboBoxEdit cbDatabase;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton sbExit;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.RadioGroup radioGroup2;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.ComboBoxEdit cbServer;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraEditors.CheckEdit checkBosParola;
        private DevExpress.XtraEditors.CheckEdit checkSavePass;
        private DevExpress.XtraEditors.SimpleButton btnTest;
    }
}
