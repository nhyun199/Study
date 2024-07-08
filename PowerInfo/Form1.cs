using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;

namespace PowerInfo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();            
        }

        private void Update_Click(object sender, EventArgs e)
        {
            var status = SystemInformation.PowerStatus;
            var currentLife = status.BatteryLifePercent;

            // 배터리 전압 가져오기
            var voltage = "-";
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT DesignVoltage FROM Win32_Battery");
            foreach (ManagementObject obj in searcher.Get())
            {
                if(obj["DesignVoltage"] != null)
                {
                    double voltageValue = Convert.ToDouble(obj["DesignVoltage"]);
                    voltageValue /= 1000;
                    voltage = voltageValue.ToString("F2");
                }
            }           

            Voltage.Text = voltage + "V";            
            CurrentCharge.Text = (currentLife*100).ToString() + "%";
            BatteryTemperature.Text = "배터리 온도";
            
            if (status.PowerLineStatus == PowerLineStatus.Online)
            {
                ACConnect.Text = "충전 중입니다.";
            }
            else
            {
                ACConnect.Text = "충전 중이 아닙니다.";
            }

            //if(status.BatteryLifePercent != 255)
            //{
            //    BatteryProgress.Value = (int)(status.BatteryLifePercent * 100);
            //}
            //else
            //{
            //    BatteryProgress.Value = 0;
            //}

            

        }
    }
}
