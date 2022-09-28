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
    public partial class Form_Guess : Form
    {
        //public Form_Guess()
        //{
        //    InitializeComponent();
        //}

        private Form_Manue frm;  //宣告Form_Manue 變數
        
        //產生時代入的Form_Manue實體指定給 frm變數
        public Form_Guess(Form_Manue form1)
        {
            frm = form1;   //即可操作父視窗
            InitializeComponent(); //初始化組件
        }

        ClassGuess gu = new ClassGuess();

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Enter_Click(object sender, EventArgs e)
        {
            gu.GuessPlay(txt_playnum.Text);

            frm.lab_GuessInfo.Text = $"{ClassGuess.GuessInfo}";

            /*
               System.Windows.Form.Form f= System.Windows.Forms.Application.OpenForms["Form_Manue"];
               
                在F
             
             */


        }

        private void Form_Guess_Load(object sender, EventArgs e)
        {
            int x = (System.Windows.Forms.SystemInformation.WorkingArea.Width - this.Size.Width) / 2;  //螢幕寬1/2位置
            int y = (System.Windows.Forms.SystemInformation.WorkingArea.Height - this.Size.Height) / 2; //螢幕高 1/2位置
            this.Location = (Point)new Size(x, y); //窗體的起始位置為x,y
        }
    }
}
