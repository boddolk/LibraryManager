using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using libraryMeneger.book;

namespace libraryMeneger.Data.BookRepository
{
    public abstract class IBooksRepository
    {
        protected IBooksRepository() { }
        public abstract GenBook getBook(int article);
        public abstract bool updateBook(GenBook updatedOne);
        public abstract bool insertBook(GenBook newBook);
        public abstract bool deleteBook(int article);
        public abstract List<GenBook> getAllBooks();
        public abstract List<GenBook> getAvailableBooksForBooking();
    }
}
