using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Web;
using System.ServiceModel.Web;
using System.ServiceModel.Activation;
namespace Rameshkartik.WCFSamples.REST
{
    [ServiceContract]
    public interface IBook
    {
        [WebGet(UriTemplate = "Book" )]
        [OperationContract]
        List<Book> GetBookDetails();

        [WebGet(UriTemplate = "Book?id={BookId}")]
        [OperationContract]
        Book GetBook(int BookId);

        [WebInvoke(Method = "POST", UriTemplate="BookPost")]
        [OperationContract]
        void AddBook(Book BookObject);

        [WebInvoke(Method = "PUT",UriTemplate="BookPut")]
        [OperationContract]
        void UpdateBook(Book BookObjectUpdate);

        //[WebInvoke(Method = "DELETE",UriTemplate="Book/{BookId}")]
        //[OperationContract]
        //void DeleteBook(int BookId);
    }


    [DataContract]
    public class Book
    {
        [DataMember]
        public int BookId { get; set; }

        [DataMember]
        public string BookName { get; set; }

        [DataMember]
        public int BookPrice { get; set; }

    }

    public partial class BookData
    {
        private static readonly BookData _bookInstance = new BookData();
        public static BookData Instance
        {
            get
            {
                return _bookInstance;
            }

        }

        private List<Book> booklist = new List<Book>()
        {
            new Book() { BookId= 1,BookName="Sydney sheldon",BookPrice=150},
            new Book() { BookId= 2,BookName="The King",BookPrice=150},
            new Book() { BookId= 1,BookName="Friends",BookPrice=150}
        };


        public List<Book> BookCollection
        {
            get
            {
                return booklist;
            }
        }


        public void Update(Book BookObjectToUpdate)
        {
            Book BookExisting = booklist.Find(b => b.BookId == BookObjectToUpdate.BookId);

            if (BookExisting == null)
            {
                throw new KeyNotFoundException("Book not found");
            }

            BookExisting.BookId = BookObjectToUpdate.BookId;
            BookExisting.BookName = BookObjectToUpdate.BookName;
            BookExisting.BookPrice = BookObjectToUpdate.BookPrice;
        }

        //public void Delete(int BookId)
        //{
        //    Book BookExisting = booklist.Find(b => b.BookId == BookId);
        //    BookCollection.Remove(BookExisting);
        //}

        public void AddBook(Book BookObjectToAdd)
        {
            BookCollection.Add(new Book
            {
                BookId = BookObjectToAdd.BookId,
                BookName = BookObjectToAdd.BookName,
                BookPrice = BookObjectToAdd.BookPrice
            });
        }

        public Book GetBook(int BookId)
        {
            IEnumerable<Book> BookList = BookData.Instance.BookCollection.Where(x => x.BookId == BookId);
            if (BookList != null)
            {
                return BookList.First<Book>();
            }
            else
                return null;
        }


    }
}
