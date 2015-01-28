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
                Console.WriteLine(i.title);
            }
            Console.ReadLine();
        }
    }
}
