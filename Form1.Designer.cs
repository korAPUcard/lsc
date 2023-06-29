
namespace LifeSupportCalculator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.mTabC1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPg1 = new System.Windows.Forms.TabPage();
            this.tabPg2 = new System.Windows.Forms.TabPage();
            this.tLayoutT2 = new System.Windows.Forms.TableLayoutPanel();
            this.mTabS1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.mTabC2 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPgT2A = new System.Windows.Forms.TabPage();
            this.tabPgT2B = new System.Windows.Forms.TabPage();
            this.tabPgT2C = new System.Windows.Forms.TabPage();
            this.mCardT2_StatusStrip = new MaterialSkin.Controls.MaterialCard();
            this.fLayoutT1_1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pbIcon_Proc = new System.Windows.Forms.PictureBox();
            this.mPB_Proc = new MaterialSkin.Controls.MaterialProgressBar();
            this.mDivT2_SS1 = new MaterialSkin.Controls.MaterialDivider();
            this.pbIcon_Mem = new System.Windows.Forms.PictureBox();
            this.mPB_Mem = new MaterialSkin.Controls.MaterialProgressBar();
            this.mDivT2_SS2 = new MaterialSkin.Controls.MaterialDivider();
            this.pbIcon_Batt = new System.Windows.Forms.PictureBox();
            this.mPB_Batt = new MaterialSkin.Controls.MaterialProgressBar();
            this.mDivT2_SS3 = new MaterialSkin.Controls.MaterialDivider();
            this.pbIcon_DTemp = new System.Windows.Forms.PictureBox();
            this.mPB_DTemp = new MaterialSkin.Controls.MaterialProgressBar();
            this.tabPgT2D = new System.Windows.Forms.TabPage();
            this.nIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.pcTimer = new System.Windows.Forms.Timer(this.components);
            this.pcProc = new System.Diagnostics.PerformanceCounter();
            this.pcMem = new System.Diagnostics.PerformanceCounter();
            this.tLayoutT1A = new System.Windows.Forms.TableLayoutPanel();
            this.ctxMS = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openPreferenceTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.performanceCounterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.closeApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.manualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openOfflineManualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onlineWikiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pT1A = new System.Windows.Forms.Panel();
            this.mCard_InputForm1 = new MaterialSkin.Controls.MaterialCard();
            this.mLabel_Input1 = new MaterialSkin.Controls.MaterialLabel();
            this.tLayout_InputForm1 = new System.Windows.Forms.TableLayoutPanel();
            this.mCard_InputForm2 = new MaterialSkin.Controls.MaterialCard();
            this.mLabel_Input2 = new MaterialSkin.Controls.MaterialLabel();
            this.tLayout_InputForm2 = new System.Windows.Forms.TableLayoutPanel();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.mLabel_Input3 = new MaterialSkin.Controls.MaterialLabel();
            this.tLayout_InputForm3 = new System.Windows.Forms.TableLayoutPanel();
            this.mSlider_CurrentFood = new MaterialSkin.Controls.MaterialSlider();
            this.mSlider_CurrentWater = new MaterialSkin.Controls.MaterialSlider();
            this.mSlider_CurrentOxygen = new MaterialSkin.Controls.MaterialSlider();
            this.mTB_MaxFood = new MaterialSkin.Controls.MaterialTextBox();
            this.mTB_MaxWater = new MaterialSkin.Controls.MaterialTextBox();
            this.mTB_MaxOxygen = new MaterialSkin.Controls.MaterialTextBox();
            this.mSlider_CurrentPower = new MaterialSkin.Controls.MaterialSlider();
            this.mTB_MaxPower = new MaterialSkin.Controls.MaterialTextBox();
            this.pbIcon_Food1 = new System.Windows.Forms.PictureBox();
            this.pbIcon_Water1 = new System.Windows.Forms.PictureBox();
            this.pbIcon_Oxygen1 = new System.Windows.Forms.PictureBox();
            this.pbIcon_Power1 = new System.Windows.Forms.PictureBox();
            this.mTB_Population = new MaterialSkin.Controls.MaterialTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.mTB_PowerVoltage = new MaterialSkin.Controls.MaterialTextBox();
            this.mTB_PowerConsumption = new MaterialSkin.Controls.MaterialTextBox();
            this.mCB_VoltageUnit = new MaterialSkin.Controls.MaterialComboBox();
            this.mCB_PowerConsUnit = new MaterialSkin.Controls.MaterialComboBox();
            this.mCB_WattUnit = new MaterialSkin.Controls.MaterialComboBox();
            this.pbIcon_Population = new System.Windows.Forms.PictureBox();
            this.pbIcon_Temperature = new System.Windows.Forms.PictureBox();
            this.mTB_CurrentTemperature = new MaterialSkin.Controls.MaterialTextBox();
            this.tLayout_InputForm4 = new System.Windows.Forms.TableLayoutPanel();
            this.pbIcon_Time = new System.Windows.Forms.PictureBox();
            this.mTB_TargetHoldingTime = new MaterialSkin.Controls.MaterialTextBox();
            this.mTB_SpareControl1 = new MaterialSkin.Controls.MaterialTextBox();
            this.tLayoutT1B = new System.Windows.Forms.TableLayoutPanel();
            this.mBtn_Calculate = new MaterialSkin.Controls.MaterialButton();
            this.fLayoutT1 = new System.Windows.Forms.FlowLayoutPanel();
            this.mTabC1.SuspendLayout();
            this.tabPg1.SuspendLayout();
            this.tabPg2.SuspendLayout();
            this.tLayoutT2.SuspendLayout();
            this.mTabC2.SuspendLayout();
            this.tabPgT2C.SuspendLayout();
            this.mCardT2_StatusStrip.SuspendLayout();
            this.fLayoutT1_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon_Proc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon_Mem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon_Batt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon_DTemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcProc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcMem)).BeginInit();
            this.tLayoutT1A.SuspendLayout();
            this.ctxMS.SuspendLayout();
            this.pT1A.SuspendLayout();
            this.mCard_InputForm1.SuspendLayout();
            this.tLayout_InputForm1.SuspendLayout();
            this.mCard_InputForm2.SuspendLayout();
            this.tLayout_InputForm2.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.tLayout_InputForm3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon_Food1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon_Water1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon_Oxygen1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon_Power1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon_Population)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon_Temperature)).BeginInit();
            this.tLayout_InputForm4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon_Time)).BeginInit();
            this.tLayoutT1B.SuspendLayout();
            this.fLayoutT1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgList
            // 
            this.imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList.ImageStream")));
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList.Images.SetKeyName(0, "icon_calculate.ico");
            this.imgList.Images.SetKeyName(1, "icon_settings.ico");
            this.imgList.Images.SetKeyName(2, "icon_memory.ico");
            this.imgList.Images.SetKeyName(3, "icon_memory_alt.ico");
            this.imgList.Images.SetKeyName(4, "icon_battery_full.ico");
            this.imgList.Images.SetKeyName(5, "icon_device_temperature.ico");
            // 
            // mTabC1
            // 
            this.mTabC1.Controls.Add(this.tabPg1);
            this.mTabC1.Controls.Add(this.tabPg2);
            this.mTabC1.Depth = 0;
            this.mTabC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mTabC1.ImageList = this.imgList;
            this.mTabC1.Location = new System.Drawing.Point(3, 68);
            this.mTabC1.MouseState = MaterialSkin.MouseState.HOVER;
            this.mTabC1.Multiline = true;
            this.mTabC1.Name = "mTabC1";
            this.mTabC1.SelectedIndex = 0;
            this.mTabC1.Size = new System.Drawing.Size(994, 529);
            this.mTabC1.TabIndex = 0;
            // 
            // tabPg1
            // 
            this.tabPg1.Controls.Add(this.tLayoutT1A);
            this.tabPg1.ImageKey = "icon_calculate.ico";
            this.tabPg1.Location = new System.Drawing.Point(4, 39);
            this.tabPg1.Name = "tabPg1";
            this.tabPg1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPg1.Size = new System.Drawing.Size(986, 486);
            this.tabPg1.TabIndex = 0;
            this.tabPg1.Text = "Calculator";
            this.tabPg1.UseVisualStyleBackColor = true;
            // 
            // tabPg2
            // 
            this.tabPg2.Controls.Add(this.tLayoutT2);
            this.tabPg2.ImageKey = "icon_settings.ico";
            this.tabPg2.Location = new System.Drawing.Point(4, 39);
            this.tabPg2.Name = "tabPg2";
            this.tabPg2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPg2.Size = new System.Drawing.Size(886, 536);
            this.tabPg2.TabIndex = 1;
            this.tabPg2.Text = "Preferences";
            this.tabPg2.UseVisualStyleBackColor = true;
            // 
            // tLayoutT2
            // 
            this.tLayoutT2.ColumnCount = 1;
            this.tLayoutT2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tLayoutT2.Controls.Add(this.mTabS1, 0, 0);
            this.tLayoutT2.Controls.Add(this.mTabC2, 0, 1);
            this.tLayoutT2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLayoutT2.Location = new System.Drawing.Point(3, 3);
            this.tLayoutT2.Name = "tLayoutT2";
            this.tLayoutT2.RowCount = 2;
            this.tLayoutT2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.73684F));
            this.tLayoutT2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.26316F));
            this.tLayoutT2.Size = new System.Drawing.Size(880, 530);
            this.tLayoutT2.TabIndex = 1;
            // 
            // mTabS1
            // 
            this.mTabS1.BaseTabControl = this.mTabC2;
            this.mTabS1.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.mTabS1.Depth = 0;
            this.mTabS1.Dock = System.Windows.Forms.DockStyle.Top;
            this.mTabS1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mTabS1.Location = new System.Drawing.Point(3, 3);
            this.mTabS1.MouseState = MaterialSkin.MouseState.HOVER;
            this.mTabS1.Name = "mTabS1";
            this.mTabS1.Size = new System.Drawing.Size(874, 48);
            this.mTabS1.TabIndex = 0;
            // 
            // mTabC2
            // 
            this.mTabC2.Controls.Add(this.tabPgT2A);
            this.mTabC2.Controls.Add(this.tabPgT2B);
            this.mTabC2.Controls.Add(this.tabPgT2C);
            this.mTabC2.Controls.Add(this.tabPgT2D);
            this.mTabC2.Depth = 0;
            this.mTabC2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mTabC2.Location = new System.Drawing.Point(3, 81);
            this.mTabC2.MouseState = MaterialSkin.MouseState.HOVER;
            this.mTabC2.Multiline = true;
            this.mTabC2.Name = "mTabC2";
            this.mTabC2.SelectedIndex = 0;
            this.mTabC2.Size = new System.Drawing.Size(874, 446);
            this.mTabC2.TabIndex = 1;
            // 
            // tabPgT2A
            // 
            this.tabPgT2A.Location = new System.Drawing.Point(4, 25);
            this.tabPgT2A.Name = "tabPgT2A";
            this.tabPgT2A.Padding = new System.Windows.Forms.Padding(3);
            this.tabPgT2A.Size = new System.Drawing.Size(766, 290);
            this.tabPgT2A.TabIndex = 0;
            this.tabPgT2A.Text = "General";
            this.tabPgT2A.UseVisualStyleBackColor = true;
            // 
            // tabPgT2B
            // 
            this.tabPgT2B.Location = new System.Drawing.Point(4, 25);
            this.tabPgT2B.Name = "tabPgT2B";
            this.tabPgT2B.Padding = new System.Windows.Forms.Padding(3);
            this.tabPgT2B.Size = new System.Drawing.Size(766, 290);
            this.tabPgT2B.TabIndex = 1;
            this.tabPgT2B.Text = "Appearances";
            this.tabPgT2B.UseVisualStyleBackColor = true;
            // 
            // tabPgT2C
            // 
            this.tabPgT2C.Controls.Add(this.mCardT2_StatusStrip);
            this.tabPgT2C.Location = new System.Drawing.Point(4, 25);
            this.tabPgT2C.Name = "tabPgT2C";
            this.tabPgT2C.Size = new System.Drawing.Size(866, 417);
            this.tabPgT2C.TabIndex = 2;
            this.tabPgT2C.Text = "Management";
            this.tabPgT2C.UseVisualStyleBackColor = true;
            // 
            // mCardT2_StatusStrip
            // 
            this.mCardT2_StatusStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mCardT2_StatusStrip.Controls.Add(this.fLayoutT1_1);
            this.mCardT2_StatusStrip.Depth = 0;
            this.mCardT2_StatusStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mCardT2_StatusStrip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mCardT2_StatusStrip.Location = new System.Drawing.Point(0, 387);
            this.mCardT2_StatusStrip.Margin = new System.Windows.Forms.Padding(14);
            this.mCardT2_StatusStrip.MouseState = MaterialSkin.MouseState.HOVER;
            this.mCardT2_StatusStrip.Name = "mCardT2_StatusStrip";
            this.mCardT2_StatusStrip.Padding = new System.Windows.Forms.Padding(14);
            this.mCardT2_StatusStrip.Size = new System.Drawing.Size(866, 30);
            this.mCardT2_StatusStrip.TabIndex = 2;
            // 
            // fLayoutT1_1
            // 
            this.fLayoutT1_1.BackColor = System.Drawing.Color.Transparent;
            this.fLayoutT1_1.Controls.Add(this.pbIcon_Proc);
            this.fLayoutT1_1.Controls.Add(this.mPB_Proc);
            this.fLayoutT1_1.Controls.Add(this.mDivT2_SS1);
            this.fLayoutT1_1.Controls.Add(this.pbIcon_Mem);
            this.fLayoutT1_1.Controls.Add(this.mPB_Mem);
            this.fLayoutT1_1.Controls.Add(this.mDivT2_SS2);
            this.fLayoutT1_1.Controls.Add(this.pbIcon_Batt);
            this.fLayoutT1_1.Controls.Add(this.mPB_Batt);
            this.fLayoutT1_1.Controls.Add(this.mDivT2_SS3);
            this.fLayoutT1_1.Controls.Add(this.pbIcon_DTemp);
            this.fLayoutT1_1.Controls.Add(this.mPB_DTemp);
            this.fLayoutT1_1.Location = new System.Drawing.Point(3, 2);
            this.fLayoutT1_1.Name = "fLayoutT1_1";
            this.fLayoutT1_1.Size = new System.Drawing.Size(860, 25);
            this.fLayoutT1_1.TabIndex = 3;
            // 
            // pbIcon_Proc
            // 
            this.pbIcon_Proc.Image = global::LifeSupportCalculator.Properties.Resources.icon_dt_memory;
            this.pbIcon_Proc.Location = new System.Drawing.Point(3, 3);
            this.pbIcon_Proc.Name = "pbIcon_Proc";
            this.pbIcon_Proc.Size = new System.Drawing.Size(20, 20);
            this.pbIcon_Proc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbIcon_Proc.TabIndex = 3;
            this.pbIcon_Proc.TabStop = false;
            // 
            // mPB_Proc
            // 
            this.mPB_Proc.Depth = 0;
            this.mPB_Proc.Location = new System.Drawing.Point(29, 10);
            this.mPB_Proc.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.mPB_Proc.MouseState = MaterialSkin.MouseState.HOVER;
            this.mPB_Proc.Name = "mPB_Proc";
            this.mPB_Proc.Size = new System.Drawing.Size(100, 5);
            this.mPB_Proc.TabIndex = 4;
            // 
            // mDivT2_SS1
            // 
            this.mDivT2_SS1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mDivT2_SS1.Depth = 0;
            this.mDivT2_SS1.Location = new System.Drawing.Point(135, 3);
            this.mDivT2_SS1.MouseState = MaterialSkin.MouseState.HOVER;
            this.mDivT2_SS1.Name = "mDivT2_SS1";
            this.mDivT2_SS1.Size = new System.Drawing.Size(10, 20);
            this.mDivT2_SS1.TabIndex = 5;
            // 
            // pbIcon_Mem
            // 
            this.pbIcon_Mem.Image = global::LifeSupportCalculator.Properties.Resources.icon_dt_memory_alt;
            this.pbIcon_Mem.Location = new System.Drawing.Point(151, 3);
            this.pbIcon_Mem.Name = "pbIcon_Mem";
            this.pbIcon_Mem.Size = new System.Drawing.Size(20, 20);
            this.pbIcon_Mem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbIcon_Mem.TabIndex = 3;
            this.pbIcon_Mem.TabStop = false;
            // 
            // mPB_Mem
            // 
            this.mPB_Mem.Depth = 0;
            this.mPB_Mem.Location = new System.Drawing.Point(177, 10);
            this.mPB_Mem.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.mPB_Mem.MouseState = MaterialSkin.MouseState.HOVER;
            this.mPB_Mem.Name = "mPB_Mem";
            this.mPB_Mem.Size = new System.Drawing.Size(100, 5);
            this.mPB_Mem.TabIndex = 5;
            // 
            // mDivT2_SS2
            // 
            this.mDivT2_SS2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mDivT2_SS2.Depth = 0;
            this.mDivT2_SS2.Location = new System.Drawing.Point(283, 3);
            this.mDivT2_SS2.MouseState = MaterialSkin.MouseState.HOVER;
            this.mDivT2_SS2.Name = "mDivT2_SS2";
            this.mDivT2_SS2.Size = new System.Drawing.Size(10, 20);
            this.mDivT2_SS2.TabIndex = 6;
            // 
            // pbIcon_Batt
            // 
            this.pbIcon_Batt.Image = global::LifeSupportCalculator.Properties.Resources.icon_dt_battery_full;
            this.pbIcon_Batt.Location = new System.Drawing.Point(299, 3);
            this.pbIcon_Batt.Name = "pbIcon_Batt";
            this.pbIcon_Batt.Size = new System.Drawing.Size(20, 20);
            this.pbIcon_Batt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbIcon_Batt.TabIndex = 3;
            this.pbIcon_Batt.TabStop = false;
            // 
            // mPB_Batt
            // 
            this.mPB_Batt.Depth = 0;
            this.mPB_Batt.Location = new System.Drawing.Point(325, 10);
            this.mPB_Batt.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.mPB_Batt.MouseState = MaterialSkin.MouseState.HOVER;
            this.mPB_Batt.Name = "mPB_Batt";
            this.mPB_Batt.Size = new System.Drawing.Size(100, 5);
            this.mPB_Batt.TabIndex = 6;
            // 
            // mDivT2_SS3
            // 
            this.mDivT2_SS3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mDivT2_SS3.Depth = 0;
            this.mDivT2_SS3.Location = new System.Drawing.Point(431, 3);
            this.mDivT2_SS3.MouseState = MaterialSkin.MouseState.HOVER;
            this.mDivT2_SS3.Name = "mDivT2_SS3";
            this.mDivT2_SS3.Size = new System.Drawing.Size(10, 20);
            this.mDivT2_SS3.TabIndex = 7;
            // 
            // pbIcon_DTemp
            // 
            this.pbIcon_DTemp.Image = global::LifeSupportCalculator.Properties.Resources.icon_dt_device_temperature;
            this.pbIcon_DTemp.Location = new System.Drawing.Point(447, 3);
            this.pbIcon_DTemp.Name = "pbIcon_DTemp";
            this.pbIcon_DTemp.Size = new System.Drawing.Size(20, 20);
            this.pbIcon_DTemp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbIcon_DTemp.TabIndex = 3;
            this.pbIcon_DTemp.TabStop = false;
            // 
            // mPB_DTemp
            // 
            this.mPB_DTemp.Depth = 0;
            this.mPB_DTemp.Location = new System.Drawing.Point(473, 10);
            this.mPB_DTemp.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.mPB_DTemp.MouseState = MaterialSkin.MouseState.HOVER;
            this.mPB_DTemp.Name = "mPB_DTemp";
            this.mPB_DTemp.Size = new System.Drawing.Size(100, 5);
            this.mPB_DTemp.TabIndex = 7;
            // 
            // tabPgT2D
            // 
            this.tabPgT2D.Location = new System.Drawing.Point(4, 25);
            this.tabPgT2D.Name = "tabPgT2D";
            this.tabPgT2D.Size = new System.Drawing.Size(766, 290);
            this.tabPgT2D.TabIndex = 3;
            this.tabPgT2D.Text = "Advanced";
            this.tabPgT2D.UseVisualStyleBackColor = true;
            // 
            // nIcon
            // 
            this.nIcon.ContextMenuStrip = this.ctxMS;
            this.nIcon.Text = "Life Support Calculator";
            this.nIcon.Visible = true;
            // 
            // pcTimer
            // 
            this.pcTimer.Interval = 1000;
            this.pcTimer.Tick += new System.EventHandler(this.pcTimer_Tick);
            // 
            // pcProc
            // 
            this.pcProc.CategoryName = "Processor";
            this.pcProc.CounterName = "% Processor Time";
            this.pcProc.InstanceName = "_Total";
            // 
            // pcMem
            // 
            this.pcMem.CategoryName = "Memory";
            this.pcMem.CounterName = "% Committed Bytes In Use";
            // 
            // tLayoutT1A
            // 
            this.tLayoutT1A.ColumnCount = 2;
            this.tLayoutT1A.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tLayoutT1A.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tLayoutT1A.Controls.Add(this.pT1A, 0, 0);
            this.tLayoutT1A.Controls.Add(this.tLayoutT1B, 1, 0);
            this.tLayoutT1A.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLayoutT1A.Location = new System.Drawing.Point(3, 3);
            this.tLayoutT1A.Name = "tLayoutT1A";
            this.tLayoutT1A.RowCount = 1;
            this.tLayoutT1A.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tLayoutT1A.Size = new System.Drawing.Size(980, 480);
            this.tLayoutT1A.TabIndex = 0;
            // 
            // ctxMS
            // 
            this.ctxMS.Font = new System.Drawing.Font("Noto Sans", 10.2F);
            this.ctxMS.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctxMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openApplicationToolStripMenuItem,
            this.toolStripSeparator1,
            this.manualToolStripMenuItem,
            this.preferencesToolStripMenuItem,
            this.toolStripSeparator3,
            this.closeApplicationToolStripMenuItem});
            this.ctxMS.Name = "ctxMS";
            this.ctxMS.Size = new System.Drawing.Size(253, 128);
            // 
            // openApplicationToolStripMenuItem
            // 
            this.openApplicationToolStripMenuItem.Name = "openApplicationToolStripMenuItem";
            this.openApplicationToolStripMenuItem.Size = new System.Drawing.Size(252, 28);
            this.openApplicationToolStripMenuItem.Text = "Open application";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(249, 6);
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openPreferenceTabToolStripMenuItem,
            this.toolStripSeparator2,
            this.checkUpdatesToolStripMenuItem,
            this.performanceCounterToolStripMenuItem});
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(252, 28);
            this.preferencesToolStripMenuItem.Text = "Preferences...";
            // 
            // openPreferenceTabToolStripMenuItem
            // 
            this.openPreferenceTabToolStripMenuItem.Name = "openPreferenceTabToolStripMenuItem";
            this.openPreferenceTabToolStripMenuItem.Size = new System.Drawing.Size(266, 28);
            this.openPreferenceTabToolStripMenuItem.Text = "Open preference tab";
            // 
            // checkUpdatesToolStripMenuItem
            // 
            this.checkUpdatesToolStripMenuItem.Name = "checkUpdatesToolStripMenuItem";
            this.checkUpdatesToolStripMenuItem.Size = new System.Drawing.Size(266, 28);
            this.checkUpdatesToolStripMenuItem.Text = "Check updates";
            // 
            // performanceCounterToolStripMenuItem
            // 
            this.performanceCounterToolStripMenuItem.Name = "performanceCounterToolStripMenuItem";
            this.performanceCounterToolStripMenuItem.Size = new System.Drawing.Size(266, 28);
            this.performanceCounterToolStripMenuItem.Text = "Performance counter";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(263, 6);
            // 
            // closeApplicationToolStripMenuItem
            // 
            this.closeApplicationToolStripMenuItem.Name = "closeApplicationToolStripMenuItem";
            this.closeApplicationToolStripMenuItem.Size = new System.Drawing.Size(252, 28);
            this.closeApplicationToolStripMenuItem.Text = "Shutdown application";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(249, 6);
            // 
            // manualToolStripMenuItem
            // 
            this.manualToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openOfflineManualToolStripMenuItem,
            this.onlineWikiToolStripMenuItem});
            this.manualToolStripMenuItem.Name = "manualToolStripMenuItem";
            this.manualToolStripMenuItem.Size = new System.Drawing.Size(252, 28);
            this.manualToolStripMenuItem.Text = "Help...";
            // 
            // openOfflineManualToolStripMenuItem
            // 
            this.openOfflineManualToolStripMenuItem.Name = "openOfflineManualToolStripMenuItem";
            this.openOfflineManualToolStripMenuItem.Size = new System.Drawing.Size(259, 28);
            this.openOfflineManualToolStripMenuItem.Text = "Open offline manual";
            // 
            // onlineWikiToolStripMenuItem
            // 
            this.onlineWikiToolStripMenuItem.Name = "onlineWikiToolStripMenuItem";
            this.onlineWikiToolStripMenuItem.Size = new System.Drawing.Size(259, 28);
            this.onlineWikiToolStripMenuItem.Text = "Open Online wiki";
            // 
            // pT1A
            // 
            this.pT1A.AutoScroll = true;
            this.pT1A.Controls.Add(this.materialCard1);
            this.pT1A.Controls.Add(this.mCard_InputForm2);
            this.pT1A.Controls.Add(this.mCard_InputForm1);
            this.pT1A.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pT1A.Location = new System.Drawing.Point(3, 3);
            this.pT1A.Name = "pT1A";
            this.pT1A.Size = new System.Drawing.Size(484, 474);
            this.pT1A.TabIndex = 0;
            // 
            // mCard_InputForm1
            // 
            this.mCard_InputForm1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mCard_InputForm1.Controls.Add(this.tLayout_InputForm1);
            this.mCard_InputForm1.Controls.Add(this.mLabel_Input1);
            this.mCard_InputForm1.Depth = 0;
            this.mCard_InputForm1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mCard_InputForm1.Location = new System.Drawing.Point(4, 8);
            this.mCard_InputForm1.Margin = new System.Windows.Forms.Padding(14);
            this.mCard_InputForm1.MouseState = MaterialSkin.MouseState.HOVER;
            this.mCard_InputForm1.Name = "mCard_InputForm1";
            this.mCard_InputForm1.Padding = new System.Windows.Forms.Padding(14);
            this.mCard_InputForm1.Size = new System.Drawing.Size(455, 200);
            this.mCard_InputForm1.TabIndex = 0;
            // 
            // mLabel_Input1
            // 
            this.mLabel_Input1.AutoSize = true;
            this.mLabel_Input1.Depth = 0;
            this.mLabel_Input1.Font = new System.Drawing.Font("Orbitron", 8F, System.Drawing.FontStyle.Bold);
            this.mLabel_Input1.Location = new System.Drawing.Point(17, 14);
            this.mLabel_Input1.MouseState = MaterialSkin.MouseState.HOVER;
            this.mLabel_Input1.Name = "mLabel_Input1";
            this.mLabel_Input1.Size = new System.Drawing.Size(219, 19);
            this.mLabel_Input1.TabIndex = 0;
            this.mLabel_Input1.Text = "LIFE SUPPORT SUPPLY INPUT";
            // 
            // tLayout_InputForm1
            // 
            this.tLayout_InputForm1.ColumnCount = 3;
            this.tLayout_InputForm1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tLayout_InputForm1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLayout_InputForm1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tLayout_InputForm1.Controls.Add(this.pbIcon_Oxygen1, 0, 2);
            this.tLayout_InputForm1.Controls.Add(this.pbIcon_Water1, 0, 1);
            this.tLayout_InputForm1.Controls.Add(this.pbIcon_Food1, 0, 0);
            this.tLayout_InputForm1.Controls.Add(this.mSlider_CurrentFood, 1, 0);
            this.tLayout_InputForm1.Controls.Add(this.mSlider_CurrentWater, 1, 1);
            this.tLayout_InputForm1.Controls.Add(this.mSlider_CurrentOxygen, 1, 2);
            this.tLayout_InputForm1.Controls.Add(this.mTB_MaxFood, 2, 0);
            this.tLayout_InputForm1.Controls.Add(this.mTB_MaxWater, 2, 1);
            this.tLayout_InputForm1.Controls.Add(this.mTB_MaxOxygen, 2, 2);
            this.tLayout_InputForm1.Location = new System.Drawing.Point(17, 36);
            this.tLayout_InputForm1.Name = "tLayout_InputForm1";
            this.tLayout_InputForm1.RowCount = 3;
            this.tLayout_InputForm1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tLayout_InputForm1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tLayout_InputForm1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tLayout_InputForm1.Size = new System.Drawing.Size(421, 150);
            this.tLayout_InputForm1.TabIndex = 1;
            // 
            // mCard_InputForm2
            // 
            this.mCard_InputForm2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mCard_InputForm2.Controls.Add(this.tableLayoutPanel1);
            this.mCard_InputForm2.Controls.Add(this.tLayout_InputForm2);
            this.mCard_InputForm2.Controls.Add(this.mLabel_Input2);
            this.mCard_InputForm2.Depth = 0;
            this.mCard_InputForm2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mCard_InputForm2.Location = new System.Drawing.Point(4, 211);
            this.mCard_InputForm2.Margin = new System.Windows.Forms.Padding(14);
            this.mCard_InputForm2.MouseState = MaterialSkin.MouseState.HOVER;
            this.mCard_InputForm2.Name = "mCard_InputForm2";
            this.mCard_InputForm2.Padding = new System.Windows.Forms.Padding(14);
            this.mCard_InputForm2.Size = new System.Drawing.Size(455, 150);
            this.mCard_InputForm2.TabIndex = 1;
            // 
            // mLabel_Input2
            // 
            this.mLabel_Input2.AutoSize = true;
            this.mLabel_Input2.Depth = 0;
            this.mLabel_Input2.Font = new System.Drawing.Font("Orbitron", 8F, System.Drawing.FontStyle.Bold);
            this.mLabel_Input2.Location = new System.Drawing.Point(17, 14);
            this.mLabel_Input2.MouseState = MaterialSkin.MouseState.HOVER;
            this.mLabel_Input2.Name = "mLabel_Input2";
            this.mLabel_Input2.Size = new System.Drawing.Size(153, 19);
            this.mLabel_Input2.TabIndex = 1;
            this.mLabel_Input2.Text = "TECH SUPPLY INPUT";
            // 
            // tLayout_InputForm2
            // 
            this.tLayout_InputForm2.ColumnCount = 3;
            this.tLayout_InputForm2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tLayout_InputForm2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLayout_InputForm2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tLayout_InputForm2.Controls.Add(this.pbIcon_Power1, 0, 0);
            this.tLayout_InputForm2.Controls.Add(this.mSlider_CurrentPower, 1, 0);
            this.tLayout_InputForm2.Controls.Add(this.mTB_MaxPower, 2, 0);
            this.tLayout_InputForm2.Location = new System.Drawing.Point(17, 36);
            this.tLayout_InputForm2.Name = "tLayout_InputForm2";
            this.tLayout_InputForm2.RowCount = 1;
            this.tLayout_InputForm2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tLayout_InputForm2.Size = new System.Drawing.Size(421, 50);
            this.tLayout_InputForm2.TabIndex = 2;
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.tLayout_InputForm4);
            this.materialCard1.Controls.Add(this.tLayout_InputForm3);
            this.materialCard1.Controls.Add(this.mLabel_Input3);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(4, 364);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(455, 150);
            this.materialCard1.TabIndex = 2;
            // 
            // mLabel_Input3
            // 
            this.mLabel_Input3.AutoSize = true;
            this.mLabel_Input3.Depth = 0;
            this.mLabel_Input3.Font = new System.Drawing.Font("Orbitron", 8F, System.Drawing.FontStyle.Bold);
            this.mLabel_Input3.Location = new System.Drawing.Point(17, 14);
            this.mLabel_Input3.MouseState = MaterialSkin.MouseState.HOVER;
            this.mLabel_Input3.Name = "mLabel_Input3";
            this.mLabel_Input3.Size = new System.Drawing.Size(160, 19);
            this.mLabel_Input3.TabIndex = 0;
            this.mLabel_Input3.Text = "ENVIRONMENT INPUT";
            // 
            // tLayout_InputForm3
            // 
            this.tLayout_InputForm3.ColumnCount = 4;
            this.tLayout_InputForm3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tLayout_InputForm3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tLayout_InputForm3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tLayout_InputForm3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLayout_InputForm3.Controls.Add(this.pbIcon_Temperature, 2, 0);
            this.tLayout_InputForm3.Controls.Add(this.pbIcon_Population, 0, 0);
            this.tLayout_InputForm3.Controls.Add(this.mTB_CurrentTemperature, 3, 0);
            this.tLayout_InputForm3.Controls.Add(this.mTB_Population, 1, 0);
            this.tLayout_InputForm3.Location = new System.Drawing.Point(17, 36);
            this.tLayout_InputForm3.Name = "tLayout_InputForm3";
            this.tLayout_InputForm3.RowCount = 1;
            this.tLayout_InputForm3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tLayout_InputForm3.Size = new System.Drawing.Size(421, 50);
            this.tLayout_InputForm3.TabIndex = 3;
            // 
            // mSlider_CurrentFood
            // 
            this.mSlider_CurrentFood.Depth = 0;
            this.mSlider_CurrentFood.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mSlider_CurrentFood.Location = new System.Drawing.Point(53, 3);
            this.mSlider_CurrentFood.MouseState = MaterialSkin.MouseState.HOVER;
            this.mSlider_CurrentFood.Name = "mSlider_CurrentFood";
            this.mSlider_CurrentFood.Size = new System.Drawing.Size(245, 40);
            this.mSlider_CurrentFood.TabIndex = 0;
            this.mSlider_CurrentFood.Text = "";
            this.mSlider_CurrentFood.ValueMax = 100;
            // 
            // mSlider_CurrentWater
            // 
            this.mSlider_CurrentWater.Depth = 0;
            this.mSlider_CurrentWater.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mSlider_CurrentWater.Location = new System.Drawing.Point(53, 53);
            this.mSlider_CurrentWater.MouseState = MaterialSkin.MouseState.HOVER;
            this.mSlider_CurrentWater.Name = "mSlider_CurrentWater";
            this.mSlider_CurrentWater.Size = new System.Drawing.Size(245, 40);
            this.mSlider_CurrentWater.TabIndex = 1;
            this.mSlider_CurrentWater.Text = "";
            this.mSlider_CurrentWater.ValueMax = 100;
            // 
            // mSlider_CurrentOxygen
            // 
            this.mSlider_CurrentOxygen.Depth = 0;
            this.mSlider_CurrentOxygen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mSlider_CurrentOxygen.Location = new System.Drawing.Point(53, 103);
            this.mSlider_CurrentOxygen.MouseState = MaterialSkin.MouseState.HOVER;
            this.mSlider_CurrentOxygen.Name = "mSlider_CurrentOxygen";
            this.mSlider_CurrentOxygen.Size = new System.Drawing.Size(245, 40);
            this.mSlider_CurrentOxygen.TabIndex = 2;
            this.mSlider_CurrentOxygen.Text = "";
            this.mSlider_CurrentOxygen.ValueMax = 100;
            // 
            // mTB_MaxFood
            // 
            this.mTB_MaxFood.AnimateReadOnly = false;
            this.mTB_MaxFood.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mTB_MaxFood.Depth = 0;
            this.mTB_MaxFood.Font = new System.Drawing.Font("Noto Sans", 10.2F);
            this.mTB_MaxFood.Hint = "1kg";
            this.mTB_MaxFood.LeadingIcon = null;
            this.mTB_MaxFood.Location = new System.Drawing.Point(304, 3);
            this.mTB_MaxFood.MaxLength = 9;
            this.mTB_MaxFood.MouseState = MaterialSkin.MouseState.OUT;
            this.mTB_MaxFood.Multiline = false;
            this.mTB_MaxFood.Name = "mTB_MaxFood";
            this.mTB_MaxFood.Size = new System.Drawing.Size(114, 50);
            this.mTB_MaxFood.TabIndex = 3;
            this.mTB_MaxFood.Text = "";
            this.mTB_MaxFood.TrailingIcon = null;
            // 
            // mTB_MaxWater
            // 
            this.mTB_MaxWater.AnimateReadOnly = false;
            this.mTB_MaxWater.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mTB_MaxWater.Depth = 0;
            this.mTB_MaxWater.Font = new System.Drawing.Font("Noto Sans", 10.2F);
            this.mTB_MaxWater.Hint = "2L";
            this.mTB_MaxWater.LeadingIcon = null;
            this.mTB_MaxWater.Location = new System.Drawing.Point(304, 53);
            this.mTB_MaxWater.MaxLength = 9;
            this.mTB_MaxWater.MouseState = MaterialSkin.MouseState.OUT;
            this.mTB_MaxWater.Multiline = false;
            this.mTB_MaxWater.Name = "mTB_MaxWater";
            this.mTB_MaxWater.Size = new System.Drawing.Size(114, 50);
            this.mTB_MaxWater.TabIndex = 4;
            this.mTB_MaxWater.Text = "";
            this.mTB_MaxWater.TrailingIcon = null;
            // 
            // mTB_MaxOxygen
            // 
            this.mTB_MaxOxygen.AnimateReadOnly = false;
            this.mTB_MaxOxygen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mTB_MaxOxygen.Depth = 0;
            this.mTB_MaxOxygen.Font = new System.Drawing.Font("Noto Sans", 10.2F);
            this.mTB_MaxOxygen.Hint = "24hr";
            this.mTB_MaxOxygen.LeadingIcon = null;
            this.mTB_MaxOxygen.Location = new System.Drawing.Point(304, 103);
            this.mTB_MaxOxygen.MaxLength = 9;
            this.mTB_MaxOxygen.MouseState = MaterialSkin.MouseState.OUT;
            this.mTB_MaxOxygen.Multiline = false;
            this.mTB_MaxOxygen.Name = "mTB_MaxOxygen";
            this.mTB_MaxOxygen.Size = new System.Drawing.Size(114, 50);
            this.mTB_MaxOxygen.TabIndex = 5;
            this.mTB_MaxOxygen.Text = "";
            this.mTB_MaxOxygen.TrailingIcon = null;
            // 
            // mSlider_CurrentPower
            // 
            this.mSlider_CurrentPower.Depth = 0;
            this.mSlider_CurrentPower.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mSlider_CurrentPower.Location = new System.Drawing.Point(53, 3);
            this.mSlider_CurrentPower.MouseState = MaterialSkin.MouseState.HOVER;
            this.mSlider_CurrentPower.Name = "mSlider_CurrentPower";
            this.mSlider_CurrentPower.Size = new System.Drawing.Size(246, 40);
            this.mSlider_CurrentPower.TabIndex = 1;
            this.mSlider_CurrentPower.Text = "";
            this.mSlider_CurrentPower.ValueMax = 100;
            // 
            // mTB_MaxPower
            // 
            this.mTB_MaxPower.AnimateReadOnly = false;
            this.mTB_MaxPower.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mTB_MaxPower.Depth = 0;
            this.mTB_MaxPower.Font = new System.Drawing.Font("Noto Sans", 10.2F);
            this.mTB_MaxPower.Hint = "100W";
            this.mTB_MaxPower.LeadingIcon = null;
            this.mTB_MaxPower.Location = new System.Drawing.Point(344, 3);
            this.mTB_MaxPower.MaxLength = 4;
            this.mTB_MaxPower.MouseState = MaterialSkin.MouseState.OUT;
            this.mTB_MaxPower.Multiline = false;
            this.mTB_MaxPower.Name = "mTB_MaxPower";
            this.mTB_MaxPower.Size = new System.Drawing.Size(74, 50);
            this.mTB_MaxPower.TabIndex = 6;
            this.mTB_MaxPower.Text = "";
            this.mTB_MaxPower.TrailingIcon = null;
            // 
            // pbIcon_Food1
            // 
            this.pbIcon_Food1.Location = new System.Drawing.Point(3, 3);
            this.pbIcon_Food1.Name = "pbIcon_Food1";
            this.pbIcon_Food1.Size = new System.Drawing.Size(44, 44);
            this.pbIcon_Food1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbIcon_Food1.TabIndex = 4;
            this.pbIcon_Food1.TabStop = false;
            // 
            // pbIcon_Water1
            // 
            this.pbIcon_Water1.Location = new System.Drawing.Point(3, 53);
            this.pbIcon_Water1.Name = "pbIcon_Water1";
            this.pbIcon_Water1.Size = new System.Drawing.Size(44, 44);
            this.pbIcon_Water1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbIcon_Water1.TabIndex = 6;
            this.pbIcon_Water1.TabStop = false;
            // 
            // pbIcon_Oxygen1
            // 
            this.pbIcon_Oxygen1.Location = new System.Drawing.Point(3, 103);
            this.pbIcon_Oxygen1.Name = "pbIcon_Oxygen1";
            this.pbIcon_Oxygen1.Size = new System.Drawing.Size(44, 44);
            this.pbIcon_Oxygen1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbIcon_Oxygen1.TabIndex = 7;
            this.pbIcon_Oxygen1.TabStop = false;
            // 
            // pbIcon_Power1
            // 
            this.pbIcon_Power1.Location = new System.Drawing.Point(3, 3);
            this.pbIcon_Power1.Name = "pbIcon_Power1";
            this.pbIcon_Power1.Size = new System.Drawing.Size(44, 44);
            this.pbIcon_Power1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbIcon_Power1.TabIndex = 7;
            this.pbIcon_Power1.TabStop = false;
            // 
            // mTB_Population
            // 
            this.mTB_Population.AnimateReadOnly = false;
            this.mTB_Population.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mTB_Population.Depth = 0;
            this.mTB_Population.Font = new System.Drawing.Font("Noto Sans", 10.2F);
            this.mTB_Population.Hint = "1";
            this.mTB_Population.LeadingIcon = null;
            this.mTB_Population.Location = new System.Drawing.Point(53, 3);
            this.mTB_Population.MaxLength = 5;
            this.mTB_Population.MouseState = MaterialSkin.MouseState.OUT;
            this.mTB_Population.Multiline = false;
            this.mTB_Population.Name = "mTB_Population";
            this.mTB_Population.Size = new System.Drawing.Size(94, 50);
            this.mTB_Population.TabIndex = 7;
            this.mTB_Population.Text = "";
            this.mTB_Population.TrailingIcon = null;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.mTB_PowerVoltage, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.mCB_PowerConsUnit, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.mCB_VoltageUnit, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.mTB_PowerConsumption, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.mCB_WattUnit, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(17, 86);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(421, 50);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // mTB_PowerVoltage
            // 
            this.mTB_PowerVoltage.AnimateReadOnly = false;
            this.mTB_PowerVoltage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mTB_PowerVoltage.Depth = 0;
            this.mTB_PowerVoltage.Font = new System.Drawing.Font("Noto Sans", 10.2F);
            this.mTB_PowerVoltage.Hint = "250V";
            this.mTB_PowerVoltage.LeadingIcon = null;
            this.mTB_PowerVoltage.Location = new System.Drawing.Point(83, 3);
            this.mTB_PowerVoltage.MaxLength = 4;
            this.mTB_PowerVoltage.MouseState = MaterialSkin.MouseState.OUT;
            this.mTB_PowerVoltage.Multiline = false;
            this.mTB_PowerVoltage.Name = "mTB_PowerVoltage";
            this.mTB_PowerVoltage.Size = new System.Drawing.Size(74, 50);
            this.mTB_PowerVoltage.TabIndex = 7;
            this.mTB_PowerVoltage.Text = "";
            this.mTB_PowerVoltage.TrailingIcon = null;
            // 
            // mTB_PowerConsumption
            // 
            this.mTB_PowerConsumption.AnimateReadOnly = false;
            this.mTB_PowerConsumption.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mTB_PowerConsumption.Depth = 0;
            this.mTB_PowerConsumption.Font = new System.Drawing.Font("Noto Sans", 10.2F);
            this.mTB_PowerConsumption.Hint = "n Wh";
            this.mTB_PowerConsumption.LeadingIcon = null;
            this.mTB_PowerConsumption.Location = new System.Drawing.Point(343, 3);
            this.mTB_PowerConsumption.MaxLength = 4;
            this.mTB_PowerConsumption.MouseState = MaterialSkin.MouseState.OUT;
            this.mTB_PowerConsumption.Multiline = false;
            this.mTB_PowerConsumption.Name = "mTB_PowerConsumption";
            this.mTB_PowerConsumption.Size = new System.Drawing.Size(75, 50);
            this.mTB_PowerConsumption.TabIndex = 8;
            this.mTB_PowerConsumption.Text = "";
            this.mTB_PowerConsumption.TrailingIcon = null;
            // 
            // mCB_VoltageUnit
            // 
            this.mCB_VoltageUnit.AutoResize = false;
            this.mCB_VoltageUnit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mCB_VoltageUnit.Depth = 0;
            this.mCB_VoltageUnit.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.mCB_VoltageUnit.DropDownHeight = 174;
            this.mCB_VoltageUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mCB_VoltageUnit.DropDownWidth = 121;
            this.mCB_VoltageUnit.Font = new System.Drawing.Font("Noto Sans", 10.2F);
            this.mCB_VoltageUnit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mCB_VoltageUnit.FormattingEnabled = true;
            this.mCB_VoltageUnit.IntegralHeight = false;
            this.mCB_VoltageUnit.ItemHeight = 43;
            this.mCB_VoltageUnit.Items.AddRange(new object[] {
            "V",
            "kV",
            "MV",
            "GV",
            "TV"});
            this.mCB_VoltageUnit.Location = new System.Drawing.Point(3, 3);
            this.mCB_VoltageUnit.MaxDropDownItems = 4;
            this.mCB_VoltageUnit.MouseState = MaterialSkin.MouseState.OUT;
            this.mCB_VoltageUnit.Name = "mCB_VoltageUnit";
            this.mCB_VoltageUnit.Size = new System.Drawing.Size(74, 49);
            this.mCB_VoltageUnit.StartIndex = 0;
            this.mCB_VoltageUnit.TabIndex = 9;
            // 
            // mCB_PowerConsUnit
            // 
            this.mCB_PowerConsUnit.AutoResize = false;
            this.mCB_PowerConsUnit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mCB_PowerConsUnit.Depth = 0;
            this.mCB_PowerConsUnit.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.mCB_PowerConsUnit.DropDownHeight = 174;
            this.mCB_PowerConsUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mCB_PowerConsUnit.DropDownWidth = 121;
            this.mCB_PowerConsUnit.Font = new System.Drawing.Font("Noto Sans", 10.2F);
            this.mCB_PowerConsUnit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mCB_PowerConsUnit.FormattingEnabled = true;
            this.mCB_PowerConsUnit.IntegralHeight = false;
            this.mCB_PowerConsUnit.ItemHeight = 43;
            this.mCB_PowerConsUnit.Items.AddRange(new object[] {
            "Wh",
            "kWh",
            "MWh",
            "GWh",
            "TWh"});
            this.mCB_PowerConsUnit.Location = new System.Drawing.Point(243, 3);
            this.mCB_PowerConsUnit.MaxDropDownItems = 4;
            this.mCB_PowerConsUnit.MouseState = MaterialSkin.MouseState.OUT;
            this.mCB_PowerConsUnit.Name = "mCB_PowerConsUnit";
            this.mCB_PowerConsUnit.Size = new System.Drawing.Size(94, 49);
            this.mCB_PowerConsUnit.StartIndex = 0;
            this.mCB_PowerConsUnit.TabIndex = 10;
            // 
            // mCB_WattUnit
            // 
            this.mCB_WattUnit.AutoResize = false;
            this.mCB_WattUnit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mCB_WattUnit.Depth = 0;
            this.mCB_WattUnit.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.mCB_WattUnit.DropDownHeight = 174;
            this.mCB_WattUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mCB_WattUnit.DropDownWidth = 121;
            this.mCB_WattUnit.Font = new System.Drawing.Font("Noto Sans", 10.2F);
            this.mCB_WattUnit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mCB_WattUnit.FormattingEnabled = true;
            this.mCB_WattUnit.IntegralHeight = false;
            this.mCB_WattUnit.ItemHeight = 43;
            this.mCB_WattUnit.Items.AddRange(new object[] {
            "W",
            "kW",
            "MW",
            "GW",
            "TW"});
            this.mCB_WattUnit.Location = new System.Drawing.Point(163, 3);
            this.mCB_WattUnit.MaxDropDownItems = 4;
            this.mCB_WattUnit.MouseState = MaterialSkin.MouseState.OUT;
            this.mCB_WattUnit.Name = "mCB_WattUnit";
            this.mCB_WattUnit.Size = new System.Drawing.Size(74, 49);
            this.mCB_WattUnit.StartIndex = 0;
            this.mCB_WattUnit.TabIndex = 11;
            // 
            // pbIcon_Population
            // 
            this.pbIcon_Population.Location = new System.Drawing.Point(3, 3);
            this.pbIcon_Population.Name = "pbIcon_Population";
            this.pbIcon_Population.Size = new System.Drawing.Size(44, 44);
            this.pbIcon_Population.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbIcon_Population.TabIndex = 9;
            this.pbIcon_Population.TabStop = false;
            // 
            // pbIcon_Temperature
            // 
            this.pbIcon_Temperature.Location = new System.Drawing.Point(153, 3);
            this.pbIcon_Temperature.Name = "pbIcon_Temperature";
            this.pbIcon_Temperature.Size = new System.Drawing.Size(44, 44);
            this.pbIcon_Temperature.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbIcon_Temperature.TabIndex = 10;
            this.pbIcon_Temperature.TabStop = false;
            // 
            // mTB_CurrentTemperature
            // 
            this.mTB_CurrentTemperature.AnimateReadOnly = false;
            this.mTB_CurrentTemperature.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mTB_CurrentTemperature.Depth = 0;
            this.mTB_CurrentTemperature.Font = new System.Drawing.Font("Noto Sans", 10.2F);
            this.mTB_CurrentTemperature.Hint = "24℃";
            this.mTB_CurrentTemperature.LeadingIcon = null;
            this.mTB_CurrentTemperature.Location = new System.Drawing.Point(203, 3);
            this.mTB_CurrentTemperature.MaxLength = 4;
            this.mTB_CurrentTemperature.MouseState = MaterialSkin.MouseState.OUT;
            this.mTB_CurrentTemperature.Multiline = false;
            this.mTB_CurrentTemperature.Name = "mTB_CurrentTemperature";
            this.mTB_CurrentTemperature.Size = new System.Drawing.Size(215, 50);
            this.mTB_CurrentTemperature.TabIndex = 8;
            this.mTB_CurrentTemperature.Text = "";
            this.mTB_CurrentTemperature.TrailingIcon = null;
            // 
            // tLayout_InputForm4
            // 
            this.tLayout_InputForm4.ColumnCount = 3;
            this.tLayout_InputForm4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tLayout_InputForm4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tLayout_InputForm4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tLayout_InputForm4.Controls.Add(this.pbIcon_Time, 0, 0);
            this.tLayout_InputForm4.Controls.Add(this.mTB_TargetHoldingTime, 1, 0);
            this.tLayout_InputForm4.Controls.Add(this.mTB_SpareControl1, 2, 0);
            this.tLayout_InputForm4.Location = new System.Drawing.Point(17, 86);
            this.tLayout_InputForm4.Name = "tLayout_InputForm4";
            this.tLayout_InputForm4.RowCount = 1;
            this.tLayout_InputForm4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tLayout_InputForm4.Size = new System.Drawing.Size(421, 50);
            this.tLayout_InputForm4.TabIndex = 4;
            // 
            // pbIcon_Time
            // 
            this.pbIcon_Time.Location = new System.Drawing.Point(3, 3);
            this.pbIcon_Time.Name = "pbIcon_Time";
            this.pbIcon_Time.Size = new System.Drawing.Size(44, 44);
            this.pbIcon_Time.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbIcon_Time.TabIndex = 11;
            this.pbIcon_Time.TabStop = false;
            // 
            // mTB_TargetHoldingTime
            // 
            this.mTB_TargetHoldingTime.AnimateReadOnly = false;
            this.mTB_TargetHoldingTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mTB_TargetHoldingTime.Depth = 0;
            this.mTB_TargetHoldingTime.Font = new System.Drawing.Font("Noto Sans", 10.2F);
            this.mTB_TargetHoldingTime.Hint = "yyyyyyy:MM:dd:hh";
            this.mTB_TargetHoldingTime.LeadingIcon = null;
            this.mTB_TargetHoldingTime.Location = new System.Drawing.Point(53, 3);
            this.mTB_TargetHoldingTime.MaxLength = 17;
            this.mTB_TargetHoldingTime.MouseState = MaterialSkin.MouseState.OUT;
            this.mTB_TargetHoldingTime.Multiline = false;
            this.mTB_TargetHoldingTime.Name = "mTB_TargetHoldingTime";
            this.mTB_TargetHoldingTime.Size = new System.Drawing.Size(179, 50);
            this.mTB_TargetHoldingTime.TabIndex = 12;
            this.mTB_TargetHoldingTime.Text = "";
            this.mTB_TargetHoldingTime.TrailingIcon = null;
            // 
            // mTB_SpareControl1
            // 
            this.mTB_SpareControl1.AnimateReadOnly = false;
            this.mTB_SpareControl1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mTB_SpareControl1.Depth = 0;
            this.mTB_SpareControl1.Enabled = false;
            this.mTB_SpareControl1.Font = new System.Drawing.Font("Noto Sans", 10.2F);
            this.mTB_SpareControl1.LeadingIcon = null;
            this.mTB_SpareControl1.Location = new System.Drawing.Point(238, 3);
            this.mTB_SpareControl1.MaxLength = 20;
            this.mTB_SpareControl1.MouseState = MaterialSkin.MouseState.OUT;
            this.mTB_SpareControl1.Multiline = false;
            this.mTB_SpareControl1.Name = "mTB_SpareControl1";
            this.mTB_SpareControl1.Size = new System.Drawing.Size(180, 50);
            this.mTB_SpareControl1.TabIndex = 13;
            this.mTB_SpareControl1.Text = "Created by APUcard";
            this.mTB_SpareControl1.TrailingIcon = null;
            // 
            // tLayoutT1B
            // 
            this.tLayoutT1B.ColumnCount = 1;
            this.tLayoutT1B.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLayoutT1B.Controls.Add(this.fLayoutT1, 0, 1);
            this.tLayoutT1B.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLayoutT1B.Location = new System.Drawing.Point(493, 3);
            this.tLayoutT1B.Name = "tLayoutT1B";
            this.tLayoutT1B.RowCount = 2;
            this.tLayoutT1B.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLayoutT1B.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tLayoutT1B.Size = new System.Drawing.Size(484, 474);
            this.tLayoutT1B.TabIndex = 1;
            // 
            // mBtn_Calculate
            // 
            this.mBtn_Calculate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mBtn_Calculate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.mBtn_Calculate.Depth = 0;
            this.mBtn_Calculate.HighEmphasis = true;
            this.mBtn_Calculate.Icon = null;
            this.mBtn_Calculate.Location = new System.Drawing.Point(4, 6);
            this.mBtn_Calculate.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mBtn_Calculate.MouseState = MaterialSkin.MouseState.HOVER;
            this.mBtn_Calculate.Name = "mBtn_Calculate";
            this.mBtn_Calculate.NoAccentTextColor = System.Drawing.Color.Empty;
            this.mBtn_Calculate.Size = new System.Drawing.Size(105, 36);
            this.mBtn_Calculate.TabIndex = 2;
            this.mBtn_Calculate.Text = "Calculate!";
            this.mBtn_Calculate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mBtn_Calculate.UseAccentColor = false;
            this.mBtn_Calculate.UseVisualStyleBackColor = true;
            // 
            // fLayoutT1
            // 
            this.fLayoutT1.Controls.Add(this.mBtn_Calculate);
            this.fLayoutT1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fLayoutT1.Location = new System.Drawing.Point(3, 427);
            this.fLayoutT1.Name = "fLayoutT1";
            this.fLayoutT1.Size = new System.Drawing.Size(478, 44);
            this.fLayoutT1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.mTabC1);
            this.DrawerBackgroundWithAccent = true;
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.mTabC1;
            this.DrawerUseColors = true;
            this.Font = new System.Drawing.Font("Orbitron", 8F);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(3, 68, 3, 3);
            this.Sizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Life Support Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mTabC1.ResumeLayout(false);
            this.tabPg1.ResumeLayout(false);
            this.tabPg2.ResumeLayout(false);
            this.tLayoutT2.ResumeLayout(false);
            this.mTabC2.ResumeLayout(false);
            this.tabPgT2C.ResumeLayout(false);
            this.mCardT2_StatusStrip.ResumeLayout(false);
            this.fLayoutT1_1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon_Proc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon_Mem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon_Batt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon_DTemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcProc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcMem)).EndInit();
            this.tLayoutT1A.ResumeLayout(false);
            this.ctxMS.ResumeLayout(false);
            this.pT1A.ResumeLayout(false);
            this.mCard_InputForm1.ResumeLayout(false);
            this.mCard_InputForm1.PerformLayout();
            this.tLayout_InputForm1.ResumeLayout(false);
            this.mCard_InputForm2.ResumeLayout(false);
            this.mCard_InputForm2.PerformLayout();
            this.tLayout_InputForm2.ResumeLayout(false);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.tLayout_InputForm3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon_Food1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon_Water1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon_Oxygen1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon_Power1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon_Population)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon_Temperature)).EndInit();
            this.tLayout_InputForm4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon_Time)).EndInit();
            this.tLayoutT1B.ResumeLayout(false);
            this.fLayoutT1.ResumeLayout(false);
            this.fLayoutT1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imgList;
        private MaterialSkin.Controls.MaterialTabControl mTabC1;
        private System.Windows.Forms.TabPage tabPg1;
        private System.Windows.Forms.TabPage tabPg2;
        private System.Windows.Forms.TableLayoutPanel tLayoutT2;
        private MaterialSkin.Controls.MaterialTabSelector mTabS1;
        private MaterialSkin.Controls.MaterialTabControl mTabC2;
        private System.Windows.Forms.TabPage tabPgT2A;
        private System.Windows.Forms.TabPage tabPgT2B;
        private System.Windows.Forms.TabPage tabPgT2C;
        private System.Windows.Forms.TabPage tabPgT2D;
        private System.Windows.Forms.NotifyIcon nIcon;
        private MaterialSkin.Controls.MaterialCard mCardT2_StatusStrip;
        private System.Windows.Forms.FlowLayoutPanel fLayoutT1_1;
        private System.Windows.Forms.PictureBox pbIcon_Proc;
        private MaterialSkin.Controls.MaterialProgressBar mPB_Proc;
        private MaterialSkin.Controls.MaterialDivider mDivT2_SS1;
        private System.Windows.Forms.PictureBox pbIcon_Mem;
        private System.Windows.Forms.PictureBox pbIcon_Batt;
        private MaterialSkin.Controls.MaterialProgressBar mPB_Mem;
        private MaterialSkin.Controls.MaterialDivider mDivT2_SS2;
        private System.Windows.Forms.PictureBox pbIcon_DTemp;
        private MaterialSkin.Controls.MaterialProgressBar mPB_Batt;
        private MaterialSkin.Controls.MaterialDivider mDivT2_SS3;
        private MaterialSkin.Controls.MaterialProgressBar mPB_DTemp;
        private System.Windows.Forms.Timer pcTimer;
        private System.Diagnostics.PerformanceCounter pcProc;
        private System.Diagnostics.PerformanceCounter pcMem;
        private System.Windows.Forms.TableLayoutPanel tLayoutT1A;
        private System.Windows.Forms.ContextMenuStrip ctxMS;
        private System.Windows.Forms.ToolStripMenuItem openApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem manualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openOfflineManualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onlineWikiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openPreferenceTabToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem checkUpdatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem performanceCounterToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem closeApplicationToolStripMenuItem;
        private System.Windows.Forms.Panel pT1A;
        private MaterialSkin.Controls.MaterialCard mCard_InputForm1;
        private MaterialSkin.Controls.MaterialLabel mLabel_Input1;
        private System.Windows.Forms.TableLayoutPanel tLayout_InputForm1;
        private MaterialSkin.Controls.MaterialCard mCard_InputForm2;
        private System.Windows.Forms.TableLayoutPanel tLayout_InputForm2;
        private MaterialSkin.Controls.MaterialLabel mLabel_Input2;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private System.Windows.Forms.TableLayoutPanel tLayout_InputForm3;
        private MaterialSkin.Controls.MaterialLabel mLabel_Input3;
        private MaterialSkin.Controls.MaterialSlider mSlider_CurrentFood;
        private MaterialSkin.Controls.MaterialSlider mSlider_CurrentWater;
        private MaterialSkin.Controls.MaterialSlider mSlider_CurrentOxygen;
        private MaterialSkin.Controls.MaterialTextBox mTB_MaxFood;
        private MaterialSkin.Controls.MaterialTextBox mTB_MaxWater;
        private MaterialSkin.Controls.MaterialTextBox mTB_MaxOxygen;
        private MaterialSkin.Controls.MaterialSlider mSlider_CurrentPower;
        private MaterialSkin.Controls.MaterialTextBox mTB_MaxPower;
        private System.Windows.Forms.PictureBox pbIcon_Power1;
        private System.Windows.Forms.PictureBox pbIcon_Oxygen1;
        private System.Windows.Forms.PictureBox pbIcon_Water1;
        private System.Windows.Forms.PictureBox pbIcon_Food1;
        private MaterialSkin.Controls.MaterialTextBox mTB_Population;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MaterialSkin.Controls.MaterialTextBox mTB_PowerVoltage;
        private MaterialSkin.Controls.MaterialComboBox mCB_PowerConsUnit;
        private MaterialSkin.Controls.MaterialComboBox mCB_VoltageUnit;
        private MaterialSkin.Controls.MaterialTextBox mTB_PowerConsumption;
        private MaterialSkin.Controls.MaterialComboBox mCB_WattUnit;
        private System.Windows.Forms.PictureBox pbIcon_Temperature;
        private System.Windows.Forms.PictureBox pbIcon_Population;
        private MaterialSkin.Controls.MaterialTextBox mTB_CurrentTemperature;
        private System.Windows.Forms.TableLayoutPanel tLayout_InputForm4;
        private System.Windows.Forms.PictureBox pbIcon_Time;
        private MaterialSkin.Controls.MaterialTextBox mTB_TargetHoldingTime;
        private MaterialSkin.Controls.MaterialTextBox mTB_SpareControl1;
        private System.Windows.Forms.TableLayoutPanel tLayoutT1B;
        private System.Windows.Forms.FlowLayoutPanel fLayoutT1;
        private MaterialSkin.Controls.MaterialButton mBtn_Calculate;
    }
}

