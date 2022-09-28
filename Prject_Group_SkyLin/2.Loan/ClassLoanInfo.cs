using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H_0920_Loan
{
    class Cla_loanInfo
    { 
       public int loanMoney { get; set; }//總借貸金額
       public int period { get; set; } //期數(月)
        public float APR { get; set; }//年利率

        public int talRepay { get; set; }


        public List<Cla_AmountPayTable> Cal(int vMoney, int vMonth, float vRate)
        {
            List<Cla_AmountPayTable> tab = new List<Cla_AmountPayTable>();
            int temptalRepay = 0;
            //double temprepayPri = (float)vMoney / (float)vMonth;
            //MessageBox.Show(temprepayPri.ToString());

            int repayPri = (int)Math.Ceiling((float)vMoney / (float)vMonth);
            for (int i = 0; i < vMonth; i++)
            {   
                //計算利息
                float Repay = (vMoney * ((vRate/100)/12));
                vMoney = vMoney- repayPri;
                temptalRepay += (int)Math.Round(Repay);
                Cla_AmountPayTable row = new Cla_AmountPayTable()
                {
                    period_title = i+1,
                    repayPri = repayPri,
                    repayInterset = (int)Repay,
                    talrepay = repayPri + (int)Repay
                };
                tab.Add(row);
            }
            talRepay = temptalRepay;



            return tab;
        }
    }
    class Cla_AmountPayTable
    { 
        //期數
        public int period_title { get; set; }
        //償還本金
        public int repayPri { get; set; }
        //償還利息
        public int repayInterset { get; set; }
        //本期應繳金額
        public int talrepay { get; set; }
    }
}
