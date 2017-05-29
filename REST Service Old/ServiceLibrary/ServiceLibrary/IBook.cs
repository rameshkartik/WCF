using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Rameshkartik.WCFSamples.REST
{
    [ServiceContract]
    public interface IBook
    {
        [OperationContract]
        List<Book> GetBookDetails(int value);

        [OperationContract]
        Book GetBook(
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
            new Book() {BookId= 1,BookName="Friends",BookPrice=150}
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

        public void Delete(int BookId)
        {
            Book BookExisting = booklist.Find(b => b.BookId == BookId);
            BookCollection.Remove(BookExisting);
        }

        public void AddBook(Book BookObjectToAdd)
        {
            BookCollection.Add(new Book
            {
                BookId = BookObjectToAdd.BookId,
                BookName = BookObjectToAdd.BookName,
                BookPrice = BookObjectToAdd.BookPrice
            });
        }


    }
}
