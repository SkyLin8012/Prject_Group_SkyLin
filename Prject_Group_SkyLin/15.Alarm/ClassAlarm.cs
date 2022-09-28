using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H_Alarm
{
    public class ClassAlarm
    {
        public bool check { get; set; }//判斷是否按下checkBox設定時間
        public bool colorchange { get; set; } //背景顏色閃動效果
        public bool backswitch { get; set; } //背景閃動的開關

        public void BackChang(bool switchkey,H_Alarm.Form_Alarm from)
        {
            if (switchkey == true)
            {
                if (colorchange)
                {
                    from.BackColor = Color.Green;
                }
                else
                {
                    from.BackColor = Color.Red;
                }
                colorchange = !colorchange;
            }


        }

    }
}
