using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H_0927_MyClac
{
    public partial class form_MyClac : Form
    {
        TextBox[] txtControl = new TextBox[3];
        cls_ClassMyClas clas = new cls_ClassMyClas();
        public form_MyClac()
        {
            InitializeComponent();
            txtControl = new TextBox[2] { txt_Num1_val, txt_Num2_val };
            txt_Answer_val.ReadOnly = true;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            clas.method_Add(txtControl);
           if(clas.flg) txt_Answer_val.Text = $"{ clas.Answer}";

        }

        private void btn_minus_Click(object sender, EventArgs e)
        {
            clas.method_minus(txtControl);
            if (clas.flg) txt_Answer_val.Text = $"{clas.Answer}";
        }

        private void btn_mulitply_Click(object sender, EventArgs e)
        {
            clas.method_mulitply(txtControl);
            if (clas.flg) txt_Answer_val.Text = $"{clas.Answer}";
        }

        private void btn_Divided_Click(object sender, EventArgs e)
        {
            clas.method_Divided(txtControl);
            if (clas.flg) txt_Answer_val.Text = $"{clas.Answer}";
        }
    }
}
