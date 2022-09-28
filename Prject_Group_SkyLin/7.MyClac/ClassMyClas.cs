using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace H_0927_MyClac
{
    internal class cls_ClassMyClas
    {
        public decimal num1;
        public decimal num2;
        public decimal Answer;
        public bool flg;

        public void method_checkfield(TextBox[] box,ref bool flg)
        {
            flg = false;
            int num;
            foreach (TextBox x in box)
            {
                if (int.TryParse(x.Text, out num))
                {
                    switch (x.Name)
                    {
                        case "txt_Num1_val":
                           
                            num1 = num;
                            break;
                        case "txt_Num2_val":
                            num2 = num;
                            break;
                       
                    }
                    flg = true;
                }
                else
                {
                    MessageBox.Show("請輸入數字", "錯誤");
                    flg = false;
                    break;
                   
                }
            }
        
        }
        public void method_Add(TextBox[] box)
        {
            method_checkfield(box,ref flg);
           // MessageBox.Show($"{num1},{num2}");
            if (flg) Answer = num1 + num2;

        }

        public void method_minus(TextBox[] box)
        {
            method_checkfield(box, ref flg);
            // MessageBox.Show($"{num1},{num2}");
            if (flg) Answer = num1 - num2;
        }

        public void  method_mulitply(TextBox[] box)
        {
            method_checkfield(box, ref flg);
            // MessageBox.Show($"{num1},{num2}");
            if (flg) Answer = num1 * num2;
        }

        public void method_Divided(TextBox[] box)
        {
            method_checkfield(box, ref flg);
            // MessageBox.Show($"{num1},{num2}");
            if (flg) Answer =decimal.Round( num1 / num2, 4);
        }

    }
}
