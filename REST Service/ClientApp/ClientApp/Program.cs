using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientApp.BookServiceReference;

namespace ClientApp
{
    class Program
    {
        static void Main(string[] args)
        {
            BookClient BC = new BookClient();
            Book[] b  =   BC.GetBookDetails();
            foreach (Book BObj in b)
            {
                Console.WriteLine("Book Id: " + BObj.BookId.ToString());
                Console.WriteLine("BookName: " + BObj.BookName.ToString());
                Console.WriteLine("BookPrice: " + BObj.BookPrice.ToString());
            }
            Console.ReadLine();
        }
    }
}
