using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H_0924_XOGame
{
    public partial class From_XOGame : Form
    {
        public From_XOGame()
        {
            InitializeComponent();
            foreach (Control con in this.panel_key_group.Controls)
            {
                con.BackColor = Color.LightYellow;
                con.Text = "";
                con.Click += playRun;
                //MessageBox.Show(con.Name);
            }
            this.KeyPreview = true;
        }


        ClassXOGame game = new ClassXOGame();

        void playRun(object sender, EventArgs e)
        {
            game.btnClickRun(sender, this.panel_key_group);
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            foreach (Control key in this.panel_key_group.Controls)
            {
                key.Enabled = true;
                key.Text = "";

            }
        }

       

        private void Lab_XOGame_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
            }
            if (e.KeyChar == (char)82|| e.KeyChar == (char)114)
            {
                foreach (Control key in this.panel_key_group.Controls)
                {
                    key.Enabled = true;
                    key.Text = "";

                }

            }
        }


    }
}
