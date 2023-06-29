
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
            this.mTabC1.SuspendLayout();
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
            this.mTabC1.Size = new System.Drawing.Size(794, 429);
            this.mTabC1.TabIndex = 0;
            // 
            // tabPg1
            // 
            this.tabPg1.ImageKey = "icon_calculate.ico";
            this.tabPg1.Location = new System.Drawing.Point(4, 39);
            this.tabPg1.Name = "tabPg1";
            this.tabPg1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPg1.Size = new System.Drawing.Size(786, 386);
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
            this.tabPg2.Size = new System.Drawing.Size(786, 386);
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
            this.tLayoutT2.Size = new System.Drawing.Size(780, 380);
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
            this.mTabS1.Size = new System.Drawing.Size(774, 48);
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
            this.mTabC2.Location = new System.Drawing.Point(3, 58);
            this.mTabC2.MouseState = MaterialSkin.MouseState.HOVER;
            this.mTabC2.Multiline = true;
            this.mTabC2.Name = "mTabC2";
            this.mTabC2.SelectedIndex = 0;
            this.mTabC2.Size = new System.Drawing.Size(774, 319);
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
            this.tabPgT2C.Size = new System.Drawing.Size(766, 290);
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
            this.mCardT2_StatusStrip.Location = new System.Drawing.Point(0, 260);
            this.mCardT2_StatusStrip.Margin = new System.Windows.Forms.Padding(14);
            this.mCardT2_StatusStrip.MouseState = MaterialSkin.MouseState.HOVER;
            this.mCardT2_StatusStrip.Name = "mCardT2_StatusStrip";
            this.mCardT2_StatusStrip.Padding = new System.Windows.Forms.Padding(14);
            this.mCardT2_StatusStrip.Size = new System.Drawing.Size(766, 30);
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
            this.fLayoutT1_1.Size = new System.Drawing.Size(774, 25);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
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
    }
}

