using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello world ");
            Console.WriteLine("안녕 세상아");

            int age = 19;
            String name = "전하영";

            Console.WriteLine("나는 "+age+"이고 이름은 "+name+"입니다");
            Console.WriteLine("나는 {0}이고 이름은 {1}입니다",age,name);
            Console.WriteLine("------------------------------");

            int tmpX;
            int tmpY;
            tmpX = 7;
            tmpY = 8;
            Console.WriteLine("{0} + {1} = {2}", tmpX, tmpY, tmpX + tmpY);
            Console.WriteLine("{0} + {1} = {2}", tmpX.ToString(), tmpY.ToString(), (tmpX + tmpY).ToString());
            Console.WriteLine("------------------------------");
            String tmpLang = "c#";
            string tmpName = "Class"; //대소문자 차이 없음
            Console.WriteLine("{0}:{1}", tmpName, tmpLang);

        }
    }
}