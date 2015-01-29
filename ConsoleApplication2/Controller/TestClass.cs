using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSeller
{
    class TestClass
    {
        public static void TestBooksRead() 
        {
            var books = BookAdDb.Read();
            Console.WriteLine("Writing existing books..");
            foreach (BookAd i in books)
            {
                Console.WriteLine("{0} av {1}, ISBN: {2}", i.title, i.author, i.isbn);
            }
            Console.ReadLine();
        }

        public static void TestSellerRead()
        {
            var sellers = SellerDb.Read();
            Console.WriteLine("Writing existing sellers..");
            foreach (Seller i in sellers)
            {
                Console.WriteLine("{0} {1}, City: {2}, Phone Number: {3}", i.fName, i.lName, i.city, i.phoneNbr);
            }
            Console.ReadLine();
        }

        public static void TestCourseRead()
        {
            var courses = CourseDb.Read();
            Console.WriteLine("Writing existing courses..");
            foreach (Course i in courses)
            {
                Console.WriteLine("{0}, {1}", i.cCode, i.cName );
            }
            Console.ReadLine();
        }

        public static void TestInstRead()
        {
            var insts = InstDb.Read();
            Console.WriteLine("Writing existing courses..");
            foreach (Inst i in insts)
            {
                Console.WriteLine("{0}", i.instName);
            }
            Console.ReadLine();
        }
    }
}
