using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app {
    class Movie {
        //Pieces of info that describe what a book is...
        public string title;
        public string director;
        private string rating;

        //Constructor - A special method that is inside our class that's gonna get called when we create a object
        public Movie(string aTitle, string aDirector, string aRating){
            title = aTitle;
            director = aDirector;
            Rating = aRating;
        }

        public string Rating {
            get {return rating;}
            set {if (value == "G" || value == "PG" || value == "PG-13" || value == "R" || value == "NR") {
                rating = value;
            } else {
                rating = "NR";
            }}
        }
    }
}