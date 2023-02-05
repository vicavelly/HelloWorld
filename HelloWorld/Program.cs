using System;
    using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HelloWorld
{
    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }

    public enum Seasons
    {
        Autumn,
        Fall,
        Winter
    }
    class Program
    {
        static void Main(string[] args)
        {
            ////Arithemetic operators
            //Int32 a = 10;
            //Int32 b = 3;

            ////to see our results in floating numbers we cast both variable to float
            //Console.WriteLine((float)a / b);

            //string path = "c:\\projects\\project1\\folder1";
            //const string path2 = @"c:\projects\project1\folder1";
            //Console.WriteLine(path);
            //Console.WriteLine(path2);





            ////Enums
            //var method = ShippingMethod.Express;
            //Console.WriteLine(method);
            ////if we want to see the numeric value of the enum we cast it to integer (as enums are internally integers)
            //Console.WriteLine((int)method);
            //Console.ReadLine();

            //int sample = 2;
            //Console.WriteLine((ShippingMethod)sample);





            ////Conditional Operator
            //bool isGoldCustomer = true;

            //float price;

            //if (isGoldCustomer)
            //{
            //    price = 19.96f;
            //}
            //else
            //{
            //    price = 29.95f;
            //}

            ////to rewrite the above if/else statement using Conditional Operator
            //float price2 = (isGoldCustomer) ? 19.96f : 29.95f;





            ////SWITCH CASE
            //var season = Seasons.Autumn;

            //switch (season)
            //{
            //    case Seasons.Autumn:
            //        Console.WriteLine("Perfect time for the beach!");
            //        break;

            //    case Seasons.Fall:
            //        Console.WriteLine("We gonna pick a lot of flowers this season!");
            //        break;

            //    default:
            //        Console.WriteLine("Put on your winter Jackets");
            //        break;


            //        //                 OR
            //        //           We can do the following if we want multiple cases to have same answer

            //        /*
            //                     case Seasons.Autumn:
            //                     case Seasons.Fall:
            //                         Console.WriteLine("We gonna pick a lot of flowers this season!");
            //                         break;

            //                     default:
            //                         Console.WriteLine("Put on your winter Jackets");
            //                         break;
            //         */
            //}



            ////WHILE LOOP
            ////The following is a continuous while loop (ie. a loop that runs forever except we issue the break statement)

            //while (true)
            //{
            //    Console.Write("Type your name: ");
            //    var input = Console.ReadLine();

            //    //check is input is empty
            //    if (!String.IsNullOrWhiteSpace(input))
            //    {
            //        Console.WriteLine("@Echo: " + input);
            //        //now we issue the 'continue' statement.  Please Note that when the 'continue' statement is called, it starts from the beginning of the loop again.
            //        continue;
            //    }

            //    break;
            //}


            //Console.WriteLine("Array and List Excercises");

            ////Array Reverse
            

            //var numbers = new List<int>();


            //while ( numbers.Count() < 5)
            //{
            //    Console.WriteLine("Please input a number:");
            //    var input = Console.ReadLine();

                

            //    if (numbers.Contains(Int32.Parse(input)))
            //    {
            //        Console.WriteLine("Error:  Plese Try again.");
            //    }
            //    else
            //    {
            //        numbers.Add(Int32.Parse(input)); 
            //    }
            //}

            // numbers.Sort();

            //foreach (var number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //Console.ReadLine();




            //STRINGS MANUPULATIONS
            var fullname = "Chukwuebuka Emmanuel Vitus ";
            //always remember to trim inputs so as to remove the whitespaces about them.
            Console.WriteLine(fullname.Trim().ToUpper());

            //to split strings, use the 'split' method for simpler computation but use the 'IndexOf' method for complex ones

            var index = fullname.IndexOf(' ');      //we supplied empty character/space as we want from the fist occurence of spaces to split the strings,  we can supply a char if we wish
            //now we get the firstname 
            var fname = fullname.Substring(0, index);   //zero is the starting index(ie the beginning of the string) [the next argument is to what extent do we want the string(which to the next space or empty string)]
            var mname = fullname.Substring(index + 1);
            Console.WriteLine("FirstName: {0}", fname);
            Console.WriteLine("LastName: {0}", mname);

            //THE SPLIT METHOD
            var names = fullname.Split(' '); //the result of this is an array.  now we can access it as an elements
            Console.WriteLine("Firstname: {0}", names[0]);
            Console.WriteLine("Middlename: {0}", names[1]);
            Console.WriteLine("Lastname: {0}", names[2]);

            //REPLACE METHOD
            var replaceFirName = fullname.Replace("ebu", "eme");
            Console.WriteLine("Fullname: {0}", replaceFirName);     //always remember to Trim inuts  


            //WORDS SUMMARISER
            var sentence = "This is going to be a very very very very very very very very very very long text";

            //we should never use magic numbers but instead constants
            //we get a const for the maximum number of words
            const int maxSentenceNumber = 20;

            //algorithm
            if (sentence.Length < maxSentenceNumber)
            {
                Console.WriteLine(sentence);
            }
            else
            {
                //first we slpit the words.  the split method returns an array (in this case, a string array)
                var words = sentence.Split(' ');

                //the following is used to hold the selected summarised words
                var summaryWords = new List<string>();

                //the follwoing var is used to hold the total characters/spaces counted during loop
                var totalCharacters = 0;

                foreach (var word in words)
                {
                    summaryWords.Add(word);

                    totalCharacters += word.Length + 1;

                    if (totalCharacters > maxSentenceNumber)
                    {
                        break;
                    }
                }

                var summary = String.Join(" ", summaryWords) + " .....";
                Console.WriteLine(summary);
            }
        }























        public class Person
        {
            public string FName;
            public string Lname;

            public void Introduce()
            {
                Console.WriteLine("My Name is {0} and my surname is {1}",FName,Lname);
            }
        }
    }
}
