namespace LifeSupportCalculator
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
            this.matTabC = new MaterialSkin.Controls.MaterialTabControl();
            this.tabP1 = new System.Windows.Forms.TabPage();
            this.tabP2 = new System.Windows.Forms.TabPage();
            this.tabP3 = new System.Windows.Forms.TabPage();
            this.splC = new System.Windows.Forms.SplitContainer();
            this.matCd1 = new MaterialSkin.Controls.MaterialCard();
            this.matCd2 = new MaterialSkin.Controls.MaterialCard();
            this.mnStrip.SuspendLayout();
            this.matTabC.SuspendLayout();
            this.tabP1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splC)).BeginInit();
            this.splC.SuspendLayout();
            this.SuspendLayout();
            // 
            // iconList
            // 
            this.iconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iconList.ImageStream")));
            this.iconList.TransparentColor = System.Drawing.Color.Transparent;
            this.iconList.Images.SetKeyName(0, "icon_calculate.ico");
            this.iconList.Images.SetKeyName(1, "icon_settings.ico");
            // 
            // stStrip
            // 
            this.stStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            resources.ApplyResources(this.stStrip, "stStrip");
            this.stStrip.Name = "stStrip";
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
            // matTabC
            // 
            this.matTabC.Controls.Add(this.tabP1);
            this.matTabC.Controls.Add(this.tabP2);
            this.matTabC.Controls.Add(this.tabP3);
            this.matTabC.Depth = 0;
            resources.ApplyResources(this.matTabC, "matTabC");
            this.matTabC.ImageList = this.iconList;
            this.matTabC.MouseState = MaterialSkin.MouseState.HOVER;
            this.matTabC.Multiline = true;
            this.matTabC.Name = "matTabC";
            this.matTabC.SelectedIndex = 0;
            // 
            // tabP1
            // 
            this.tabP1.Controls.Add(this.matCd2);
            this.tabP1.Controls.Add(this.matCd1);
            this.tabP1.Controls.Add(this.splC);
            resources.ApplyResources(this.tabP1, "tabP1");
            this.tabP1.Name = "tabP1";
            this.tabP1.UseVisualStyleBackColor = true;
            // 
            // tabP2
            // 
            resources.ApplyResources(this.tabP2, "tabP2");
            this.tabP2.Name = "tabP2";
            this.tabP2.UseVisualStyleBackColor = true;
            // 
            // tabP3
            // 
            resources.ApplyResources(this.tabP3, "tabP3");
            this.tabP3.Name = "tabP3";
            this.tabP3.UseVisualStyleBackColor = true;
            // 
            // splC
            // 
            resources.ApplyResources(this.splC, "splC");
            this.splC.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splC.Name = "splC";
            // 
            // matCd1
            // 
            resources.ApplyResources(this.matCd1, "matCd1");
            this.matCd1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.matCd1.Depth = 0;
            this.matCd1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.matCd1.MouseState = MaterialSkin.MouseState.HOVER;
            this.matCd1.Name = "matCd1";
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
            this.Controls.Add(this.matTabC);
            this.Controls.Add(this.stStrip);
            this.Controls.Add(this.mnStrip);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.matTabC;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainMenuStrip = this.mnStrip;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Sizable = false;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mnStrip.ResumeLayout(false);
            this.mnStrip.PerformLayout();
            this.matTabC.ResumeLayout(false);
            this.tabP1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splC)).EndInit();
            this.splC.ResumeLayout(false);
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
        private MaterialSkin.Controls.MaterialTabControl matTabC;
        private System.Windows.Forms.TabPage tabP1;
        private System.Windows.Forms.TabPage tabP2;
        private System.Windows.Forms.TabPage tabP3;
        private System.Windows.Forms.SplitContainer splC;
        private MaterialSkin.Controls.MaterialCard matCd1;
        private MaterialSkin.Controls.MaterialCard matCd2;
    }
}

