namespace XlsImporter
{
    partial class frmColumnMapping
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lblKaynak = new DevExpress.XtraEditors.LabelControl();
            this.lblHedef = new DevExpress.XtraEditors.LabelControl();
            this.radioTableOption = new DevExpress.XtraEditors.RadioGroup();
            this.checkDropCreateTable = new DevExpress.XtraEditors.CheckEdit();
            this.checkIdentityInsert = new DevExpress.XtraEditors.CheckEdit();
            this.btnEditSql = new DevExpress.XtraEditors.SimpleButton();
            this.gridMapping = new DevExpress.XtraGrid.GridControl();
            this.gwMapping = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnTamam = new DevExpress.XtraEditors.SimpleButton();
            this.btnVazgec = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.radioTableOption.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkDropCreateTable.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkIdentityInsert.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMapping)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gwMapping)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(22, 11);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(35, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Kaynak";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(22, 30);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(29, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Hedef";
            // 
            // lblKaynak
            // 
            this.lblKaynak.Location = new System.Drawing.Point(121, 9);
            this.lblKaynak.Name = "lblKaynak";
            this.lblKaynak.Size = new System.Drawing.Size(63, 13);
            this.lblKaynak.TabIndex = 2;
            this.lblKaynak.Text = "labelControl3";
            // 
            // lblHedef
            // 
            this.lblHedef.Location = new System.Drawing.Point(121, 28);
            this.lblHedef.Name = "lblHedef";
            this.lblHedef.Size = new System.Drawing.Size(63, 13);
            this.lblHedef.TabIndex = 3;
            this.lblHedef.Text = "labelControl4";
            // 
            // radioTableOption
            // 
            this.radioTableOption.EditValue = 0;
            this.radioTableOption.Location = new System.Drawing.Point(12, 49);
            this.radioTableOption.Name = "radioTableOption";
            this.radioTableOption.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Hedef tablosunu yarat"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Hedef tablosundaki satırları sil"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Kayıtları hedef tablosuna ekle")});
            this.radioTableOption.Size = new System.Drawing.Size(293, 73);
            this.radioTableOption.TabIndex = 4;
            // 
            // checkDropCreateTable
            // 
            this.checkDropCreateTable.Location = new System.Drawing.Point(330, 78);
            this.checkDropCreateTable.Name = "checkDropCreateTable";
            this.checkDropCreateTable.Properties.Caption = "Hedef tablosunu sil ve yeniden oluştur";
            this.checkDropCreateTable.Size = new System.Drawing.Size(282, 19);
            this.checkDropCreateTable.TabIndex = 5;
            // 
            // checkIdentityInsert
            // 
            this.checkIdentityInsert.Location = new System.Drawing.Point(330, 103);
            this.checkIdentityInsert.Name = "checkIdentityInsert";
            this.checkIdentityInsert.Properties.Caption = "IDENTITY INSERT aktive et";
            this.checkIdentityInsert.Size = new System.Drawing.Size(231, 19);
            this.checkIdentityInsert.TabIndex = 6;
            // 
            // btnEditSql
            // 
            this.btnEditSql.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnEditSql.Location = new System.Drawing.Point(332, 49);
            this.btnEditSql.Name = "btnEditSql";
            this.btnEditSql.Size = new System.Drawing.Size(204, 23);
            this.btnEditSql.TabIndex = 7;
            this.btnEditSql.Text = "Tablo sorgusunu düzenle...";
            this.btnEditSql.Click += new System.EventHandler(this.btnEditSql_Click);
            // 
            // gridMapping
            // 
            this.gridMapping.Location = new System.Drawing.Point(12, 128);
            this.gridMapping.MainView = this.gwMapping;
            this.gridMapping.Name = "gridMapping";
            this.gridMapping.Size = new System.Drawing.Size(633, 293);
            this.gridMapping.TabIndex = 8;
            this.gridMapping.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gwMapping});
            // 
            // gwMapping
            // 
            this.gwMapping.GridControl = this.gridMapping;
            this.gwMapping.Name = "gwMapping";
            this.gwMapping.OptionsView.ShowGroupPanel = false;
            // 
            // btnTamam
            // 
            this.btnTamam.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnTamam.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnTamam.Location = new System.Drawing.Point(570, 20);
            this.btnTamam.Name = "btnTamam";
            this.btnTamam.Size = new System.Drawing.Size(75, 23);
            this.btnTamam.TabIndex = 9;
            this.btnTamam.Text = "Tamam";
            this.btnTamam.Click += new System.EventHandler(this.btnTamam_Click);
            // 
            // btnVazgec
            // 
            this.btnVazgec.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnVazgec.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnVazgec.Location = new System.Drawing.Point(570, 49);
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.Size = new System.Drawing.Size(75, 23);
            this.btnVazgec.TabIndex = 10;
            this.btnVazgec.Text = "Vazgeç";
            this.btnVazgec.Click += new System.EventHandler(this.btnVazgec_Click);
            // 
            // frmColumnMapping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 433);
            this.Controls.Add(this.btnVazgec);
            this.Controls.Add(this.btnTamam);
            this.Controls.Add(this.gridMapping);
            this.Controls.Add(this.btnEditSql);
            this.Controls.Add(this.checkIdentityInsert);
            this.Controls.Add(this.checkDropCreateTable);
            this.Controls.Add(this.radioTableOption);
            this.Controls.Add(this.lblHedef);
            this.Controls.Add(this.lblKaynak);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "frmColumnMapping";
            this.Text = "frmColumnMapping";
            this.Load += new System.EventHandler(this.frmColumnMapping_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radioTableOption.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkDropCreateTable.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkIdentityInsert.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMapping)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gwMapping)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl lblKaynak;
        private DevExpress.XtraEditors.LabelControl lblHedef;
        private DevExpress.XtraEditors.RadioGroup radioTableOption;
        private DevExpress.XtraEditors.CheckEdit checkDropCreateTable;
        private DevExpress.XtraEditors.CheckEdit checkIdentityInsert;
        private DevExpress.XtraEditors.SimpleButton btnEditSql;
        private DevExpress.XtraGrid.GridControl gridMapping;
        private DevExpress.XtraGrid.Views.Grid.GridView gwMapping;
        private DevExpress.XtraEditors.SimpleButton btnTamam;
        private DevExpress.XtraEditors.SimpleButton btnVazgec;
    }
}