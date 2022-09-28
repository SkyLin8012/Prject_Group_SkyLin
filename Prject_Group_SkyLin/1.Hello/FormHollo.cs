using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H_0919_Hello
{
    public partial class H0919_Hello : Form
    {
       


        public H0919_Hello()
        {
            InitializeComponent();
        }

       

        private void btn_Hello_MouseEnter(object sender, EventArgs e)
        {
            btn_Hello.BackColor = Color.Silver;
        }

        private void btn_Hello_MouseLeave(object sender, EventArgs e)
        {
            btn_Hello.BackColor = Color.FromArgb(224, 224, 224);
        }

        private void btn_SayHi_MouseLeave(object sender, EventArgs e)
        {
            btn_SayHi.BackColor = Color.Silver;
        }

        private void btn_SayHi_MouseEnter(object sender, EventArgs e)
        {
            btn_SayHi.BackColor = Color.FromArgb(224, 224, 224);
        }

        private void SetInfor()
        {
            ClassMyInfo.name = txtBoxName.Text;
            ClassMyInfo.ename = txtBoxEName.Text;
            ClassMyInfo.sex = txtBoxSex.Text;
            ClassMyInfo.star = txtBoxStar.Text;
        }

        private void btn_Hello_Click(object sender, EventArgs e)
        {
            SetInfor();
            
            MessageBox.Show($"Hello!{ClassMyInfo.massage()}");
        }


        private void btn_SayHi_Click(object sender, EventArgs e)
        {
            SetInfor();

            MessageBox.Show($"Hello!{ClassMyInfo.massage()}");
        }
    }
}
