using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app {
    class Book {
        //Pieces of info that describe what a book is...
        public string title;
        public string author;
        public int pages;

        //Constructor - A special method that is inside our class that's gonna get called when we create a object
        public Book(string aTitle, string aAuthor, int aPages){
            title = aTitle;
            author = aAuthor;
            pages = aPages;
        }
    }
}