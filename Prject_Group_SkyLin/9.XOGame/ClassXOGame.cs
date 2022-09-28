using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace H_0924_XOGame
{
    internal class ClassXOGame
    {
        public int[,] btnval = new int[3, 3];
        private bool flag = true;
        private int cont = 0;
        public void btnClickRun(object sender, Control pel)
        {
            if (flag == true)
            {
                ((Button)sender).Text = "X";
            }
            else if (flag == false)
            {
                ((Button)sender).Text = "O";
            }
            flag = !flag;
            ((Button)sender).Enabled = false;
            cont++;
            int xcont = 8;
            foreach (Control x in pel.Controls)
            {
          
                if (xcont / 3 == 0)
                {
                    if (x.Name == $"btn_{xcont}" && x.Text == "X") btnval[0, xcont % 3] = 1;
                    else if (x.Name == $"btn_{xcont}" && x.Text == "O") btnval[0, xcont % 3] = -1;
                }
                if (xcont / 3 == 1)
                {
                    if (x.Name == $"btn_{xcont}" && x.Text == "X") btnval[1, xcont % 3] = 1;
                    else if (x.Name == $"btn_{xcont}" && x.Text == "O") btnval[1, xcont % 3] = -1;
                }
                if (xcont / 3 == 2)
                {
                    if (x.Name == $"btn_{xcont}" && x.Text == "X") btnval[2, xcont % 3] = 1;
                    else if (x.Name == $"btn_{xcont}" && x.Text == "O") btnval[2, xcont % 3] = -1;
                }
                xcont--;
            }

            int w1 = btnval[0, 0] + btnval[0, 1] + btnval[0, 2];
            int w2 = btnval[1, 0] + btnval[1, 1] + btnval[1, 2];
            int w3 = btnval[2, 0] + btnval[2, 1] + btnval[2, 2];
            int w4 = btnval[0, 0] + btnval[1, 0] + btnval[2, 0];
            int w5 = btnval[0, 1] + btnval[1, 1] + btnval[2, 1];
            int w6 = btnval[0, 2] + btnval[1, 2] + btnval[2, 2];
            int w7 = btnval[0, 0] + btnval[1, 1] + btnval[2, 2];
            int w8 = btnval[0, 2] + btnval[1, 1] + btnval[2, 0];

            if (w1 == 3 || w2 == 3 || w3 == 3 || w4 == 3 || w5 == 3 || w6 == 3 || w7 == 3 || w8 == 3) { MessageBox.Show("x手獲勝", "完局"); reGame(pel); }
            else if (w1 == -3 || w2 == -3 || w3 == -3 || w4 == -3 || w5 == -3 || w6 == -3 || w7 ==- 3 || w8 ==- 3) { MessageBox.Show("o手獲勝", "完局"); reGame(pel); }
            else if(cont>=9) { MessageBox.Show("平手,按下確定重新開始", "完局"); reGame(pel); }
        }

        void reGame(Control pel)
        {
            foreach (Control x in pel.Controls)
            {
                x.Enabled = true;
                x.Text = "";
                cont = 0;
            }
            Array.Clear(btnval, 0, btnval.Length);
        }


    }
}
