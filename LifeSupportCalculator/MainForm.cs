
namespace LifeSupportCalculator
{
    public partial class MainForm : MaterialForm
    {
        //DialogResult appRestartConfirmator;
        //DialogResult appCloseConfirmator;

        //bool isAppRestartConfirmatorEnabled = false;

        public MainForm()
        {
            InitializeComponent();

            this.Icon = Properties.Resources.AppIcon;

            Properties.Settings.Default.Language = "en-US";
            Properties.Settings.Default.Theme = "Dark";
            Properties.Settings.Default.Save();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            MaterialSkinManager matSkinManager = MaterialSkinManager.Instance;

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
                );
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
                );
            }
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
    }
}
