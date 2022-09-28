using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H_GuessNumber
{
    internal class ClassGuess
    {
        public static int AnswerNumber { get; set; }

        public static string GuessInfo { get; set; }

        private int Top = 100;

        private int Low = 1;


        public void buildAnNumber()
        {
            Random ran = new Random();
         
            AnswerNumber = ran.Next(1, 100);
        }

        public void GuessPlay(string number)
        {
            bool chacknumber=true;
            int playenum;           
            chacknumber = int.TryParse(number,out playenum);
            if (chacknumber != true)
            {
                MessageBox.Show("請輸入0到100間的數字", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }
            else
            {
                int An = AnswerNumber;
               
                if (playenum > Top || playenum < Low)
                {
                    MessageBox.Show($"請輸入{Low} ~ {Top} 間的數字", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (playenum == An)
                {
                    MessageBox.Show($"Congraduation!!! You got {AnswerNumber} !!!","",MessageBoxButtons.OK,MessageBoxIcon.None);
                    GuessInfo = $"Congraduation!!!\nYou got {AnswerNumber} !!!";
                }
                else if (playenum > An)
                {
                    Top = playenum;
                    GuessInfo = $"TooSmall!!\nBetween{Low} and {Top}.";
                }
                else if (playenum < An)
                {
                    Low = playenum;
                    GuessInfo = $"TooSmall!!\nBetween{Low} and {Top}.";
                }
                
            }

        }

    }
}
