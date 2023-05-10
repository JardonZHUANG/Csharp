using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//   命名空间
namespace ConsoleApplication1
{
    //类：
    class Program
    {
        static void Main( string[ ] args )
        {
            Console.WriteLine("hello world");
             // 字符型
            char c = 'a';  //ASCII码
            
            //字符可以和整型相互转换
            int code = c; //断点
            int i = 0;

            //布尔型，只有两个值： true、 false
            bool ok = true;
            ok = false;

            //日期型
            DateTime birthday = new DateTime(1999, 1, 1, 16, 23, 45);
        }
    }
}
