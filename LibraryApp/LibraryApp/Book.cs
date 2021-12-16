using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryApp
{
    public class Book
    {
        public static int Counter = 10;
        public Book(string name,string authorName,int pageCount)
        {
            Counter++;
            this.Name = name;
            this.AuthorName = authorName;
            this.PageCount = pageCount;
            this.BookCode = name.Substring(0, 2).ToUpper() + Counter;

        }

        public string Name { get; set; }
        public string AuthorName { get; set; }
        public int PageCount { get; set; }
        public string BookCode { get; set; }
    }
}
