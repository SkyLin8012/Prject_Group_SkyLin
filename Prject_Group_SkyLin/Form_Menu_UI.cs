using H_0919_Hello;
using H_0920_Loan;
using H_0921_POS;
using H_0922_Student_StrucForm;
using H_0924_XOGame;
using H_0926_ForDoWhile;
using H_0927_MyClac;
using H_Alarm;
using H_GuessNumber;
using H0923_StudentsGrade_List;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Prject_Group_SkyLin
{
    public partial class Form_Meun_UI : Form
    {
        public Form_Meun_UI()
        {
            InitializeComponent();
            splitContainer1.IsSplitterFixed = false;
            splitContainer1.FixedPanel = FixedPanel.Panel1;
            splitContainer2.FixedPanel = FixedPanel.Panel1;
        }

        void showForm(Form f)
        {
            splitContainer2.Panel2.Controls.Clear();
            f.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(f);
            f.Show();        
        }

        private void btn_show_Hello_Click(object sender, EventArgs e)
        {
            H0919_Hello f = new H0919_Hello();
            showForm(f);
        }

        private void btn_Loan_Click(object sender, EventArgs e)
        {
           Form_Loan f = new Form_Loan();
            showForm(f);
        }

        private void btn_POS_Click(object sender, EventArgs e)
        {
            Bar_POS f = new Bar_POS();
            showForm(f);
        }

        private void btn_Student_Struce_Click(object sender, EventArgs e)
        {
            StudentForm f = new StudentForm();
            showForm(f);
        }

        private void btn_StudentGrade_list_Click(object sender, EventArgs e)
        {
            Form_StudentsGrade f = new Form_StudentsGrade();
            showForm(f);
        }

        private void btn_MyClac_Click(object sender, EventArgs e)
        {
            form_MyClac f = new form_MyClac();
            showForm(f);
        }

        private void btn_ForDoWhile_Click(object sender, EventArgs e)
        {
            Form_Method f = new Form_Method();
            showForm(f);
        }

        private void btn_XOGame_Click(object sender, EventArgs e)
        {
            From_XOGame f = new From_XOGame();
            showForm(f);
        }

        private void btn_Guess_Click(object sender, EventArgs e)
        {
            Form_Manue f = new Form_Manue();
            showForm(f);
        }

        private void btn_Alarm_Click(object sender, EventArgs e)
        {
            Form_Alarm f = new Form_Alarm();
            showForm(f);
        }
    }
}
