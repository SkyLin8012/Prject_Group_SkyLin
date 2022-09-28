using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H_0919_Hello
{
    class ClassMyInfo
    {
        public static string name;
        public static string ename;
        public static string sex;
        public static string star;

        public static string massage()
        {
            return $"我是,{name}\n英文姓名是,{ename}\n性別是,{sex}\n星座是,{star}\n很高興認識你!";
        }
    }
}
