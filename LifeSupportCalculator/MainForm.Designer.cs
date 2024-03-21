﻿namespace LifeSupportCalculator
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.iconList = new System.Windows.Forms.ImageList(this.components);
            this.stStrip = new System.Windows.Forms.StatusStrip();
            this.TSMI_App = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_App_Diagnostics = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_App_CheckUpdates = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_App_Sp1 = new System.Windows.Forms.ToolStripSeparator();
            this.TSMI_App_AppPref = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_App_Sp2 = new System.Windows.Forms.ToolStripSeparator();
            this.TSMI_App_AppRestart = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_App_AppClose = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_View = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_View_Visuals = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_View_Visuals_Simple = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_View_Visuals_Detail = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Help_About = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Help_Homepage = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Help_GitRepo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnStrip = new System.Windows.Forms.MenuStrip();
            this.matCd1 = new MaterialSkin.Controls.MaterialCard();
            this.matLbl1 = new MaterialSkin.Controls.MaterialLabel();
            this.gBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.splC = new System.Windows.Forms.SplitContainer();
            this.UIIconList = new System.Windows.Forms.ImageList(this.components);
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.matCd2 = new MaterialSkin.Controls.MaterialCard();
            this.mnStrip.SuspendLayout();
            this.matCd1.SuspendLayout();
            this.gBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splC)).BeginInit();
            this.splC.Panel1.SuspendLayout();
            this.splC.Panel2.SuspendLayout();
            this.splC.SuspendLayout();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // iconList
            // 
            this.iconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iconList.ImageStream")));
            this.iconList.TransparentColor = System.Drawing.Color.Transparent;
            this.iconList.Images.SetKeyName(0, "icon_calculates.ico");
            this.iconList.Images.SetKeyName(1, "icon_analytics.ico");
            this.iconList.Images.SetKeyName(2, "icon_export.ico");
            this.iconList.Images.SetKeyName(3, "icon_export_to_drive.ico");
            this.iconList.Images.SetKeyName(4, "icon_export_to_cloud.ico");
            // 
            // stStrip
            // 
            this.stStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            resources.ApplyResources(this.stStrip, "stStrip");
            this.stStrip.Name = "stStrip";
            this.stStrip.SizingGrip = false;
            // 
            // TSMI_App
            // 
            this.TSMI_App.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_App_Diagnostics,
            this.TSMI_App_CheckUpdates,
            this.TSMI_App_Sp1,
            this.TSMI_App_AppPref,
            this.TSMI_App_Sp2,
            this.TSMI_App_AppRestart,
            this.TSMI_App_AppClose});
            this.TSMI_App.Name = "TSMI_App";
            resources.ApplyResources(this.TSMI_App, "TSMI_App");
            // 
            // TSMI_App_Diagnostics
            // 
            this.TSMI_App_Diagnostics.Name = "TSMI_App_Diagnostics";
            resources.ApplyResources(this.TSMI_App_Diagnostics, "TSMI_App_Diagnostics");
            this.TSMI_App_Diagnostics.Click += new System.EventHandler(this.TSMI_App_Diagnostics_Click);
            // 
            // TSMI_App_CheckUpdates
            // 
            this.TSMI_App_CheckUpdates.Name = "TSMI_App_CheckUpdates";
            resources.ApplyResources(this.TSMI_App_CheckUpdates, "TSMI_App_CheckUpdates");
            this.TSMI_App_CheckUpdates.Click += new System.EventHandler(this.TSMI_App_CheckUpdates_Click);
            // 
            // TSMI_App_Sp1
            // 
            this.TSMI_App_Sp1.Name = "TSMI_App_Sp1";
            resources.ApplyResources(this.TSMI_App_Sp1, "TSMI_App_Sp1");
            // 
            // TSMI_App_AppPref
            // 
            this.TSMI_App_AppPref.Name = "TSMI_App_AppPref";
            resources.ApplyResources(this.TSMI_App_AppPref, "TSMI_App_AppPref");
            this.TSMI_App_AppPref.Click += new System.EventHandler(this.TSMI_App_AppPref_Click);
            // 
            // TSMI_App_Sp2
            // 
            this.TSMI_App_Sp2.Name = "TSMI_App_Sp2";
            resources.ApplyResources(this.TSMI_App_Sp2, "TSMI_App_Sp2");
            // 
            // TSMI_App_AppRestart
            // 
            this.TSMI_App_AppRestart.Name = "TSMI_App_AppRestart";
            resources.ApplyResources(this.TSMI_App_AppRestart, "TSMI_App_AppRestart");
            this.TSMI_App_AppRestart.Click += new System.EventHandler(this.TSMI_App_AppRestart_Click);
            // 
            // TSMI_App_AppClose
            // 
            this.TSMI_App_AppClose.Name = "TSMI_App_AppClose";
            resources.ApplyResources(this.TSMI_App_AppClose, "TSMI_App_AppClose");
            this.TSMI_App_AppClose.Click += new System.EventHandler(this.TSMI_App_AppClose_Click);
            // 
            // TSMI_View
            // 
            this.TSMI_View.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_View_Visuals});
            this.TSMI_View.Name = "TSMI_View";
            resources.ApplyResources(this.TSMI_View, "TSMI_View");
            // 
            // TSMI_View_Visuals
            // 
            this.TSMI_View_Visuals.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_View_Visuals_Simple,
            this.TSMI_View_Visuals_Detail});
            this.TSMI_View_Visuals.Name = "TSMI_View_Visuals";
            resources.ApplyResources(this.TSMI_View_Visuals, "TSMI_View_Visuals");
            // 
            // TSMI_View_Visuals_Simple
            // 
            this.TSMI_View_Visuals_Simple.Name = "TSMI_View_Visuals_Simple";
            resources.ApplyResources(this.TSMI_View_Visuals_Simple, "TSMI_View_Visuals_Simple");
            this.TSMI_View_Visuals_Simple.Click += new System.EventHandler(this.TSMI_View_Visuals_Simple_Click);
            // 
            // TSMI_View_Visuals_Detail
            // 
            this.TSMI_View_Visuals_Detail.Checked = true;
            this.TSMI_View_Visuals_Detail.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TSMI_View_Visuals_Detail.Name = "TSMI_View_Visuals_Detail";
            resources.ApplyResources(this.TSMI_View_Visuals_Detail, "TSMI_View_Visuals_Detail");
            this.TSMI_View_Visuals_Detail.Click += new System.EventHandler(this.TSMI_View_Visuals_Detail_Click);
            // 
            // TSMI_Help
            // 
            this.TSMI_Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_Help_About,
            this.TSMI_Help_Homepage,
            this.TSMI_Help_GitRepo});
            this.TSMI_Help.Name = "TSMI_Help";
            resources.ApplyResources(this.TSMI_Help, "TSMI_Help");
            // 
            // TSMI_Help_About
            // 
            this.TSMI_Help_About.Name = "TSMI_Help_About";
            resources.ApplyResources(this.TSMI_Help_About, "TSMI_Help_About");
            this.TSMI_Help_About.Click += new System.EventHandler(this.TSMI_Help_About_Click);
            // 
            // TSMI_Help_Homepage
            // 
            this.TSMI_Help_Homepage.Name = "TSMI_Help_Homepage";
            resources.ApplyResources(this.TSMI_Help_Homepage, "TSMI_Help_Homepage");
            this.TSMI_Help_Homepage.Click += new System.EventHandler(this.TSMI_Help_Homepage_Click);
            // 
            // TSMI_Help_GitRepo
            // 
            this.TSMI_Help_GitRepo.Name = "TSMI_Help_GitRepo";
            resources.ApplyResources(this.TSMI_Help_GitRepo, "TSMI_Help_GitRepo");
            this.TSMI_Help_GitRepo.Click += new System.EventHandler(this.TSMI_Help_GitRepo_Click);
            // 
            // mnStrip
            // 
            resources.ApplyResources(this.mnStrip, "mnStrip");
            this.mnStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_App,
            this.TSMI_View,
            this.TSMI_Help});
            this.mnStrip.Name = "mnStrip";
            // 
            // matCd1
            // 
            resources.ApplyResources(this.matCd1, "matCd1");
            this.matCd1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.matCd1.Controls.Add(this.matLbl1);
            this.matCd1.Controls.Add(this.gBox1);
            this.matCd1.Depth = 0;
            this.matCd1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.matCd1.MouseState = MaterialSkin.MouseState.HOVER;
            this.matCd1.Name = "matCd1";
            // 
            // matLbl1
            // 
            resources.ApplyResources(this.matLbl1, "matLbl1");
            this.matLbl1.Depth = 0;
            this.matLbl1.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.matLbl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.matLbl1.Name = "matLbl1";
            // 
            // gBox1
            // 
            this.gBox1.Controls.Add(this.tableLayoutPanel1);
            resources.ApplyResources(this.gBox1, "gBox1");
            this.gBox1.Name = "gBox1";
            this.gBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.materialLabel1, 0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // materialLabel1
            // 
            resources.ApplyResources(this.materialLabel1, "materialLabel1");
            this.materialLabel1.Depth = 0;
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            // 
            // splC
            // 
            resources.ApplyResources(this.splC, "splC");
            this.splC.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splC.Name = "splC";
            // 
            // splC.Panel1
            // 
            this.splC.Panel1.Controls.Add(this.matCd1);
            // 
            // splC.Panel2
            // 
            this.splC.Panel2.Controls.Add(this.matCd2);
            // 
            // UIIconList
            // 
            this.UIIconList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            resources.ApplyResources(this.UIIconList, "UIIconList");
            this.UIIconList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Depth = 0;
            resources.ApplyResources(this.materialTabControl1, "materialTabControl1");
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splC);
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // matCd2
            // 
            resources.ApplyResources(this.matCd2, "matCd2");
            this.matCd2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.matCd2.Depth = 0;
            this.matCd2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.matCd2.MouseState = MaterialSkin.MouseState.HOVER;
            this.matCd2.Name = "matCd2";
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.stStrip);
            this.Controls.Add(this.mnStrip);
            this.DrawerShowIconsWhenHidden = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainMenuStrip = this.mnStrip;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Sizable = false;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mnStrip.ResumeLayout(false);
            this.mnStrip.PerformLayout();
            this.matCd1.ResumeLayout(false);
            this.matCd1.PerformLayout();
            this.gBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.splC.Panel1.ResumeLayout(false);
            this.splC.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splC)).EndInit();
            this.splC.ResumeLayout(false);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList iconList;
        private System.Windows.Forms.StatusStrip stStrip;
        private System.Windows.Forms.ToolStripMenuItem TSMI_App;
        private System.Windows.Forms.ToolStripMenuItem TSMI_App_Diagnostics;
        private System.Windows.Forms.ToolStripMenuItem TSMI_App_CheckUpdates;
        private System.Windows.Forms.ToolStripSeparator TSMI_App_Sp1;
        private System.Windows.Forms.ToolStripMenuItem TSMI_App_AppPref;
        private System.Windows.Forms.ToolStripSeparator TSMI_App_Sp2;
        private System.Windows.Forms.ToolStripMenuItem TSMI_App_AppRestart;
        private System.Windows.Forms.ToolStripMenuItem TSMI_App_AppClose;
        private System.Windows.Forms.ToolStripMenuItem TSMI_View;
        private System.Windows.Forms.ToolStripMenuItem TSMI_View_Visuals;
        private System.Windows.Forms.ToolStripMenuItem TSMI_View_Visuals_Simple;
        private System.Windows.Forms.ToolStripMenuItem TSMI_View_Visuals_Detail;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Help;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Help_About;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Help_Homepage;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Help_GitRepo;
        private System.Windows.Forms.MenuStrip mnStrip;
        private System.Windows.Forms.SplitContainer splC;
        private MaterialSkin.Controls.MaterialCard matCd1;
        private System.Windows.Forms.GroupBox gBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.ImageList UIIconList;
        private MaterialSkin.Controls.MaterialLabel matLbl1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialSkin.Controls.MaterialCard matCd2;
    }
}

