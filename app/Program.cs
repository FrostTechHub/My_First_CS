using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app {
    class Program {
        static void Main(string [] args) {
            string statement = "Hello World!";

            //.Length counts the number of characters in a string
            Console.WriteLine($"{statement} has {statement.Length} characters!");

            string greeting = "      Hello World!       ";
            Console.WriteLine($"[{greeting}]");

            //Trim the empty space at the front
            string trimmedGreeting = greeting.TrimStart();
            Console.WriteLine($"[{trimmedGreeting}]");

            //Trim the empty space at the back
            trimmedGreeting = greeting.TrimEnd();
            Console.WriteLine($"[{trimmedGreeting}]");

            //Trim the empty space at the front and back
            trimmedGreeting = greeting.Trim();
            Console.WriteLine($"[{trimmedGreeting}]");

            //.Replace, replaces the string
            statement = statement.Replace("World", "Alvin");
            Console.WriteLine($"{statement}");

            //Convert string to Uppercase and Lowercase
            Console.WriteLine(statement.ToUpper());
            Console.WriteLine(statement.ToLower());

            //Searches the string for a given keyword/character
            string songLyrics = "You say goodbye, and I say hello";
            Console.WriteLine(songLyrics.Contains("goodbye"));
            Console.WriteLine(songLyrics.Contains("greetings"));

            //Checks if the the variable contains keyword
            Console.WriteLine(statement.Contains("World"));

            //Prints out the individual character in the variable based on position of character
            Console.WriteLine(statement[3]);

            //Locates where the first character of the keyword is located in the variable (-1 = Does not exist)
            Console.WriteLine(statement.IndexOf("Alvin"));

            //Starts grabing the string based on character position (Starting Character, No. of characters to grab)
            Console.WriteLine(statement.Substring(8, 3));

            //Data Types
            string name = "JackFrost";
            char grade = 'A';
            int age = 32;
            float savings_acc = 220; //Least Accurate
            double credit_acc = 12.2; //Mid Accurate
            decimal investment_acc = 35.2M;//Most Accurate
            bool smart_program = false;

            //User Input
            Console.Write("Enter your name: ");
            string user_name = Console.ReadLine();
            Console.WriteLine($"Hi {user_name}");

            //Converting String to Integer
            int num = Convert.ToInt32("45");
            Console.WriteLine(num + 5);

            //Building a calculator
            Console.Write("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter another number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(num1 + num2);

            //Arrays
            int [] luckyNumber = {12, 43, 65, 745, 1242, 64, 2343};
            string [] friends = new string[10]; //Telling C# that this array can fit 10 values
            Console.WriteLine(luckyNumber[2]);

            //Methods (Without Return)
            static void SayHi(string user_name){
                Console.WriteLine("Hello " + user_name);
            }

            SayHi(user_name);

            //Methods (With Return)
            static int cube(int num){
                int result = num * num * num;
                return result;
            }

            Console.WriteLine(cube(5));

            //if statements
            bool isMale = false;
            bool isFat = false;

            if (isMale && isFat) {
                Console.WriteLine("You are male and fat");
            } else if (isMale && !isFat){
                Console.WriteLine("You are male and not fat");
            } else {
                Console.WriteLine("You are female");
            }

            //Switch Statement
            static string GetDay(int dayNum) {
                string dayName;

                switch (dayNum){
                    case 0:
                        dayName = "Sunday";
                        break;
                    case 1:
                        dayName = "Monday";
                        break;
                    case 2:
                        dayName = "Tuesday";
                        break;
                    default:
                        dayName = "Invalid Day Number";
                        break;
                }
                return dayName;
            }

            Console.WriteLine(GetDay(80));

            //While Loop (Checks the condition and Executes the code in the loop)
            int index = 1;
            while (index <= 5){
                Console.WriteLine(index);
                index++;
            }

            //Do While Loop (Executes the code in the loop and checks the condition afterwards)
            int index1 = 8;
            do{
                Console.WriteLine(index1);
                index1++;
            }while (index1 <= 5);

            //For Loop
            for (int i = 1; i <= 5; i++){
                Console.WriteLine(i);
            }

            //Exponent Function (A function that passes two numbers (base num & power num) -> 2^3 = 9)
            Console.WriteLine(GetPow(3, 2));

            static int GetPow(int baseNum, int powNum) {
                int result = 1;

                //Keep looping until a less than powNum, E.g. if powNum = 5, for loop will loop 5 times...
                for (int a = 0; a < powNum; a++) {

                    //First loop - set result to baseNum, subsequent loops - baseNum is multipled by baseNum
                    result = result * baseNum;
                }

                return result;
            }

            //2Dimensional (2D) Arrays 
            int [,] numberGrid = {
                //All arrays need to be off the same length, otherwise error will be displayed
                {2, 4, 6},
                {1, 3, 5},
                {7, 9, 11}
            };

            //Manually setting an array to have three columns and four rows.
            int [,] myArray = new int[3,4];

            Console.WriteLine(numberGrid[1,2]);

            //Exception Handling
            try {
                Console.WriteLine("Enter a number: ");
                int num10 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter another number: ");
                int num11 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(num10/num11);
            }

            catch (DivideByZeroException e) {
                Console.WriteLine(e.Message);
            }

            catch (FormatException e) {
                Console.WriteLine(e.Message);
            }

            finally {
                //Executes code even though program may encounter an error
            }

            //Classes, Objects, Constructors
            Book book1 = new Book("Harry Potter & The Sorcerer's Stone", "JK Rowling", 345);
            Book book2 = new Book("Geronimo Stilton", "Stilton HK", 125);

            Console.WriteLine(book1.author);
            Console.WriteLine(book2.pages);

            //Object Methods
            Student student1 = new Student("Tan Kah Kee", "History", 3.8);
            Student student2 = new Student("Irfan Armandi", "Engineering", 2.4);
            Student student3 = new Student("Kellie Yeow", "BioChemistry", 2.9);

            Console.WriteLine(student1.HasHonors());
            Console.WriteLine(student2.HasHonors());
            Console.WriteLine(student3.HasHonors());

            //Getters & Setters (Making attributes more secure)
            Movie movie1 = new Movie("Avengers: End Game", "Wes Anderson", "R");
            Movie movie2 = new Movie("Ready Player One", "Adam Armstrong", "PG");
            Movie movie3 = new Movie("Jurassic World: World Dominion", "Steven Spielberg", "PG-13");

            //Static Class Attributes
            Song holiday = new Song("Holiday","Green Day", 200);
            Console.WriteLine(Song.songCount);
            Song kasmir = new Song("Kashmir", "Led Zeppelin", 150);
            Console.WriteLine(Song.songCount);

            //Static Methods & Classes - The static method belongs to the class and thus is not required to create an instance of the class
             UsefulTools.SayHi("Mike");

            //Inheritance - Same attributes inherited from Chef, just different Classes
            Chef chef = new Chef(); //<--Super Class
            chef.MakeChicken(); //<--Super Class

            ItalianChef italianChef = new ItalianChef(); //<--Sub Class
            italianChef.MakeChicken(); //<--Sub Class

            italianChef.MakePasta(); //<--Able to access method since it is created ItalianChef class
            /*chef.MakePasta();*/ //<--Unable to access method since it is not inside Chef class

            italianChef.MakeSpecialDish(); //Result: The Chef makes chicken parm
            chef.MakeSpecialDish(); //Result: The chef makes BBQ ribs


            Console.ReadLine();
        }
    }
}