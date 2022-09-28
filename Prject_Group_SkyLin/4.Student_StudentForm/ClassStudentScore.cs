using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace _0922_Student_StrucForm
{

    class  cls_SubjectData
    {
        public string SubName { get; set; }
        public int SubScore { get; set; }
    }

    struct ClsStudentScore
    {
        public string Name { get; set; }

        public int Chi_score { get; set; }

        public int Eng_score { get; set; }

        public int Math_score { get; set; }

        public ClsStudentScore(string name, int chi, int eng, int math)
        { 
            Name = name;
            Chi_score = chi;
            Eng_score =eng;
            Math_score = math;        
        }

        public void Analysisscorce(cls_SubjectData Chi, cls_SubjectData Eng, cls_SubjectData Math,ref cls_SubjectData Low_score, ref cls_SubjectData Top_score)
        {


            cls_SubjectData[] scor = { Chi, Eng, Math };
            //氣泡排序
            for (int i = 0; i < scor.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (scor[j].SubScore > scor[i].SubScore)
                    {
                        cls_SubjectData temp = scor[j];
                        scor[j] = scor[i];
                        scor[i] = temp;
                    }
                }

            }
            Low_score = scor[0];
            Top_score = scor[scor.Length - 1];

        }


    }
}
