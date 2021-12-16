using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryApp
{
    public class Library
    {
        public List<Book> Books = new List<Book>();

        public List<Book> FindAllBooksByName(string str)
        {
            return Books.FindAll(book => book.Name.Contains(str));
        }

        public void RemoveAllBooksByName(string str)
        {
            Console.WriteLine(Books.RemoveAll(book => book.Name.Contains(str)));
        }

        public List<Book> Search(string str)
        {
            return Books.FindAll(book => book.Name.Contains(str) || book.AuthorName.Contains(str) || book.PageCount.ToString().Contains(str));
        }

        public List<Book> FindAllBooksByPageCountRange(int minRange, int maxRange)
        {
            return Books.FindAll(book => book.PageCount >= minRange && book.PageCount <= maxRange);
        }

        public void RemoveByCode(string code)
        {
            var wantedBook =  Books.Find(book => book.BookCode == code);

            if(wantedBook != null)
            {
                Books.Remove(wantedBook);
            }
        }
    }
}
