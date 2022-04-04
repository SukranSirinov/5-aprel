using System;
using System.Collections.Generic;
using System.Text;

namespace _04042022
{
    internal class Library
    {
        List<Book>Books=new List<Book>();
        public Library()
        {
            Books = new List<Book>();

        }
        public List<Book> FilterByPrice(int min,int max)
        {
            return Books.FindAll(x => x.Price < min && x.Price > max);
        }
        public List<Book> FilterByGenre(Genre genre)
        {
            return Books.FindAll(x=>x.Genre == genre);

        }
        public Book FİndBookByNo(int no)
        {
             return Books.Find(x => x.No == no);
        }

    }
}
