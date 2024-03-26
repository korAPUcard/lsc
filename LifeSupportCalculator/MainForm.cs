using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Reflection.Emit;
using System.Text;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace LifeSupportCalculator
{
    public partial class MainForm : MaterialForm
    {
        MaterialSkinManager matSkinManager = MaterialSkinManager.Instance;

        //DialogResult appRestartConfirmator;
        //DialogResult appCloseConfirmator;

        //bool isAppRestartConfirmatorEnabled = false;

        public MainForm()
        {
            InitializeComponent();

            this.Icon = Properties.Resources.AppIcon;
            this.Font = new Font(FontLibrary.Families[0], 12);

            matCd1.HorizontalScroll.Enabled = false;
            matCd1.HorizontalScroll.Visible = false;
            matCd2.HorizontalScroll.Enabled = false;
            matCd2.HorizontalScroll.Visible = false;
            

            Properties.Settings.Default.Language = "en-US";
            Properties.Settings.Default.Theme = "Dark";
            Properties.Settings.Default.Save();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Theme == "Dark")
            {
                matSkinManager.AddFormToManage(this);
                matSkinManager.EnforceBackcolorOnAllComponents = true;
                matSkinManager.Theme = MaterialSkinManager.Themes.DARK;
                matSkinManager.ColorScheme = new ColorScheme(
                    Primary.LightBlue800,
                    Primary.LightBlue900,
                    Primary.LightBlue500,
                    Accent.Cyan200,
                    TextShade.WHITE
                ); IconTheme_Dark();
            }
            else
            {
                matSkinManager.AddFormToManage(this);
                matSkinManager.EnforceBackcolorOnAllComponents = true;
                matSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
                matSkinManager.ColorScheme = new ColorScheme(
                    Primary.LightBlue800,
                    Primary.LightBlue900,
                    Primary.LightBlue500,
                    Accent.Cyan200,
                    TextShade.BLACK
                ); IconTheme_Light();
            }
        }

        private void IconTheme_Light()
        {
            iconLbl1.ImageList = iconList_LT24;
            iconLbl2.ImageList = iconList_LT24;
            iconLbl3.ImageList = iconList_LT24;
            iconLbl4.ImageList = iconList_LT24;
            iconLbl5.ImageList = iconList_LT24;
            iconLbl6.ImageList = iconList_LT24;
            iconLbl7.ImageList = iconList_LT24;
            iconLbl8.ImageList = iconList_LT24;
            iconLbl9.ImageList = iconList_LT24;
            iconLbl10.ImageList = iconList_LT24;

            iconLblH1.ImageList = iconList_LT42;
            iconLblH2.ImageList = iconList_LT42;
            iconLblH3.ImageList = iconList_LT42;
        }

        private void IconTheme_Dark()
        {
            iconLbl1.ImageList = iconList_DT24;
            iconLbl2.ImageList = iconList_DT24;
            iconLbl3.ImageList = iconList_DT24;
            iconLbl4.ImageList = iconList_DT24;
            iconLbl5.ImageList = iconList_DT24;
            iconLbl6.ImageList = iconList_DT24;
            iconLbl7.ImageList = iconList_DT24;
            iconLbl8.ImageList = iconList_DT24;
            iconLbl9.ImageList = iconList_DT24;
            iconLbl10.ImageList = iconList_DT24;

            iconLblH1.ImageList = iconList_DT42;
            iconLblH2.ImageList = iconList_DT42;
            iconLblH3.ImageList = iconList_DT42;
        }

        private void TSMI_App_Diagnostics_Click(object sender, EventArgs e)
        {
            
        }

        private void TSMI_App_CheckUpdates_Click(object sender, EventArgs e)
        {

        }

        private void TSMI_App_AppPref_Click(object sender, EventArgs e)
        {

        }

        private void TSMI_App_AppRestart_Click(object sender, EventArgs e)
        {

        }

        private void TSMI_App_AppClose_Click(object sender, EventArgs e)
        {

        }

        private void TSMI_View_Visuals_Simple_Click(object sender, EventArgs e)
        {

        }

        private void TSMI_View_Visuals_Detail_Click(object sender, EventArgs e)
        {

        }

        private void TSMI_Help_About_Click(object sender, EventArgs e)
        {

        }

        private void TSMI_Help_Homepage_Click(object sender, EventArgs e)
        {

        }

        private void TSMI_Help_GitRepo_Click(object sender, EventArgs e)
        {

        }

        private void lbl1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawString("Consumption", new Font("Noto Sans", 14, FontStyle.Bold), new SolidBrush(Color.White), new Point(0, 0));
        }

        private void lbl2_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawString("Supplies", new Font("Noto Sans", 14, FontStyle.Bold), new SolidBrush(Color.White), new Point(0, 0));
        }
    }
}
