using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer.Data.Tools.ExceptionMessageBox;

namespace H0923_StudentsGrade_List
{
    
   
    class clsCourseStatisticData
    {
        public string CourseName { get; set; }
        public int CourseTotal { get; set; }
        public float CourseEverage { get; set; }
        public int CourseTop { get; set; }
        public int CourseLow { get; set; }

        public List<clsCourseStatisticData> CourseList =new List<clsCourseStatisticData>();

        public string StatisticInfo;

        public void Methods_Analysisscorce(List<clsStudentInfo> List)
        {
            clsCourseStatisticData Chi = new clsCourseStatisticData()
            {
                CourseName = "chi",
                CourseTotal = List.Sum(p =>p.ChiScor),
                CourseEverage = (float)((float)List.Sum(p => p.ChiScor)/List.Count),
                CourseLow = List.Min(p=>p.ChiScor),
                CourseTop = List.Max(p=>p.ChiScor)
            };
            clsCourseStatisticData Eng = new clsCourseStatisticData()
            {
                CourseName = "eng",
                CourseTotal = List.Sum(p => p.EngScor),
                CourseEverage = (float)((float)List.Sum(p => p.EngScor) / List.Count),
                CourseLow = List.Min(p => p.EngScor),
                CourseTop = List.Max(p => p.EngScor)

            };
            clsCourseStatisticData Math= new clsCourseStatisticData()
            {
                CourseName = "math",
                CourseTotal = List.Sum(p => p.MathScor),
                CourseEverage = (float)((float)List.Sum(p => p.MathScor) / List.Count),
                CourseLow = List.Min(p => p.MathScor),
                CourseTop = List.Max(p => p.MathScor)
            };

            CourseList.Add(Chi);
            CourseList.Add( Eng);
            CourseList.Add(Math);

            for (int i = 0; i< 4; i++)
            {
                if (i == 0)
                { 
                    StatisticInfo += "總分:\t";
                    for (int j = 0; j < CourseList.Count; j++)
                    {
                        StatisticInfo += $"{CourseList[j].CourseTotal}\t";
                    }
               }
                if (i == 1)
                {
                    StatisticInfo += "\n平均:\t";
                    for (int j = 0; j < CourseList.Count; j++)
                    {
                        StatisticInfo += $"{CourseList[j].CourseEverage:N2}\t";
                    }
                }
                if (i ==2)
                {
                    StatisticInfo += "\n最高分:\t";
                    for (int j = 0; j < CourseList.Count; j++)
                    {
                        StatisticInfo += $"{CourseList[j].CourseTop}\t";
                    }
                }
                if (i == 3)
                {
                    StatisticInfo += "\n最低分:\t";
                    for (int j = 0; j < CourseList.Count; j++)
                    {
                        StatisticInfo += $"{CourseList[j].CourseLow}\t";
                    }
                }
            }
        }



    }

    class clsStudentInfo
    {
        public string StudentName { get; set; }
        public clsCourseData Chi = new clsCourseData();
        public clsCourseData Eng=new clsCourseData();
        public clsCourseData Math=new clsCourseData();
        public int ChiScor;
        public int EngScor;
        public int MathScor;
        public int TotalScorce = new int();
        public float EverageScorce = new float();

       
     //   public List<clsStudentInfo> StudentLis=new List<clsStudentInfo>();
     //顯示搜尋國文成績清單
       
      public List<clsStudentInfo> ChiSearchList = new List<clsStudentInfo>();

     //顯示分析請單
     //   public List<clsStudentInfo> CourseList=new List<clsStudentInfo>();

        public clsCourseData Top=new clsCourseData();
        public string TopName;
        public int TopScore;
        public clsCourseData Low=new clsCourseData();
        public string LowName;
        public int LowScore;

      
        public void Methods_ShowSearchLis(int low,int top,List<clsStudentInfo> StudentLise)
        {
            ChiSearchList.Clear();
            for (int i = 0; i < StudentLise.Count; i++)
            {
                if (StudentLise[i].ChiScor >= low &&StudentLise[i].ChiScor <= top)
                {
                    ChiSearchList.Add(StudentLise[i]);
                }
            }
            showList(ChiSearchList);

        }
        

        public clsStudentInfo Methods_LIstBuild( clsCourseData chi,clsCourseData eng, clsCourseData mat)
        {
            clsCourseData[] scor = { chi, eng, mat };
            //氣泡排序
            for (int i = 0; i < scor.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (scor[j].CourseScorce > scor[i].CourseScorce)
                    {
                        clsCourseData temp = scor[j];
                        scor[j] = scor[i];
                        scor[i] = temp;
                    }
                }
            }
            //單筆資料
            clsStudentInfo stu = new clsStudentInfo()
            {        
                StudentName = StudentName,
                Chi = chi,
                Eng = eng,
                Math = mat,
                ChiScor = chi.CourseScorce,
                EngScor = eng.CourseScorce,
                MathScor = mat.CourseScorce,
                TotalScorce = chi.CourseScorce + eng.CourseScorce + mat.CourseScorce,
                EverageScorce = (float)(chi.CourseScorce + eng.CourseScorce + mat.CourseScorce )/ 3,
                Low = scor[0],
                LowName = scor[0].CourseName,
                LowScore = scor[0].CourseScorce,
                Top = scor[scor.Length - 1],
                TopName = scor[scor.Length - 1].CourseName,
                TopScore = scor[scor.Length - 1].CourseScorce
               
             };

            return stu;
        }

        public void Methods_Add(List<clsStudentInfo> StudentLis) 
        {
            clsStudentInfo stu = Methods_LIstBuild(Chi, Eng, Math);
            StudentLis.Add(stu);
            showList(StudentLis);
        }

        public void Methods_Insert(List<clsStudentInfo> StudentLis)
        {
            clsStudentInfo stu = Methods_LIstBuild(Chi, Eng, Math);
            StudentLis.Insert(0,stu);
            showList(StudentLis);
        }

        public void Methods_remove(List<clsStudentInfo> StudentLis)
        {

            clsStudentInfo stu = Methods_LIstBuild(Chi, Eng, Math);
            
            for (int i = 0; i < StudentLis.Count; i++)
            {
                if (StudentLis[i] == stu)
                {
                    StudentLis.Remove(stu);
                    break;
                }
                else
                {
                    if (i == StudentLis.Count - 1)
                    {
                        StudentLis.Remove(StudentLis[0]);
                    }
                }
            }
            showList(StudentLis);
        }
        public void Methods_Clear(List<clsStudentInfo> StudentLis)
        {
            StudentLis.Clear();
            listWord = "";
        }
        //顯示版面文字
        public string listWord;
        public void showList(List<clsStudentInfo> StudentLis)
        {
            listWord = "";
            List<clsStudentInfo> list = StudentLis;
            //MessageBox.Show($"List長度={list.Count}");
            for (int i = 0; i < list.Count; i++)
            {
                listWord += $"{list[i].StudentName}\t{list[i].ChiScor}\t{list[i].EngScor}\t{list[i].MathScor}\t{list[i].TotalScorce}\t{list[i].EverageScorce:N1}\t{list[i].LowName}{list[i].LowScore}\t{list[i].TopName}{list[i].TopScore}\n";
               // int a = 0;
            }

        }

        //錯誤控制
        public void ErroApp(Exception ex, Form_StudentsGrade form)
        {
            string str = "錯誤";
            ApplicationException ap = new ApplicationException(str, ex);
            ap.Source = form.Text;
            ExceptionMessageBox box = new ExceptionMessageBox(ap);
            box.Show(form);

        }

       public void ScorceinData(Panel pal)
        {

            int count = 0;
            bool check = true;
            foreach (Control ctr in pal.Controls)
            {
                count++;
                if (ctr is TextBox)
                {
                    switch (count)
                    {
                        case 1:
                            StudentName = ctr.Text;
                            if (ctr.Text == "" && check == true) { MessageBox.Show("請輸入姓名"); check = false; }
                            break;
                        case 2:
                            if (ctr.Text == "" && check == true) { MessageBox.Show("請輸入國文成績"); check = false; }
                            Chi.CourseName = "國文";
                            Chi.CourseScorce = int.Parse(ctr.Text);
                            break;
                        case 3:
                            if (ctr.Text == "" && check == true){MessageBox.Show("請輸入英文成績"); check = false; }
                            Eng.CourseName = "英文";
                            Eng.CourseScorce = int.Parse(ctr.Text);
                        
                            break;
                        case 4:
                            if (ctr.Text == ""&&check==true){ MessageBox.Show("請輸入數學成績"); check = false; }
                Math.CourseName = "數學";
                            Math.CourseScorce = int.Parse(ctr.Text);
                           
                            break;
                    }
                 //   break;
                }
            }

        }


    }
    class clsCourseData
    {
       
        public string CourseName { get; set; }        
        public int CourseScorce { get; set; }

    }
}
