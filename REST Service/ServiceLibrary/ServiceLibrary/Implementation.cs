using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.ServiceModel.Activation;

namespace Rameshkartik.WCFSamples.REST
{
    
    [AspNetCompatibilityRequirements(RequirementsMode=AspNetCompatibilityRequirementsMode.Allowed)]
    public class Implementation : IBook
    {

        public List<Book> GetBookDetails()
        {
            return BookData.Instance.BookCollection;
        }

        public Book GetBook(int BookId)
        {
            return BookData.Instance.GetBook(BookId);
        }

        public void AddBook(Book BookObject)
        {
            BookData.Instance.AddBook(BookObject);
        }

        public void UpdateBook(Book BookObjectUpdate)
        {
            BookData.Instance.Update(BookObjectUpdate);
        }

        //public void DeleteBook(int BookId)
        //{
        //    BookData.Instance.Delete(BookId);
        //}
    }
}
