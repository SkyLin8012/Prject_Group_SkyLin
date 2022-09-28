using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H_0920_Loan
{
    public partial class Form_Loan : Form
    {
        public Form_Loan()
        {
            InitializeComponent();
        }

        private void but_clear_Click(object sender, EventArgs e)
        {
            ricTxt_Table.Text = "";

        }

        private void Form_Loan_Load(object sender, EventArgs e)
        {
            txt_loanMoney.Text = "1000000";
            Txt_period.Text = "240";
            Txt_APR.Text = "2.4";

        }

        
        private void But_CALC_Go_Click(object sender, EventArgs e)
        {
            Cla_loanInfo loa = new Cla_loanInfo()
            {
                loanMoney = int.Parse(txt_loanMoney.Text),
                APR = float.Parse(Txt_APR.Text),
                period = int.Parse(Txt_period.Text),               
            };

            List<Cla_AmountPayTable> tab =  loa.Cal(loa.loanMoney, loa.period, loa.APR);
            int TotalInterset = loa.talRepay;
         //  MessageBox.Show($"總利息:{TotalInterset}");
            txt_interset.Text = TotalInterset.ToString();
            ShowTable(tab);
        }

        private void ShowTable(List<Cla_AmountPayTable> dt)
        {
            List<string> title = new List<string>();
            title.Add("期數");
            title.Add("償還本金");
            title.Add("償還利息");
            title.Add("本期應繳金額");
            for (int i = 0; i < title.Count; i++)
            {
                ricTxt_Table.Text += $"{title[i]} ";             
            }
            ricTxt_Table.Text += "\n\n";
            for (int i = 0; i < dt.Count; i++)
            {
                ricTxt_Table.Text += $"{dt[i].period_title}\t";
                ricTxt_Table.Text += $"{dt[i].repayPri}\t";
                ricTxt_Table.Text += $"{dt[i].repayInterset}\t";
                ricTxt_Table.Text += $"{dt[i].talrepay}\n";
            }
           // int v = 0;
        }
    }
}
