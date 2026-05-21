using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thiskeyword
{
    internal class MyClass
    {

        int num1;
        int num2;
        public MyClass(int num1, int num2) //local variables 
        {
            this.num1 = num1;//instance variables=local variables
            this.num2 = num2;
        }
        public void Add()
        {
            int num3 = num1 + num2;
            Console.WriteLine("sum of two numbers=" + num3);
        }
    }
}
