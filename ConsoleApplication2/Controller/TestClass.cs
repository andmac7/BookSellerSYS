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
            string cmd = "SELECT * FROM BookAd";
            var books = BookAdDb.Read(cmd);
            Console.WriteLine("Writing existing books..");
            foreach (BookAd i in books)
            {
                Console.WriteLine("{0} av {1}, ISBN: {2}", i.title, i.author, i.isbn);
            }
        }

        public static void TestSellerRead()
        {
            string cmd = "SELECT * FROM Seller";
            var sellers = SellerDb.Read(cmd);
            Console.WriteLine("Writing existing sellers..");
            foreach (Seller i in sellers)
            {
                Console.WriteLine("{0} {1}, City: {2}, Phone Number: {3}", i.fName, i.lName, i.city, i.phoneNbr);
            }
        }

        public static void TestCourseRead()
        {
            string cmd = "SELECT * FROM Course";
            var courses = CourseDb.Read(cmd);
            Console.WriteLine("Writing existing courses..");
            foreach (Course i in courses)
            {
                Console.WriteLine("{0}, {1}", i.cCode, i.cName );
            }
        }

        public static void TestInstRead()
        {
            string cmd = "SELECT * FROM Institution";
            var insts = InstDb.Read(cmd);
            Console.WriteLine("Writing existing institutions..");
            foreach (Inst i in insts)
            {
                Console.WriteLine("{0}", i.instName);
            }
        }
    }
}
