namespace XlsImporter
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnOpenFile = new DevExpress.XtraBars.BarButtonItem();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.cboxSheets = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.barStaticItem2 = new DevExpress.XtraBars.BarStaticItem();
            this.radioHeader = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemRadioGroup1 = new DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup();
            this.btnSave2Table = new DevExpress.XtraBars.BarButtonItem();
            this.btnKapat = new DevExpress.XtraBars.BarLargeButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.marqueProgress = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemMarqueeProgressBar1 = new DevExpress.XtraEditors.Repository.RepositoryItemMarqueeProgressBar();
            this.bartextTime = new DevExpress.XtraBars.BarStaticItem();
            this.bartextFile = new DevExpress.XtraBars.BarStaticItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barLargeButtonItem1 = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barEditItem3 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTextEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTextEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemTimeEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit();
            this.gridXlsFile = new DevExpress.XtraGrid.GridControl();
            this.gwXlsFile = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRadioGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMarqueeProgressBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTimeEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridXlsFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gwXlsFile)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnOpenFile,
            this.barStaticItem1,
            this.cboxSheets,
            this.btnSave2Table,
            this.radioHeader,
            this.barStaticItem2,
            this.barLargeButtonItem1,
            this.marqueProgress,
            this.barEditItem3,
            this.btnKapat,
            this.barEditItem1,
            this.bartextTime,
            this.bartextFile});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 15;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1,
            this.repositoryItemComboBox1,
            this.repositoryItemRadioGroup1,
            this.repositoryItemTimeEdit1,
            this.repositoryItemMarqueeProgressBar1,
            this.repositoryItemTextEdit2,
            this.repositoryItemTextEdit3});
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.FloatLocation = new System.Drawing.Point(-228, 161);
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnOpenFile, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItem1, true),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, this.cboxSheets, "", false, true, true, 148),
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItem2, true),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, this.radioHeader, "", false, true, true, 94),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSave2Table, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnKapat, true)});
            this.bar2.OptionsBar.AllowRename = true;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Caption = "Dosya Aç...";
            this.btnOpenFile.Id = 0;
            this.btnOpenFile.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O));
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.OwnFont = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.btnOpenFile.UseOwnFont = true;
            this.btnOpenFile.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnOpenFile_ItemClick);
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.barStaticItem1.Caption = "Sayfalar";
            this.barStaticItem1.Id = 1;
            this.barStaticItem1.Name = "barStaticItem1";
            this.barStaticItem1.OwnFont = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near;
            this.barStaticItem1.UseOwnFont = true;
            // 
            // cboxSheets
            // 
            this.cboxSheets.Caption = "barEditItem1";
            this.cboxSheets.Edit = this.repositoryItemComboBox1;
            this.cboxSheets.Id = 3;
            this.cboxSheets.Name = "cboxSheets";
            this.cboxSheets.EditValueChanged += new System.EventHandler(this.cboxSheets_EditValueChanged);
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // barStaticItem2
            // 
            this.barStaticItem2.Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.barStaticItem2.Caption = "Başlık";
            this.barStaticItem2.Id = 6;
            this.barStaticItem2.Name = "barStaticItem2";
            this.barStaticItem2.OwnFont = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.barStaticItem2.TextAlignment = System.Drawing.StringAlignment.Near;
            this.barStaticItem2.UseOwnFont = true;
            // 
            // radioHeader
            // 
            this.radioHeader.Caption = "Başlık";
            this.radioHeader.Edit = this.repositoryItemRadioGroup1;
            this.radioHeader.EditValue = 1;
            this.radioHeader.Id = 5;
            this.radioHeader.Name = "radioHeader";
            // 
            // repositoryItemRadioGroup1
            // 
            this.repositoryItemRadioGroup1.Appearance.Font = new System.Drawing.Font("Segoe Script", 8.25F);
            this.repositoryItemRadioGroup1.Appearance.Options.UseFont = true;
            this.repositoryItemRadioGroup1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.repositoryItemRadioGroup1.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Var"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Yok")});
            this.repositoryItemRadioGroup1.Name = "repositoryItemRadioGroup1";
            this.repositoryItemRadioGroup1.UseParentBackground = true;
            // 
            // btnSave2Table
            // 
            this.btnSave2Table.Caption = "Tabloya Kaydet...";
            this.btnSave2Table.Id = 4;
            this.btnSave2Table.Name = "btnSave2Table";
            this.btnSave2Table.OwnFont = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.btnSave2Table.UseOwnFont = true;
            this.btnSave2Table.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSave2Table_ItemClick);
            // 
            // btnKapat
            // 
            this.btnKapat.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btnKapat.Caption = "Kapat";
            this.btnKapat.Id = 11;
            this.btnKapat.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X));
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.OwnFont = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.btnKapat.UseOwnFont = true;
            this.btnKapat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKapat_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, this.marqueProgress, "", true, true, true, 132),
            new DevExpress.XtraBars.LinkPersistInfo(this.bartextTime, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.bartextFile, true)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // marqueProgress
            // 
            this.marqueProgress.Caption = "Progress";
            this.marqueProgress.Edit = this.repositoryItemMarqueeProgressBar1;
            this.marqueProgress.Id = 9;
            this.marqueProgress.Name = "marqueProgress";
            this.marqueProgress.VisibleWhenVertical = true;
            // 
            // repositoryItemMarqueeProgressBar1
            // 
            this.repositoryItemMarqueeProgressBar1.EndColor = System.Drawing.Color.Lime;
            this.repositoryItemMarqueeProgressBar1.Name = "repositoryItemMarqueeProgressBar1";
            this.repositoryItemMarqueeProgressBar1.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            // 
            // bartextTime
            // 
            this.bartextTime.Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.bartextTime.Caption = "bartextTime";
            this.bartextTime.Id = 13;
            this.bartextTime.Name = "bartextTime";
            this.bartextTime.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // bartextFile
            // 
            this.bartextFile.Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.bartextFile.Caption = "bartextFile";
            this.bartextFile.Id = 14;
            this.bartextFile.Name = "bartextFile";
            this.bartextFile.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barLargeButtonItem1
            // 
            this.barLargeButtonItem1.Caption = "Kapat";
            this.barLargeButtonItem1.Id = 7;
            this.barLargeButtonItem1.Name = "barLargeButtonItem1";
            // 
            // barEditItem3
            // 
            this.barEditItem3.Caption = "barEditItem3";
            this.barEditItem3.Edit = this.repositoryItemTextEdit2;
            this.barEditItem3.Id = 10;
            this.barEditItem3.Name = "barEditItem3";
            // 
            // repositoryItemTextEdit2
            // 
            this.repositoryItemTextEdit2.AutoHeight = false;
            this.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2";
            // 
            // barEditItem1
            // 
            this.barEditItem1.Caption = "bareditTime";
            this.barEditItem1.Edit = this.repositoryItemTextEdit3;
            this.barEditItem1.Id = 12;
            this.barEditItem1.Name = "barEditItem1";
            this.barEditItem1.UseOwnFont = true;
            // 
            // repositoryItemTextEdit3
            // 
            this.repositoryItemTextEdit3.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.repositoryItemTextEdit3.Appearance.ForeColor = System.Drawing.Color.Red;
            this.repositoryItemTextEdit3.Appearance.Options.UseFont = true;
            this.repositoryItemTextEdit3.Appearance.Options.UseForeColor = true;
            this.repositoryItemTextEdit3.Name = "repositoryItemTextEdit3";
            this.repositoryItemTextEdit3.ReadOnly = true;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // repositoryItemTimeEdit1
            // 
            this.repositoryItemTimeEdit1.AutoHeight = false;
            this.repositoryItemTimeEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemTimeEdit1.Name = "repositoryItemTimeEdit1";
            // 
            // gridXlsFile
            // 
            this.gridXlsFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridXlsFile.Location = new System.Drawing.Point(0, 30);
            this.gridXlsFile.MainView = this.gwXlsFile;
            this.gridXlsFile.Name = "gridXlsFile";
            this.gridXlsFile.Size = new System.Drawing.Size(991, 584);
            this.gridXlsFile.TabIndex = 4;
            this.gridXlsFile.UseEmbeddedNavigator = true;
            this.gridXlsFile.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gwXlsFile});
            // 
            // gwXlsFile
            // 
            this.gwXlsFile.GridControl = this.gridXlsFile;
            this.gwXlsFile.Name = "gwXlsFile";
            this.gwXlsFile.OptionsView.ShowFooter = true;
            this.gwXlsFile.OptionsView.ShowGroupPanel = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 636);
            this.Controls.Add(this.gridXlsFile);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmMain";
            this.Text = "XLS Importer";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRadioGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMarqueeProgressBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTimeEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridXlsFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gwXlsFile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnOpenFile;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarEditItem cboxSheets;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraBars.BarButtonItem btnSave2Table;
        private DevExpress.XtraGrid.GridControl gridXlsFile;
        private DevExpress.XtraGrid.Views.Grid.GridView gwXlsFile;
        private DevExpress.XtraBars.BarEditItem radioHeader;
        private DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup repositoryItemRadioGroup1;
        private DevExpress.XtraBars.BarStaticItem barStaticItem2;
        private DevExpress.XtraBars.BarLargeButtonItem barLargeButtonItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit repositoryItemTimeEdit1;
        private DevExpress.XtraBars.BarEditItem marqueProgress;
        private DevExpress.XtraEditors.Repository.RepositoryItemMarqueeProgressBar repositoryItemMarqueeProgressBar1;
        private DevExpress.XtraBars.BarLargeButtonItem btnKapat;
        private DevExpress.XtraBars.BarEditItem barEditItem3;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit2;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraBars.BarEditItem barEditItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit3;
        private DevExpress.XtraBars.BarStaticItem bartextTime;
        private DevExpress.XtraBars.BarStaticItem bartextFile;
    }
}

