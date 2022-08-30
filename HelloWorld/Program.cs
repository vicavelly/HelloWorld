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


            Console.WriteLine("Array and List Excercises");

            //Array Reverse
            

            var numbers = new List<int>();


            while ( numbers.Count() < 5)
            {
                Console.WriteLine("Please input a number:");
                var input = Console.ReadLine();

                

                if (numbers.Contains(Int32.Parse(input)))
                {
                    Console.WriteLine("Error:  Plese Try again.");
                }
                else
                {
                    numbers.Add(Int32.Parse(input)); 
                }
            }

             numbers.Sort();

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.ReadLine();

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
