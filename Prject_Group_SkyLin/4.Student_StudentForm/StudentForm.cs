using _0922_Student_StrucForm;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer.Data.Tools.ExceptionMessageBox;


namespace H_0922_Student_StrucForm
{
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
        }

        ClsStudentScore scor;
        private void btn_Save_Click(object sender, EventArgs e)
        {
           
            try
            {
                 scor = new ClsStudentScore(txt_Name.Text,int.Parse(txt_ChiValue.Text),int.Parse(txt_EngValue.Text),int.Parse(txt_MathValue.Text));
            }
            catch (Exception ex)
            {
                // Define a new top-level error message.
                string str = "The action failed.";

                // Add the new top-level message to the handled exception.
                ApplicationException exTop = new ApplicationException(str, ex);
                exTop.Source = this.Text;

                // Show an exception message box with an OK button (the default).
                ExceptionMessageBox box = new ExceptionMessageBox(exTop);
                box.Show(this);

            }
            
        }

        private void btn_show_Save_Click(object sender, EventArgs e)
        {
            
            richtxt_scorManu.Text = $"姓名:{scor.Name}\n國文:{scor.Chi_score}分\n英文:{scor.Eng_score}分\n數學:{scor.Math_score}分";
        }

        private void btn_Analysis_scorce_Click(object sender, EventArgs e)
        {
            cls_SubjectData Chi = new cls_SubjectData() {
                SubName = "國文",
                SubScore = scor.Chi_score                
            };
            cls_SubjectData Eng = new cls_SubjectData()
            {
                SubName = "英文",
                SubScore = scor.Eng_score
            };
            cls_SubjectData Math = new cls_SubjectData()
            {
                SubName = "數學",
                SubScore = scor.Math_score
            };

            cls_SubjectData low = new cls_SubjectData();
            cls_SubjectData top = new cls_SubjectData();

            //MessageBox.Show($"{Chi.SubName}{Chi.SubScore},{Eng.SubName}{Eng.SubScore},{Math.SubName}{Math.SubScore}");
             scor.Analysisscorce(Chi,Eng,Math,ref low,ref top);
             richtxt_show_Analysisscorce.Text = $"最高科目成績為:{top.SubName} {top.SubScore}\n最低科目成績為:{low.SubName} {low.SubScore}";
        }
    }
}
