using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thiskeyword
{
   
    
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass(100, 200);
            obj.Add();
            Student std = new Student(1, "Janani");
            std.Studentdetails();
        }
    }



}
