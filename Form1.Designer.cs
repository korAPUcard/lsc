
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
            this.mTabC1.SuspendLayout();
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
            this.tabPg1.Text = "tabPage1";
            this.tabPg1.UseVisualStyleBackColor = true;
            // 
            // tabPg2
            // 
            this.tabPg2.ImageKey = "icon_settings.ico";
            this.tabPg2.Location = new System.Drawing.Point(4, 39);
            this.tabPg2.Name = "tabPg2";
            this.tabPg2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPg2.Size = new System.Drawing.Size(786, 386);
            this.tabPg2.TabIndex = 1;
            this.tabPg2.Text = "tabPage2";
            this.tabPg2.UseVisualStyleBackColor = true;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imgList;
        private MaterialSkin.Controls.MaterialTabControl mTabC1;
        private System.Windows.Forms.TabPage tabPg1;
        private System.Windows.Forms.TabPage tabPg2;
    }
}

