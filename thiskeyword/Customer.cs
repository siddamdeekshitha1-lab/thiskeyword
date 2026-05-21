using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thiskeyword
{

    internal class Customer
    {
        int custid;
        string custname;
        double custsal;
        public Customer(int custid,string custname,double custsal)
        {
            this.custid = custid;
            this.custname = custname;
            this.custsal = custsal;
        }
        public void Display()
        {
            Console.WriteLine("Customer id is:" + custid);
            Console.WriteLine("Customer Name is:"+custname);
            Console.WriteLine("Customer sal is:"+custsal);
        }
    }
}
