using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Seller seller = new Seller();
            seller.fName = "Bengt";
            seller.lName = "Bengtsson";
            System.Console.WriteLine("{0} {1}", seller.fName, seller.lName);
            System.Console.Read();
        }
    }
}
