using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thiskeyword
{
    internal class Student
    {
        int stdid;
        string stdname;
        public Student(int stdid,string stdname)
        {
            this.stdid = stdid;
            this.stdname = stdname;
        }
        public void Studentdetails()
        {
            Console.WriteLine("student id is:" + stdid);
            Console.WriteLine("Student name is:"+stdname);
        }
    }
}
