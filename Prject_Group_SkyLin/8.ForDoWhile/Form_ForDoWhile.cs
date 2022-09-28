using H0926_ForDoWhile;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H_0926_ForDoWhile
{
    public partial class Form_Method : Form
    {

        cls_ForDoWhile fdw;
        public Form_Method()
        {
            InitializeComponent();
            cls_ForDoWhile.arryn = 9;
            fdw = new cls_ForDoWhile();
            fdw.method_BuildArray(0,100,ref fdw.arry0926, cls_ForDoWhile.arryn);
            //fdw.method_ArraySort();
            string strwork = "mother林,emma,迪克蕭,J40,Candy,Cindy,Cocount,Motherfacker";
            fdw.arry0926_Str = strwork.Split(',');
        }

        

       

        private void btn_statistics_OddEven_Click(object sender, EventArgs e)
        {
            fdw.method_statistics_OddEven();
            lab_Show_Rresult.Text = fdw.lab_infoLine;

        }

        private void btn_enternumber_OddorEven_Click(object sender, EventArgs e)
        {
            string str = txt_EnterNumber.Text;
            fdw.method_enternumber_OddorEve(str);
            lab_Show_Rresult.Text = fdw.lab_infoLine;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            fdw.lab_infoLine = "";
            lab_Show_Rresult.Text = "結果";
        }

        private void btn_array_maxlongname_Click(object sender, EventArgs e)
        {
            fdw.method_array_maxlongname();
            lab_Show_Rresult.Text = fdw.lab_infoLine;
        }

        private void btn_array_MaxMin_Click(object sender, EventArgs e)
        {
            fdw.method_array_MaxMin();
            lab_Show_Rresult.Text = fdw.lab_infoLine;
        }

        private void btn_CinArray_Click(object sender, EventArgs e)
        {
            fdw.method_CinArray();
            lab_Show_Rresult.Text = fdw.lab_infoLine;
        }

        private void btn_2Darry_SideLineIs1_Click(object sender, EventArgs e)
        {
            fdw.method_2Darry_SideLineIs1(10, 10, 1, 0);
            lab_Show_Rresult.Text = fdw.lab_infoLine;
        }

        private void btn_2Darry_SideLineIs0_Click(object sender, EventArgs e)
        {
            fdw.method_2Darry_SideLineIs1(10, 10, 0, 1);
            lab_Show_Rresult.Text = fdw.lab_infoLine;
        }

        private void btn_2Darry_content01_Click(object sender, EventArgs e)
        {
            fdw.method_2Darry_content01(10, 10);
            lab_Show_Rresult.Text = fdw.lab_infoLine;
        }

        private void btn_Swap_int_str_Click(object sender, EventArgs e)
        {
            string bef;     
               cls_nval[] n = new cls_nval[] 
                 {
                  new cls_nval(){ name="AAA" , val = 100},
                  new cls_nval(){ name="BBB" ,  val= 200}
                 };
            //前
            bef = $"換位前 n1:name={n[0].name} val={n[0].val} ,  n2:name={n[1].name} val={n[1].val} ";       

            //後
            fdw.method_Swap_int_str(ref n[0].val, ref n[1].val);
            fdw.method_Swap_int_str(ref n[0].name, ref n[1].name);
            lab_Show_Rresult.Text = $"{bef}\n換位後 n1:name={n[0].name} val={n[0].val} ,  n2:name={n[1].name} val={n[1].val} ";

        }

        private void btn_Sum_Click(object sender, EventArgs e)
        {
            fdw.method_Sum();
            lab_Show_Rresult.Text = fdw.lab_infoLine;
        }

        private void btn_Max_Click(object sender, EventArgs e)
        {
            fdw.method_lineupArryword(fdw.arry0926);
            int max = fdw.arry0926.Max();
            lab_Show_Rresult.Text = $"{fdw.Arrprint_int}\n最大值為:  {max}";
        }

        private void btn_Min_Click(object sender, EventArgs e)
        {
            fdw.method_lineupArryword(fdw.arry0926);
            int min = fdw.arry0926.Min();
            lab_Show_Rresult.Text = $"{fdw.Arrprint_int}\n最大值為:  {min}";
        }

        private void btn_for_Click(object sender, EventArgs e)
        {
            fdw.method_for(txt_From_val.Text, txt_To_val.Text, txt_Step_val.Text);
            lab_Show_Rresult.Text = fdw.lab_infoLine;
        }

        private void btn_while_Click(object sender, EventArgs e)
        {
            fdw.method_while(txt_From_val.Text, txt_To_val.Text, txt_Step_val.Text);
            lab_Show_Rresult.Text = fdw.lab_infoLine;

        }

        private void btn_do_Click(object sender, EventArgs e)
        {
            fdw.method_do(txt_From_val.Text, txt_To_val.Text, txt_Step_val.Text);
            lab_Show_Rresult.Text = fdw.lab_infoLine;

        }

        private void btn_rightangle_tree_Click(object sender, EventArgs e)
        {
            fdw.method_rightangle_tree(txt_treeRows_val.Text);
            lab_Show_Rresult.Text = fdw.lab_infoLine;
        }

        private void btn_99Table_Click(object sender, EventArgs e)
        {
            fdw.method_99Table();
            lab_Show_Rresult.Text = $"九九乘法表:\n{ fdw.lab_infoLine}";
        }

        private void btn_lotto_Click(object sender, EventArgs e)
        {
            fdw.method_lotto();
            lab_Show_Rresult.Text = fdw.lab_infoLine;

        }

        private void btn_100_binary_Click(object sender, EventArgs e)
        {
            fdw.method_100_binary();
            lab_Show_Rresult.Text = fdw.lab_infoLine;
        }
    }
}
