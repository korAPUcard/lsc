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
            this.iconList1 = new System.Windows.Forms.ImageList(this.components);
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
            this.matCd2 = new MaterialSkin.Controls.MaterialCard();
            this.gBox1B = new System.Windows.Forms.GroupBox();
            this.tblLayout1B = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.iconList_LT24 = new System.Windows.Forms.ImageList(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.matCd1 = new MaterialSkin.Controls.MaterialCard();
            this.gBox1A = new System.Windows.Forms.GroupBox();
            this.tblLayout1A = new System.Windows.Forms.TableLayoutPanel();
            this.iconLbl9 = new System.Windows.Forms.Label();
            this.iconLbl6 = new System.Windows.Forms.Label();
            this.iconLbl1 = new System.Windows.Forms.Label();
            this.iconLbl2 = new System.Windows.Forms.Label();
            this.iconLbl3 = new System.Windows.Forms.Label();
            this.iconLbl4 = new System.Windows.Forms.Label();
            this.iconLbl5 = new System.Windows.Forms.Label();
            this.iconLbl7 = new System.Windows.Forms.Label();
            this.iconLbl8 = new System.Windows.Forms.Label();
            this.iconLbl10 = new System.Windows.Forms.Label();
            this.gBox2A = new System.Windows.Forms.GroupBox();
            this.tblLayout2A = new System.Windows.Forms.TableLayoutPanel();
            this.iconBox1A = new System.Windows.Forms.PictureBox();
            this.tblLayout3A = new System.Windows.Forms.TableLayoutPanel();
            this.iconLbl11 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.splC = new System.Windows.Forms.SplitContainer();
            this.tabP2 = new System.Windows.Forms.TabPage();
            this.tabP3 = new System.Windows.Forms.TabPage();
            this.iconList_DT24 = new System.Windows.Forms.ImageList(this.components);
            this.iconList_LT48 = new System.Windows.Forms.ImageList(this.components);
            this.iconList_DT48 = new System.Windows.Forms.ImageList(this.components);
            this.mnStrip.SuspendLayout();
            this.matTabC.SuspendLayout();
            this.tabP1.SuspendLayout();
            this.matCd2.SuspendLayout();
            this.gBox1B.SuspendLayout();
            this.tblLayout1B.SuspendLayout();
            this.matCd1.SuspendLayout();
            this.gBox1A.SuspendLayout();
            this.tblLayout1A.SuspendLayout();
            this.gBox2A.SuspendLayout();
            this.tblLayout2A.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconBox1A)).BeginInit();
            this.tblLayout3A.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splC)).BeginInit();
            this.splC.SuspendLayout();
            this.SuspendLayout();
            // 
            // iconList1
            // 
            this.iconList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iconList1.ImageStream")));
            this.iconList1.TransparentColor = System.Drawing.Color.Transparent;
            this.iconList1.Images.SetKeyName(0, "icon_calculate.ico");
            this.iconList1.Images.SetKeyName(1, "icon_analytics.ico");
            this.iconList1.Images.SetKeyName(2, "icon_export.ico");
            this.iconList1.Images.SetKeyName(3, "icon_export_to_drive.ico");
            this.iconList1.Images.SetKeyName(4, "icon_export_to_cloud.ico");
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
            // matTabC
            // 
            this.matTabC.Controls.Add(this.tabP1);
            this.matTabC.Controls.Add(this.tabP2);
            this.matTabC.Controls.Add(this.tabP3);
            this.matTabC.Depth = 0;
            resources.ApplyResources(this.matTabC, "matTabC");
            this.matTabC.ImageList = this.iconList1;
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
            // matCd2
            // 
            resources.ApplyResources(this.matCd2, "matCd2");
            this.matCd2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.matCd2.Controls.Add(this.gBox1B);
            this.matCd2.Controls.Add(this.lbl2);
            this.matCd2.Depth = 0;
            this.matCd2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.matCd2.MouseState = MaterialSkin.MouseState.HOVER;
            this.matCd2.Name = "matCd2";
            // 
            // gBox1B
            // 
            this.gBox1B.Controls.Add(this.tblLayout1B);
            resources.ApplyResources(this.gBox1B, "gBox1B");
            this.gBox1B.Name = "gBox1B";
            this.gBox1B.TabStop = false;
            // 
            // tblLayout1B
            // 
            resources.ApplyResources(this.tblLayout1B, "tblLayout1B");
            this.tblLayout1B.Controls.Add(this.label1, 0, 5);
            this.tblLayout1B.Controls.Add(this.label2, 0, 0);
            this.tblLayout1B.Controls.Add(this.label3, 0, 1);
            this.tblLayout1B.Controls.Add(this.label4, 0, 2);
            this.tblLayout1B.Controls.Add(this.label5, 0, 3);
            this.tblLayout1B.Controls.Add(this.label6, 0, 4);
            this.tblLayout1B.Controls.Add(this.label7, 0, 6);
            this.tblLayout1B.Controls.Add(this.label8, 0, 7);
            this.tblLayout1B.ForeColor = System.Drawing.SystemColors.Control;
            this.tblLayout1B.Name = "tblLayout1B";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ImageList = this.iconList_LT24;
            this.label1.Name = "label1";
            // 
            // iconList_LT24
            // 
            this.iconList_LT24.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iconList_LT24.ImageStream")));
            this.iconList_LT24.TransparentColor = System.Drawing.Color.Transparent;
            this.iconList_LT24.Images.SetKeyName(0, "icon_nutrition_D.ico");
            this.iconList_LT24.Images.SetKeyName(1, "icon_hydration_D.ico");
            this.iconList_LT24.Images.SetKeyName(2, "icon_solidwaste_D.ico");
            this.iconList_LT24.Images.SetKeyName(3, "icon_liquidwaste_D.ico");
            this.iconList_LT24.Images.SetKeyName(4, "icon_hygiene_D.ico");
            this.iconList_LT24.Images.SetKeyName(5, "icon_temperature_D.ico");
            this.iconList_LT24.Images.SetKeyName(6, "icon_oxygen_D.ico");
            this.iconList_LT24.Images.SetKeyName(7, "icon_carbon_dioxide_D.ico");
            this.iconList_LT24.Images.SetKeyName(8, "icon_health_D.ico");
            this.iconList_LT24.Images.SetKeyName(9, "icon_mood_D.ico");
            this.iconList_LT24.Images.SetKeyName(10, "icon_medicine_D.ico");
            this.iconList_LT24.Images.SetKeyName(11, "icon_death_D.ico");
            this.iconList_LT24.Images.SetKeyName(12, "icon_power_D.ico");
            this.iconList_LT24.Images.SetKeyName(13, "icon_oxygen_supply_D.ico");
            this.iconList_LT24.Images.SetKeyName(14, "icon_water_supply_D.ico");
            this.iconList_LT24.Images.SetKeyName(15, "icon_population_D.ico");
            this.iconList_LT24.Images.SetKeyName(16, "icon_environment_D.ico");
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ImageList = this.iconList_LT24;
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ImageList = this.iconList_LT24;
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ImageList = this.iconList_LT24;
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ImageList = this.iconList_LT24;
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.ImageList = this.iconList_LT24;
            this.label6.Name = "label6";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.ImageList = this.iconList_LT24;
            this.label7.Name = "label7";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.ImageList = this.iconList_LT24;
            this.label8.Name = "label8";
            // 
            // lbl2
            // 
            resources.ApplyResources(this.lbl2, "lbl2");
            this.lbl2.Name = "lbl2";
            this.lbl2.Paint += new System.Windows.Forms.PaintEventHandler(this.lbl2_Paint);
            // 
            // matCd1
            // 
            resources.ApplyResources(this.matCd1, "matCd1");
            this.matCd1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.matCd1.Controls.Add(this.gBox1A);
            this.matCd1.Controls.Add(this.gBox2A);
            this.matCd1.Controls.Add(this.lbl1);
            this.matCd1.Depth = 0;
            this.matCd1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.matCd1.MouseState = MaterialSkin.MouseState.HOVER;
            this.matCd1.Name = "matCd1";
            // 
            // gBox1A
            // 
            this.gBox1A.Controls.Add(this.tblLayout1A);
            resources.ApplyResources(this.gBox1A, "gBox1A");
            this.gBox1A.Name = "gBox1A";
            this.gBox1A.TabStop = false;
            // 
            // tblLayout1A
            // 
            resources.ApplyResources(this.tblLayout1A, "tblLayout1A");
            this.tblLayout1A.Controls.Add(this.iconLbl9, 0, 8);
            this.tblLayout1A.Controls.Add(this.iconLbl6, 0, 5);
            this.tblLayout1A.Controls.Add(this.iconLbl1, 0, 0);
            this.tblLayout1A.Controls.Add(this.iconLbl2, 0, 1);
            this.tblLayout1A.Controls.Add(this.iconLbl3, 0, 2);
            this.tblLayout1A.Controls.Add(this.iconLbl4, 0, 3);
            this.tblLayout1A.Controls.Add(this.iconLbl5, 0, 4);
            this.tblLayout1A.Controls.Add(this.iconLbl7, 0, 6);
            this.tblLayout1A.Controls.Add(this.iconLbl8, 0, 7);
            this.tblLayout1A.Controls.Add(this.iconLbl10, 0, 9);
            this.tblLayout1A.ForeColor = System.Drawing.SystemColors.Control;
            this.tblLayout1A.Name = "tblLayout1A";
            // 
            // iconLbl9
            // 
            resources.ApplyResources(this.iconLbl9, "iconLbl9");
            this.iconLbl9.ImageList = this.iconList_LT24;
            this.iconLbl9.Name = "iconLbl9";
            // 
            // iconLbl6
            // 
            resources.ApplyResources(this.iconLbl6, "iconLbl6");
            this.iconLbl6.ImageList = this.iconList_LT24;
            this.iconLbl6.Name = "iconLbl6";
            // 
            // iconLbl1
            // 
            resources.ApplyResources(this.iconLbl1, "iconLbl1");
            this.iconLbl1.ImageList = this.iconList_LT24;
            this.iconLbl1.Name = "iconLbl1";
            // 
            // iconLbl2
            // 
            resources.ApplyResources(this.iconLbl2, "iconLbl2");
            this.iconLbl2.ImageList = this.iconList_LT24;
            this.iconLbl2.Name = "iconLbl2";
            // 
            // iconLbl3
            // 
            resources.ApplyResources(this.iconLbl3, "iconLbl3");
            this.iconLbl3.ImageList = this.iconList_LT24;
            this.iconLbl3.Name = "iconLbl3";
            // 
            // iconLbl4
            // 
            resources.ApplyResources(this.iconLbl4, "iconLbl4");
            this.iconLbl4.ImageList = this.iconList_LT24;
            this.iconLbl4.Name = "iconLbl4";
            // 
            // iconLbl5
            // 
            resources.ApplyResources(this.iconLbl5, "iconLbl5");
            this.iconLbl5.ImageList = this.iconList_LT24;
            this.iconLbl5.Name = "iconLbl5";
            // 
            // iconLbl7
            // 
            resources.ApplyResources(this.iconLbl7, "iconLbl7");
            this.iconLbl7.ImageList = this.iconList_LT24;
            this.iconLbl7.Name = "iconLbl7";
            // 
            // iconLbl8
            // 
            resources.ApplyResources(this.iconLbl8, "iconLbl8");
            this.iconLbl8.ImageList = this.iconList_LT24;
            this.iconLbl8.Name = "iconLbl8";
            // 
            // iconLbl10
            // 
            resources.ApplyResources(this.iconLbl10, "iconLbl10");
            this.iconLbl10.ImageList = this.iconList_LT24;
            this.iconLbl10.Name = "iconLbl10";
            // 
            // gBox2A
            // 
            this.gBox2A.Controls.Add(this.tblLayout2A);
            this.gBox2A.Controls.Add(this.tblLayout3A);
            resources.ApplyResources(this.gBox2A, "gBox2A");
            this.gBox2A.Name = "gBox2A";
            this.gBox2A.TabStop = false;
            // 
            // tblLayout2A
            // 
            resources.ApplyResources(this.tblLayout2A, "tblLayout2A");
            this.tblLayout2A.Controls.Add(this.iconBox1A, 0, 0);
            this.tblLayout2A.Name = "tblLayout2A";
            // 
            // iconBox1A
            // 
            resources.ApplyResources(this.iconBox1A, "iconBox1A");
            this.iconBox1A.Name = "iconBox1A";
            this.iconBox1A.TabStop = false;
            // 
            // tblLayout3A
            // 
            resources.ApplyResources(this.tblLayout3A, "tblLayout3A");
            this.tblLayout3A.Controls.Add(this.iconLbl11, 0, 0);
            this.tblLayout3A.Name = "tblLayout3A";
            // 
            // iconLbl11
            // 
            resources.ApplyResources(this.iconLbl11, "iconLbl11");
            this.iconLbl11.ImageList = this.iconList_LT24;
            this.iconLbl11.Name = "iconLbl11";
            // 
            // lbl1
            // 
            resources.ApplyResources(this.lbl1, "lbl1");
            this.lbl1.Name = "lbl1";
            this.lbl1.Paint += new System.Windows.Forms.PaintEventHandler(this.lbl1_Paint);
            // 
            // splC
            // 
            resources.ApplyResources(this.splC, "splC");
            this.splC.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splC.Name = "splC";
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
            // iconList_DT24
            // 
            this.iconList_DT24.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iconList_DT24.ImageStream")));
            this.iconList_DT24.TransparentColor = System.Drawing.Color.Transparent;
            this.iconList_DT24.Images.SetKeyName(0, "icon_nutrition_W.ico");
            this.iconList_DT24.Images.SetKeyName(1, "icon_hydration_W.ico");
            this.iconList_DT24.Images.SetKeyName(2, "icon_solidwaste_W.ico");
            this.iconList_DT24.Images.SetKeyName(3, "icon_liquidwaste_W.ico");
            this.iconList_DT24.Images.SetKeyName(4, "icon_hygiene_W.ico");
            this.iconList_DT24.Images.SetKeyName(5, "icon_temperature_W.ico");
            this.iconList_DT24.Images.SetKeyName(6, "icon_oxygen_W.ico");
            this.iconList_DT24.Images.SetKeyName(7, "icon_carbon_dioxide_W.ico");
            this.iconList_DT24.Images.SetKeyName(8, "icon_health_W.ico");
            this.iconList_DT24.Images.SetKeyName(9, "icon_mood_W.ico");
            this.iconList_DT24.Images.SetKeyName(10, "icon_medicine_W.ico");
            this.iconList_DT24.Images.SetKeyName(11, "icon_death_W.ico");
            this.iconList_DT24.Images.SetKeyName(12, "icon_power_W.ico");
            this.iconList_DT24.Images.SetKeyName(13, "icon_oxygen_supply_W.ico");
            this.iconList_DT24.Images.SetKeyName(14, "icon_water_supply_W.ico");
            this.iconList_DT24.Images.SetKeyName(15, "icon_population_W.ico");
            this.iconList_DT24.Images.SetKeyName(16, "icon_environment_W.ico");
            // 
            // iconList_LT48
            // 
            this.iconList_LT48.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iconList_LT48.ImageStream")));
            this.iconList_LT48.TransparentColor = System.Drawing.Color.Transparent;
            this.iconList_LT48.Images.SetKeyName(0, "icon_population_D.ico");
            this.iconList_LT48.Images.SetKeyName(1, "icon_environment_D.ico");
            // 
            // iconList_DT48
            // 
            this.iconList_DT48.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            resources.ApplyResources(this.iconList_DT48, "iconList_DT48");
            this.iconList_DT48.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
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
            this.matCd2.ResumeLayout(false);
            this.gBox1B.ResumeLayout(false);
            this.tblLayout1B.ResumeLayout(false);
            this.matCd1.ResumeLayout(false);
            this.gBox1A.ResumeLayout(false);
            this.tblLayout1A.ResumeLayout(false);
            this.gBox2A.ResumeLayout(false);
            this.tblLayout2A.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconBox1A)).EndInit();
            this.tblLayout3A.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splC)).EndInit();
            this.splC.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList iconList1;
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
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.GroupBox gBox1A;
        private System.Windows.Forms.TableLayoutPanel tblLayout1A;
        private System.Windows.Forms.ImageList iconList_LT24;
        private System.Windows.Forms.Label iconLbl1;
        private System.Windows.Forms.ImageList iconList_DT24;
        private System.Windows.Forms.Label iconLbl6;
        private System.Windows.Forms.Label iconLbl2;
        private System.Windows.Forms.Label iconLbl3;
        private System.Windows.Forms.Label iconLbl4;
        private System.Windows.Forms.Label iconLbl5;
        private System.Windows.Forms.Label iconLbl7;
        private System.Windows.Forms.Label iconLbl8;
        private System.Windows.Forms.GroupBox gBox2A;
        private System.Windows.Forms.GroupBox gBox1B;
        private System.Windows.Forms.TableLayoutPanel tblLayout1B;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TableLayoutPanel tblLayout3A;
        private System.Windows.Forms.Label iconLbl9;
        private System.Windows.Forms.Label iconLbl11;
        private System.Windows.Forms.Label iconLbl10;
        private System.Windows.Forms.TableLayoutPanel tblLayout2A;
        private System.Windows.Forms.PictureBox iconBox1A;
        private System.Windows.Forms.ImageList iconList_LT48;
        private System.Windows.Forms.ImageList iconList_DT48;
    }
}

