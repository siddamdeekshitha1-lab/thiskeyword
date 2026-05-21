using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thiskeyword
{
    internal class Employee
    {
        int Empid;
        string Empname;
        double Empsal;
        public Employee(int Empid,string Empname,double Empsal)
        {
            this.Empid=Empid;
            this.Empname=Empname;
            this.Empsal=Empsal;
          
        }
        public Employee()
        {
            Empid = 1;
            Empname = "sai";
            Empsal = 100000;
        }
        
        public void DisplayDetails()
        {
            Console.WriteLine("Employee id is:" + Empid);
            Console.WriteLine("Employee name is:"+Empname);
            Console.WriteLine("Employee sal is:"+Empsal);
        }
    }
}
