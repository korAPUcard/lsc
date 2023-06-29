using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LifeSupportCalculator
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
            
            this.Icon = Properties.Resources.AppIcon;
            nIcon.Icon = Properties.Resources.AppIcon;

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.LightBlue800,
                Primary.LightBlue900,
                Primary.LightBlue500,
                Accent.Cyan200,
                TextShade.WHITE
            );
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pcTimer.Start();
            mPB_Proc.ForeColor = Color.Cyan;
            mPB_Mem.ForeColor = Color.Cyan;
        }

        private void pcTimer_Tick(object sender, EventArgs e)
        {
            mPB_Proc.Value = (int)pcProc.NextValue();
            mPB_Mem.Value = (int)pcMem.NextValue();
        }
    }
}
