using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thiskeyword
{
   
    
    internal class Program
    {
        static void Main(string[] args)
        {
            //----------MYCLASS.CS-----------------------------------
            MyClass obj = new MyClass(100, 200);
            obj.Add();
            //===================================================================
            //
            //--------------------STUDENT.CS-------------------------------------------
            Student std = new Student(1, "Janani");
            std.Studentdetails();
            //====================================================================
            //
            //----------------EMPLOYEE.CS------------------------------------
            Console.WriteLine("Enter Employee id:");
            int Empid = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Employee Name");
            string Empname = Console.ReadLine();
            Console.WriteLine("Enter Employee salary");
            double Empsal = double.Parse(Console.ReadLine());
            Employee emp = new Employee(Empid,Empname,Empsal);
            emp.DisplayDetails();
            Employee emp1=new Employee();
            emp1.DisplayDetails();
            //============================================================================================================
            //
            //-----------------------CUSTOMER.CS-----------------------------------------
            Console.WriteLine("enter number of students");
            int n=int.Parse(Console.ReadLine());
            Customer[] cust=new Customer[n];
            for (int i=0;i<n;i++)
            {
                Console.WriteLine("enter Customer id");
                int id=int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Customer name");
                string name=Console.ReadLine();
                Console.WriteLine("Enter Customer sal");
                double sal=double.Parse(Console.ReadLine());

                cust[i]=new Customer(id,name,sal);

            }
            for (int i=0;i<n; i++)
            {
                Console.WriteLine("*************************************");
                cust[i].Display();
            }

        }
    }



}
