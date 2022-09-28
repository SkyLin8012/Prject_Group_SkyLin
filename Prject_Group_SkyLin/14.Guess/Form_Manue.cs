using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H_GuessNumber
{
    public partial class Form_Manue : Form
    {

       //建立類別實體
        ClassGuess gus = new ClassGuess();
        public Form_Manue()
        {
            InitializeComponent();
        }

        private void btn_Guess_Click(object sender, EventArgs e)
        {
            //再產生實體時將自己帶入
            Form_Guess gu = new Form_Guess(this);    
            
            DialogResult GuessResult = gu.ShowDialog();
            if (GuessResult == DialogResult.OK)
            { 
            
            }

        }

        private void Form_Manue_Load(object sender, EventArgs e)
        {
            //進入遊戲即產生亂數
            gus.buildAnNumber();
        }

        private void btn_Answer_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Anser:{ClassGuess.AnswerNumber}");
            //重新產生亂數
            gus.buildAnNumber();
        }
    }
}
