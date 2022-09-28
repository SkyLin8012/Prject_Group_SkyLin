using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H0926_ForDoWhile
{
    internal class cls_ForDoWhile
    {
        public static int arryn { get; set; }
        public int[] arry0926;
        public string[] arry0926_Str;
        public string Arrprint_int;
        public string Arrprint_str;
        public string lab_infoLine;
        public int[] for_do_while_arry;
        public int for_do_while_total;
        public bool for_do_while_flag;
       
        //建立號碼不重複的數字陣列
        public void method_BuildArray(int low,int max, ref int[]arry,int arrlong)
        {
            arry = new int[arrlong];
            Random rang = new Random();
            for (int i = 0; i < arry.Length; i++)
            {
                arry[i] = rang.Next(low,max);
                for (int j = 0; j < i; j++)
                {
                    
                    while (arry[i] == arry[j])
                    {
                        arry[i]=rang.Next(low,max);
                        j = 0;   //還要重新檢查
                    }
                }
            }
        }
        //排序 可用 Array.Sort(Array arr);
        public void method_ArraySort()
        {
            int temp = 0;
            for (int i = 0; i< arry0926.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (arry0926[i] < arry0926[j])
                    {
                        temp = arry0926[i];
                        arry0926[i] = arry0926[j];
                        arry0926[j] = temp;
                    }
                }
            }        
        }

       
        #region 生出陣列字串用多載(OverLoad)
        //數字陣列print
        public void method_lineupArryword(int[] arry0926)
        {
            Arrprint_int = "int 陣列 Arry0926[";
            for (int i = 0; i < arry0926.Length ; i++)
            {
                Arrprint_int += $"  {arry0926[i]},";
            }
            Arrprint_int = Arrprint_int.TrimEnd(',');  //去除末尾字元
            Arrprint_int += "]";
        }
        //文字陣列
        public void method_lineupArryword(string[] arry0926_Str)
        {
            Arrprint_str = "Arry0926_Str陣列:";
            for (int i = 0; i < arry0926_Str.Length; i++)
            {
              
                Arrprint_str += $"   {arry0926_Str[i]}";
            }
            
        }
        #endregion

        //判斷基數或偶數
        public void method_statistics_OddEven()
        {
            int evenN = 0;
            int OddN = 0;
            for (int i = 0; i < arry0926.Length; i++)
            {
                if (arry0926[i] % 2 == 0)
                {
                    evenN++;
                }
                else if (arry0926[i] % 2 == 1)
                { 
                   OddN++;
                }
            }
            method_lineupArryword(arry0926);
            lab_infoLine = $"{Arrprint_int}\n";
            lab_infoLine += $"奇數共:{OddN}\n偶數共:{evenN}";


        }

        public void method_enternumber_OddorEve(string str)
        {
            int num = 0;
            bool check = int.TryParse(str, out num);
            string oddeven = "";
            if (check == false)
            {
                MessageBox.Show("請輸入數字", "錯誤");

            }
            else
            {
                oddeven = (num % 2 == 1) ? "奇數" : "偶數";
                lab_infoLine = $"輸入的數值: {num},為 {oddeven}";
            }



        }

        public void method_array_maxlongname()
        {
            string tempMax= arry0926_Str[0];
            for (int i = 0; i < arry0926_Str.Length; i++)
            {
                if (tempMax.Length < arry0926_Str[i].Length)
                {
                    tempMax = arry0926_Str[i];
                }
            }
            method_lineupArryword(arry0926_Str);
            lab_infoLine = $"{Arrprint_str}\n最長的名字為  {tempMax}";
        }

        public void method_array_MaxMin()
        {
           
            int Max = arry0926[0];
            int Min = arry0926[0];
            for (int i = 0; i < arry0926.Length; i++)
            {
                if (Max < arry0926[i]) Max = arry0926[i];
                if (Min > arry0926[i]) Min = arry0926[i];
            }
            method_lineupArryword(arry0926);
            lab_infoLine = $"{Arrprint_int}\n最大值:{Max}\n最小值:{Min}";
        }

        //找特定元素 可用 Array.IndexOf(Array arr,object val)
        public void method_CinArray()
        {
            int cont = 0;
          
            for (int i = 0; i < arry0926_Str.Length; i++)
            {
                char[] temp = arry0926_Str[i].ToCharArray();
                for (int j = 0; j < temp.Length; j++)
                {
                    if (temp[j] == 'c' || temp[j] == 'C')
                    { 
                        cont++;
                        break;
                    }
                }
            }
            method_lineupArryword(arry0926_Str);
            lab_infoLine = $"{Arrprint_str}\n有 c及 C的名字共有  {cont}";
        }

        public void method_2Darry_SideLineIs1(int Alength, int Awitch, int sidelineval, int contentval)
        {
            int[,] array= method_Build2DLineArry(Alength, Awitch, sidelineval, contentval);

            method_2Darry_print(array);

        }

        private int[,] method_Build2DLineArry(int Alength, int Awitch,int sidelineval, int contentval )
        {
           int[,] arrylin1 = new int[Alength, Awitch];
            for (int i = 0; i < arrylin1.GetLength(0); i++)
            {

                for (int j = 0; j < arrylin1.GetLength(1); j++)
                {

                    if (i == 0 || i == arrylin1.GetLength(0) - 1)
                    {
                        arrylin1[i, j] = sidelineval;

                    }
                    else if (j == 0 || j == arrylin1.GetLength(1) - 1)
                    {
                        arrylin1[i, j] = sidelineval;
                    }
                    else
                    {
                        arrylin1[i, j] = contentval;
                    }
                }
            }
            return arrylin1;
        }

        private void method_2Darry_print<G>(G[,]arryline)
        {
            lab_infoLine = "";
            for (int i = 0; i < arryline.GetLength(0); i++)
            {
                for (int j = 0; j < arryline.GetLength(1); j++)
                {
                    lab_infoLine+= arryline[i, j];
                }
                lab_infoLine += "\n";
            }
        }

        public  void method_2Darry_content01(int Alength, int Awitch)
        {
            bool flag = false;
            int[,] cub = new int[Alength, Awitch];
            for (int i = 0; i < cub.GetLength(0); i++)
            {
                for (int j = 0; j < cub.GetLength(1); j++)
                {
                    if (flag) cub[i, j] = 1;
                    else cub[i, j] = 0;

                    flag = !flag;
                }
                flag = !flag;
            }

            //印出來
            method_2Darry_print(cub);
        }
        //泛型練習
        public void method_Swap_int_str<G>(ref G a, ref G b)
        { 
            G temp = a;     
            a = b;      
            b = temp;
        }

        //Sum
        public void method_Sum()
        {
            int arrysum = 0;
            // arrysum = arry0926.Sum();

            for (int i = 0; i < arry0926.Length; i++)
            { 
               arrysum+= arry0926[i];
            }

            method_lineupArryword(arry0926);
            lab_infoLine = $"{Arrprint_int}\n加總為:  {arrysum}";
        }

        //<fo_while_do>
        #region for_while_do
        public void method_build_intervalArry(string from,string top,string step ,ref int[]arry,ref bool flg)
        {
            string[] str = new string[] { from, top, step };
            int[] num = new int[str.Length];
            bool check=true;
            int count = 0;
            foreach (string p in str)
            {
                check = int.TryParse(p, out num[count]);
                if(check==false) break;
                count++;
            }
            if (check == true)
            {
                if (num[2] != 0)
                {
                    int intF = num[0], intT = num[1], intS = num[2];
                    //起點要小於終點才執行
                    if ((intT - intF) > 0)
                    {
                        int arraylength = Convert.ToInt16(Math.Ceiling((double)(intT - intF) / intS));
                         arry = new int[arraylength];
                        for (int i = 0; i < arry.Length; i++)
                        {
                            arry[i] = intF + (i * intS);
                        }
                        //建立陣列完成
                       flg = true;
                    }
                    else
                    { 
                       arry = new int[0];
                        flg = true;
                    }

                }
                else
                {
                    MessageBox.Show("間隔不能輸入0", "錯誤");
                    check = false;
                }
            }
            else
            {
                if (check == false) { MessageBox.Show("請輸入數字", "錯誤"); }
            }
           
           
        }

        public void method_for(string from, string top, string step)
        {
            for_do_while_flag = false;
            method_build_intervalArry(from, top, step, ref for_do_while_arry, ref for_do_while_flag);
            if(for_do_while_flag)
            { 
            int[] arry = for_do_while_arry;
            int total =0;
            for (int i = 0; i < arry.Length; i++)
            {
                total += arry[i];
            }
            for_do_while_total = total;
            lab_infoLine = $"{from}到 {top} 間隔{step}\n加總為: {for_do_while_total}";
            }
            else
            {
                lab_infoLine = "結果";
            }
        }

        public void method_while(string from, string top, string step)
        {
            for_do_while_flag = false;
            method_build_intervalArry(from, top, step, ref for_do_while_arry, ref for_do_while_flag);
            if (for_do_while_flag)
            {
                int[] arry = for_do_while_arry;
                int total = 0;
                int i = 0;
                while (i < arry.Length)
                {
                    total += arry[i];
                    i++;
                }
                for_do_while_total = total;
                lab_infoLine = $"{from}到 {top} 間隔{step}\n加總為: {for_do_while_total}";
            }
            else
            {
                lab_infoLine = "結果";
            }
        }

        public void method_do(string from, string top, string step)
        {
            for_do_while_flag = false;
            method_build_intervalArry(from, top, step, ref for_do_while_arry, ref for_do_while_flag);
            if (for_do_while_flag)
            {
                int[] arry = for_do_while_arry;
                int total = 0;
                int i = 0;
                do
                {
                    total += arry[i];
                    i++;
                }
                while (i < arry.Length);
                for_do_while_total = total;
                lab_infoLine = $"{from}到 {top} 間隔{step}\n加總為: {for_do_while_total}";
            }
            else
            {
                lab_infoLine = "結果";
            }
        }
        #endregion
        //<fo_while_do>

        public void method_rightangle_tree(string treelong) 
        {           
            int result;
            bool check = int.TryParse(treelong, out result);
            string[,] tree;
            if (check)
            {
                tree = new string[result, result];
                for (int i = 0; i < tree.GetLength(0); i++)
                {
                    for (int j = 0; j < tree.GetLength(1); j++)
                    {

                        if (j <= i)
                        {
                            tree[i, j] = "*";
                        }
                        else
                        {
                            tree[i, j] = "";
                        }
                    }
                }
                method_2Darry_print(tree);
            }
            else
            {
                MessageBox.Show("請輸入數字", "錯誤");
                lab_infoLine = "結果";
            }


        }

        public void method_99Table()
        {
            string[,] table = new string[8, 9];
            for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    string str = $"{i + 2}x {j + 1} = {(i + 2) * (j + 1):D2} |";
                    if (((i + 2) * (j + 1)) < 10)
                    {
                     //   str = $"{i + 2}x {j + 1} = {(i + 2) * (j + 1):D2} |".Replace("0", "  " );
                    }

                    table[i, j] = str;
                }
            }
            method_2Darry_print(table);


        }
        //樂透
        public void method_lotto()
        {
            int num = 6;
            int[] lotto = new int[num];
            string str = "";
            method_BuildArray(1, 100, ref lotto, num);
            for (int i = 0; i < lotto.Length; i++)
            {
                str += $" {lotto[i]}"; 
            }
            lab_infoLine = $"樂透號碼:\n{str}";
        }

       //100的2 進位
        public void method_100_binary()
        {
            int num = 100;
            int temp = num;
            int log = 0;
            string str = "";
           
            while (num >= 1)
            {
                log++;
                num = num / 2;
            }
            
           
            int[] byt= new int[log];
            for (int i = byt.Length-1; i >=0; i--)
            {
                byt[i] = temp % 2;
                temp = temp / 2;
                
            }
            foreach (int p in byt)
            {
                str += $"{p}";
              
            }

            lab_infoLine = str;

        }
    }
    //用於Swap與泛型應用
    class cls_nval { public string name; public int val; }
}
