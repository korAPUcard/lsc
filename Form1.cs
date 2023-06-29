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
        int _battCap = (int)SystemInformation.PowerStatus.BatteryLifePercent;

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

            pT1A.AutoScroll = false;
            pT1A.HorizontalScroll.Enabled = false;
            pT1A.HorizontalScroll.Visible = false;
            pT1A.HorizontalScroll.Maximum = 0;
            pT1A.AutoScroll = true;
        }

        private void pcTimer_Tick(object sender, EventArgs e)
        {
            mPB_Proc.Value = (int)pcProc.NextValue();
            mPB_Mem.Value = (int)pcMem.NextValue();
            if(!SystemInformation.PowerStatus.BatteryChargeStatus.HasFlag(BatteryChargeStatus.NoSystemBattery))
            {
                mPB_Batt.Value = 0;
            }
            else if(!SystemInformation.PowerStatus.BatteryChargeStatus.HasFlag(BatteryChargeStatus.Unknown))
            {
                mPB_Batt.Value = 100;
            }
            else
            {
                mPB_Batt.Value = _battCap;
            }

            if(!SystemInformation.PowerStatus.BatteryChargeStatus.HasFlag(BatteryChargeStatus.Charging))
            {
                pbIcon_Batt.Image = Properties.Resources.icon_dt_battery_charging_full;
            }
            else if(!SystemInformation.PowerStatus.BatteryChargeStatus.HasFlag(BatteryChargeStatus.Critical))
            {
                pbIcon_Batt.Image = Properties.Resources.icon_dt_battery_alert;
            }
            else if(!SystemInformation.PowerStatus.BatteryChargeStatus.HasFlag(BatteryChargeStatus.Unknown))
            {
                pbIcon_Batt.Image = Properties.Resources.icon_dt_battery_unknown;
            }
            else
            {
                pbIcon_Batt.Image = Properties.Resources.icon_dt_battery_full;
            }
        }
    }
}
