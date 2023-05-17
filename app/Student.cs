using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app {
    class Student {
        //Pieces of info that describe what a book is...
        public string name;
        public string major;
        public double gpa;

        //Constructor - A special method that is inside our class that's gonna get called when we create a object
        public Student(string aName, string aMajor, double aGPA){
            name = aName;
            major = aMajor;
            gpa = aGPA;
        }

        public bool HasHonors(){
            if (gpa >= 2.5){
                return true;
            }
            return false;
        }
    }
}