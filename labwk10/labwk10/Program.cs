using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labwk10
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMath MyMath1 = new MyMath();
            MyMath MyMath2 = new MyMath();
            MyMath MyMath3 = new MyMath();
            MyMath MyMath4 = new MyMath();

            MyMath.setResult("multiply");
            MyMath.setResult("divide");
            MyMath.setResult("subtract");
            MyMath.setResult("add");


            Console.WriteLine(MyMath1.getResult.());
            Console.WriteLine(MyMath2.getResult());
            Console.WriteLine(MyMath3.getResult());
            Console.WriteLine(MyMath4.getResult());
        }
    }
}
