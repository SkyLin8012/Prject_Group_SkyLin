using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H_0921_POS
{
    public partial class Bar_POS : Form
    {
        public Bar_POS()
        {
            InitializeComponent();
        }
        //宣告變數實體
        ClassPaymentList list = new ClassPaymentList();

        ClassBarPos pos = new ClassBarPos();

        private void showPosInfo(List<ClassPaymentList> dt)
        {
            //排序
            dt.Sort(delegate (ClassPaymentList x, ClassPaymentList y)
            {
                return x.ProName.CompareTo(y.ProName);
            });

            //輸出
            txt_ToPri.Text = $"{ClassBarPos.TotalPrice:c0}";
            richtxt_List.Clear();
            // MessageBox.Show("觸發表單");     
            for (int i = 0; i < dt.Count; i++)
            {
                richtxt_List.Text += $"{dt[i].ProName} ";
                richtxt_List.Text += $"x{dt[i].ProNumber} ";
                richtxt_List.Text += $"共{dt[i].ProToPri:c0}\n";

            }
        }
        private void btn_Beer_Click(object sender, EventArgs e)
        {

            pos.biludList("啤酒Beer", 1, 120);
            showPosInfo(ClassBarPos.FinalPayList);


        }

        private void btn_Tequila_Click(object sender, EventArgs e)
        {
            pos.biludList("龍舌蘭Tequila", 1, 180);
            showPosInfo(ClassBarPos.FinalPayList);

        }

        private void btn_Whisky_Click(object sender, EventArgs e)
        {
            pos.biludList("威士忌Whisky", 1, 350);
            showPosInfo(ClassBarPos.FinalPayList);
        }

        private void btn_Wine_Click(object sender, EventArgs e)
        {
            pos.biludList("紅酒", 1, 320);
            showPosInfo(ClassBarPos.FinalPayList);
        }

        private void btn_cash_Click(object sender, EventArgs e)
        {
            pos.cash();
        }

        private void btn_credit_Click(object sender, EventArgs e)
        {
            pos.credit();
        }

        private void btn_clearList_Click(object sender, EventArgs e)
        {
            richtxt_List.Clear();
            richtxt_List.Text = "未點餐";
            //清空記憶體中的靜態資料
            ClassBarPos.TotalPrice=0;
            ClassBarPos.FinalPayList.Clear();
            txt_ToPri.Text = $"{ClassBarPos.TotalPrice:c0}";
        }

        private void Bar_POS_Load(object sender, EventArgs e)
        {
            btn_Beer.Text = $"啤酒\nBeer\n{120:c0}";
            btn_Wine.Text = $"紅酒\nWine\n{320:c0}";
            btn_Whisky.Text = $"威士忌\nWhisky\n{350:c0}";
            btn_Tequila.Text = $"龍舌蘭\nTequila\n{180:c0}";
        }
    }
}
