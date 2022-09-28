using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace H_0921_POS
{
    internal class ClassBarPos
    {
        public static double TotalPrice { get; set; }

        public static List<ClassPaymentList> FinalPayList =new List<ClassPaymentList>();

        private int same_name_cont;

        public void cash()
        {
            MessageBox.Show($"總金額{TotalPrice:c0}", "確認付款");
        }

        public void credit()
        {
            MessageBox.Show($"總金額{TotalPrice:c0}\n折扣後金額{TotalPrice*0.9:c0}", "確認付款");
        }

       

        //建立資料表  //todo
       
        public void biludList(string VProName, int VProNumber, double VProToPri) 
        {
           
          
            //計算總金額
            TotalPrice += VProToPri;
            same_name_cont = 0;
            //list建構   
            if (FinalPayList.Count != 0)
            {
               
                for (int i = 0; i < FinalPayList.Count(); i++)
                {
                    ClassPaymentList p = new ClassPaymentList();
                    p = FinalPayList[i];
                    //若遇到相同的相加
               //     MessageBox.Show($"輸入名字{VProName}\n此筆名字{p.ProName}\n名字相同次數{same_name_cont}");
                    if (p.ProName == VProName)
                    {
                        same_name_cont++;
                        //取出p的數量與金額座相加
                        VProNumber += p.ProNumber;
                        VProToPri += p.ProToPri;
                        //刪去陣列中的p的資料
                        FinalPayList.Remove(p);
                        //重建一筆加入
                        ClassPaymentList row = new ClassPaymentList()
                        {
                            ProName = VProName,
                            ProNumber = VProNumber,
                            ProToPri = VProToPri
                        };
                        FinalPayList.Add(row);
                    }
                    
                }
             //   MessageBox.Show($"相同名字數{same_name_cont}");
                if (same_name_cont == 0)
                {
             //       MessageBox.Show("沒有相同名字");
                    //沒有相同名字新增一筆
                    ClassPaymentList row = new ClassPaymentList()
                    {
                        ProName = VProName,
                        ProNumber = VProNumber,
                        ProToPri = VProToPri
                    };
                    FinalPayList.Add(row);
                }

            }
            else
            {
                ClassPaymentList row = new ClassPaymentList()
                {
                    ProName = VProName,
                    ProNumber = VProNumber,
                    ProToPri = VProToPri
                };
                FinalPayList.Add(row);
            }
       
        }      
    }

    internal class ClassPaymentList
    {
        public string ProName { get; set; }
        public int ProNumber { get; set; }
        public double ProToPri { get; set; }
    }

}
