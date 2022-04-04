using System;
using System.Collections.Generic;
using System.Text;

namespace _04042022
{
    internal class Book
    {
        public Book()
        {
            _no++;
            No = _no;
        }

        private static int _no;
        public int No { get;  }
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public Genre Genre { get; set; }
        public int Price { get; set; }  

    }
}
