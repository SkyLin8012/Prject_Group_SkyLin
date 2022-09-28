using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer.Data.Tools.ExceptionMessageBox;

namespace H0923_StudentsGrade_List
{
    public partial class Form_StudentsGrade : Form
    {
        public Form_StudentsGrade()
        {
            InitializeComponent();
           
        }
        clsStudentInfo stuifo = new clsStudentInfo();
        List<clsStudentInfo> StudentLIst = new List<clsStudentInfo>();
       
    
        
        private void btn_AddGrade_Click(object sender, EventArgs e)
        {

            try
            {
                stuifo.ScorceinData(this.Panel_stu_val);
                stuifo.Methods_Add(StudentLIst);
                richTxt_ShowScore.Text = stuifo.listWord;
            }            
            catch (Exception ex) 
            {
                stuifo.ErroApp(ex,this);
            }
           
        }

        private void btn_InsetGrade_Click(object sender, EventArgs e)
        {
            try
            {
            stuifo.ScorceinData(this.Panel_stu_val);
            stuifo.Methods_Insert(StudentLIst);           
            richTxt_ShowScore.Text = stuifo.listWord;
            }
            catch (Exception ex)
            {
                stuifo.ErroApp(ex,this);
            }
        }

        private void btn_RemoveGrade_Click(object sender, EventArgs e)
        {
            try
            {
            stuifo.Methods_remove(StudentLIst);
            richTxt_ShowScore.Text = stuifo.listWord;
            }
            catch (Exception ex)
            {
                stuifo.ErroApp(ex,this);
            }
        }

        private void btn_ClearGrade_Click(object sender, EventArgs e)
        {
            stuifo.Methods_Clear(StudentLIst);
            richTxt_ShowScore.Text = stuifo.listWord;
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            try
            {
                stuifo.Methods_ShowSearchLis(int.Parse(txt_Low.Text), int.Parse(txt_top.Text), StudentLIst);
                richTxt_ShowScore.Text = stuifo.listWord;
            }
            catch (Exception ex)
            {
                stuifo.ErroApp(ex,this);
            }
            
        }

        private void btn_Analisys_Score_Click(object sender, EventArgs e)
        {
            try
            {
                btn_AddGrade.Enabled = false;
                btn_InsetGrade.Enabled = false;
                btn_RemoveGrade.Enabled = false;
                clsCourseStatisticData statistic = new clsCourseStatisticData();
                statistic.Methods_Analysisscorce(StudentLIst);
                richtxt_show_Analysisscorce.Text = statistic.StatisticInfo;
            }
            catch(Exception ex)
            {
                stuifo.ErroApp(ex,this);
            }
            
        }

       
    }
}
