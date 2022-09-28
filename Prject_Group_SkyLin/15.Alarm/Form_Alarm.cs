using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H_Alarm
{
    public partial class Form_Alarm : Form
    {
        ClassAlarm al = new ClassAlarm();
        public Form_Alarm()
        {
            InitializeComponent();
            this.msktxt_contrl.Mask = "00時00分00秒";
            this.msktxt_contrl.ValidatingType = typeof(System.DateTime);
            al.check = false; //判斷是否按下checkBox設定時間
            al.colorchange=false; //背景顏色閃動效果
            al.backswitch=false; //背景閃動的開關
        }
        private void cheBox_SetAlarm_CheckedChanged(object sender, EventArgs e)
        {
            if (cheBox_SetAlarm.Checked)  //設定時間，並停止閃動
            {
                al.check = true;
            }
            else
            { 
               al.check = false;
            }
           al.backswitch = false;
           BackColor = Color.White;
        }
        private void timer_control_Tick(object sender, EventArgs e)
        {
            lab_time_new.Text = DateTime.Now.ToString("hh:mm:ss");
            string Masktxt = msktxt_contrl.Text;
            string[] ArryList = Masktxt.Split('時', '分', '秒');
            string SetupTime = $"{ArryList[0]}:{ArryList[1]}:{ArryList[2]}";
            
            if (al.check == true)
            {
                
                if (SetupTime == DateTime.Now.ToString("hh:mm:ss"))  //時間到時背景閃動
                {
                    al.backswitch= true;                    
                }

                al.BackChang(al.backswitch,this);
            }
        }

        

       
    }
}
