using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app {
    class Song {
        //Pieces of info that describe what a book is...
        public string name;
        public string singer;
        public int duration;
        public static int songCount = 0; //Belongs to the class, unable to access it using an object (In other words, this attributes tells us something about the class and not the object)

        //Constructor - A special method that is inside our class that's gonna get called when we create a object
        public Song(string aName, string aSinger, int aDuration){
            name = aName;
            singer = aSinger;
            duration = aDuration;
            songCount++;
        }
    }
}