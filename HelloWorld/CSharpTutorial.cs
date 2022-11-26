using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    
    class CSharpTutorial
    {
        //OVERFLOWING
        /*
            byte number = 255;

        So we know that 255 is the highest number we can store in a byte
        
        if we increase the number by 1 [ number = number + 1 ;] we get 0 zero at this point overflow has occured.

        There is no error checking for overflow in c# so if we want to check for overflow we use the "checked" keyword.

            checked{
                byte number = 255;
                number = number + 1;
            }
        */


        //DEMO VARIABLES AND CONSTANT   
        /*
            PS:  Take heed that you cannot access a variable without the variable being initialized.  Eg.
                    >>  byte number;
                        Console.WriteLine(number);                  This is not correct and you might experience compile time error

            Press Ctrl + Shift + b  To compile application.

            Press Ctrl + F5 to run the application

            
            PS:  To open the 'OBJECT BROWSER' OR to see the classes or fields in a datatype(ie. char, int, bool)
                 Hover the mouse on the datatype, Press Ctrl and Click.

            PS:  To easy delete a line of code, make sure the cusor is on the line of codes and
                 Press Ctrl + Delete

            PlaceHolders
                >> Console.WriteLine( "{0} {1}" byte.MaxValue, byte.MinValue);

                    >> float totalPrice = 20.95;
            PS: That C# compiler treats real numbers as if they are double so the above code will throw a compile time error
                
        */



        //TYPE CONVERSION
        /*
            IMPLICIT -- suggested | Not Clearly stated
            EXPLICIT -- stated clearly and in detail.
            

            Implicit Type Conversion example
            byte b = 1;             a byte is 8 bits (0000000)  an integer is 4 byte (00000000  00000000  00000000  00000000) 
            int i = b;              byte can be converted to int as there would be no data loss.


            Explicit Type Conversion sample
            int i = 1;      int is 4 bytes -- a byte is 8 bits.  When we convert this to byte, three byte out of 4 will be lost. IE. there is a chance for data loss.
            byte b = i;         once the compiler realise there's chance for a data loss, it wont compile.  to tell the compiler we understand the risk, we cast it
                                    by prefixing the variable with the target type EG.
                                                >>  float f = 1.0f;
                                                >>  int i = (int)f;

            Incompactible Types
            in some cases we may need to convert incompactible types and explicit will not be allowed for instance conert string to int
            WE CANT
            string s = "1";
            int i = (int)s;                             we cant use explicit conversion

            In situstion like that, we use the "Convert" class or the "Parse" method.

            eg - int i = Convert.ToInt32(s);
                            OR
                 int j = int.Parse(s);
        */

        //OPERATORS
        /*
            C# has only 5 types of operators
            Arithemetic Operators                   Add, Subtract,Mult,Divide, Remainder, Increment (++), Decrement (--) {+, -, /, *, %, ++, --}
                                                    PostFix Increment (variable++)  eg int a = 1;
                                                                                       int b = a++;   At this juncture(a++), first the value of a is added to b,
                                                                                                      and the a is incremented by 1
                                                                                                      RESULT ----   a=2, b=1

                                                    Prefix Increment (++variable)  eg int a =1;
                                                                                      int b = ++a;    At this juncture(++a), first a is incremented by 1 and
                                                                                                      then it is assigned to b
                                                                                                      RESULT ----  a=2, b=2      
                                                    NOTE: Arithemetic presidence
                                                          Please note that in computation, c# solves mathematics with (BODMAS Rule)                                                  
                                                                                              
            Comarison Operators                     

            Assignment Operators                    OPERATOR        EXAMPLE
                                                       =              a = 1;
                                                       +=             a += 3        same as {a = a + 3;}
                                                       -=             a -= 3
                                                       *=             a *= 3
                                                       /=             a /= 3

            Logical Operators                       { && (means 'and'), || (means 'OR'), ! (means 'not') }
                                                    NOTE: Please note that when we have a trick condition like this
                                                    (    Console.WriteLine(!(a != b));   )
                                                    where a=1 and b=2
                                                    the result is false.  It is read like this, the boolean will return 'true' for the operation (a != b),
                                                    then this (!()) operation will negate it making it false
            Bitwise Operators.
        */


        //CLASSES
        /*
            When you create a class with the 'new' operator eg          Person ebuka = new Person();
            you're allocating memory to that object.

                CREATING STATIC METHODS
                When we make a method in a class stsic, we make it accessible outside that class, without the need to occupy memory like when we create a new class

                NOTE:  we use static modifier when we want represent a concept that only a single instance of that should exist in memory.
                
                       when we create for instance three object of a class, each objects occupy an allocated memory.  and when we make some of the
                       methods in the class static, we make that method useable without the need allocte memory before accessing the method.



                SHORTCUT TO CREATE A NEW CLASS FILE

                In a present c# file (this is if you want to create the class file in the present class namespace), 
                    >> Put the cursor on the typed class name ,
                    >> Press Alt + Enter
                    >> Select the Move to "filename".cs  */

        //ARRAYS
        /*      
                Array is a data structure used to store a collection of variables of the same type

                Declaring Array
                    >> int[] Numbers = new int[3];
                    >> Numbers[0] = 1;
                    >> Numbers[1] = 2;
                    >> Numbers[2] = 3;

                            OR

                    >> int[] Numbers = new int[3] {1,2,3};
                            OR
                    >> var Numbers = new int[3]{1,2,3};
        */


        //STRINGS
        /*
            A string is a sequence of characters

                CREATING STRINGS
                Using String Literals        --------          >> string firstname = "Ebuka";

                Using String Concatenation   -------           >> string name = firstname + " " + lastname;

                Using String Formats         -------           >> string name = stiring.Format("{0} {1}", fName, lName);

                Sometimes we might have an array of objects.  we can create a string from combining all elements of that array using a seperator
                    >>  string list = string.Join(",", numbers);


                string name = "Vitus";

                char FirstChar = name[0];

                NOTE:   Plese Note
                        Strings are immutable
                        IE. once you create tham, you cannot change them


                VERBATIM STRINGS
                string path = "c:\\projects\\project1\\folder1";

                    INSTEAD USE THIS

                string path = @"c:\projects\project1\folder1";
        */

        //ENUMS
        /*
            An enum is a datatype that represents a set of 'name/value' pairs.
                
            When declaring constants,  eg.
            const int RegularAirMail = 1;
            const int RegisteredAirMail = 2;
            const int Express = 3;

            if the constants are related, use enums

            public enum ShippingMethod{
                RegularAirMail=1,
                RegisteredAirMail=2,
                Express=3
            } 

            var method = ShippingMethod.Express;

            Use enums where we have related constants


            NOTE:  Enums are internally integers to change them to byte (maybe for easy mapping to database) specify 'byte' during declaration

            public enum ShippingMethod : byte
            {
                RegularAirMail=1,
                RegisteredAirMail=2,
                Express=3
            } 

            Define enums at namespace level, ie before the declaration of class

            //if we want to see the numeric value of the enum we cast it to integer (as enums are internally integers)
            Console.WriteLine((int)method);

            So lets say we receive a variable for anywhere with a value and we want to convert that value back to our enum to know that enum it is.
                >> int sample = 2;
                >> Console.WriteLine((ShippingMethod)sample);
        */


        //REFERENCE TYPES AND VALUE TYPES
        /*
            In C# there are two main types 


            STRUCTURES -> (primitive types, custom structures)   --  VALUE TYPES          [Memory allocation done automatically, Allocation on stack, immediately removed when out of scope]

            CLASSES    -> (Arrays, Strings, custom classes)      --  REFERENCE TYPES      [You need to allocate memory, Memory allocated on heap, Garbage(used memory) collected/cleaned by CLR


                            DIFFERENCE BETWEEN VALUE TYPES AND REFERENCE TYPES

                            When you copy an 'object' to a new variable, eg.
                                var anotherObject = someObject;

                            depending on wether that object is a value type or reference type, there will be two different outcomes.

                            For instance, in the following array object(which is a reference type)
        */


        //CONDITIONAL STATEMENTS
        /*
            In C# there are three types of conditional state
                1 if/else statements,
                2 switch/case statments,
                3 Conditional operator : a?b:c       which is basically a short way of writing 'if/else'

            we already know about if/else

            NOTE: using resharper. To select use (CTRL + W) to select
            
            See Main progrm for use and explanation of Conditional Ooperator
        */


        //SWITCH CASE
        // See Main.Cs for use on switch cases.


        //ARRAYS
        /*
            An array represents a fixed number of variables of a particular type.

                                    TYPES OF ARRAYS
                           1.   Single Dimension Arrays
                           2.   Multi-Dimension Arrays

            Single Dimension Arrays are the normal arrays we've seen before
                eg.     var numbers = new int[5] {1,2,3,4,5};
            

            There are two types of Multi-Dimension Arrays in C#
                                    TYPES OF MULTI DIMENSION ARRAYS

                            1.  Rectangular Arrays                                                      0   1   2   3   4   5
                                                                                                        0   1   2   3   4   5
                                                                                                        0   1   2   3   4   5

                            
                            2.  Jagged Arrays                                                           0   1   2   3
                                                                                                        0   1   2   3   4   5
                                                                                                        0   1   2

                            
        In Rectangular arrry, each row has the exact amount of columns as drawn above.
        In Jagged array, the number of column in each row can be different.            You can think of the jagged array above as a single dimension array with three
                                                                                            elements and each elements is another single dimension array.


        When it comes to arrays, DOTNET is optimied around single dimension arrays.  It's better to use the jagged array

                                    SYNTAX
        The following is the syntax for declaring a 2D Rectangular array
            var matriix = new int [3, 5]            The '3' and '5' are the dimensions of array and can be read as: This array has '3' rows and '5' columns
            
            if we know the values we want in the array, we can implement it like this;
            
            var matrix = new int [3,5] 
            {
                {1,2,3,4,5},
                {6,7,8,9,10},
                {11,12,13,14,15}    
            } 

            we access an element in the array by supplying the index eg
            var element = matrix[0,0];


        The following is the syntax for declaring a jagged array
            var array = new int [3] [];

            Now we need to initialize each element of this array to a different array
            
            array[0] = new int[4];
            array[1] = new int[5];
            array[2] = new int[3];

            To access an element in this type of array, we supply two square bracket
            array[0] [0] = 1;





        ARRAY IMPLEMENTATION

        //FIRST WE  CREATE A SINGLE DIMENSIONAL ARRAY

        {
            var numbers = new int[]{ 3, 7,  9,  2,  14, 6};

            //find out the length of the array using 
               var length = numbers.Length;

            //IndexOf()  known as the indexof method, we use this method to find the position of an element in the array
            // lets say we want ot search for '9' in the numbers array
                var index = Array.IndexOf(numbers, 9);


            //Clear()       known as the clear method
                    //Note: in the parenthesis of the 'clear' method, the first argument supplied is the name/variable name of the array followed by the ranges of elements
                            you'll want to clear (ie. the starting index and number of length)

                    var clear = Array.Clear(numbers, 0, 2);

                    //you can iterate over the array to see changes
                    foreach(var number in numbers)
                    {
                        console.writeline(number);
                    }

                    //NOTE: clearing an array of type 'int' means setting it to 0
                                                      'string' means setting the items to null
                                                      'boolean' means setting the items to false


            //Copy()        known as the copy method
                    //we use this method to copy an element in an array to another element in the same array or another array
                    //in the argument of the copy array, first, we supply the source array, then the destination, followed by the element to copy

                    // for example we declare another array

                    var another = new int[3];

                    //we are going to copy the first three elements from the numbers array to 'another' array
                    var copy = Array.Copy(numbers, another, 3);
                    

            //Sort()        known as the sort method
                    //we use this method to sort an array the way we want.
                     var sort = Array.Sort(numbers);

            //Reverse()     known as the reverse method
                    var reverse = Array.Reverse(numbers);
        }
        */



        //LISTS
        //  List is similar to array in a sense that it's a data structure for storing a number of objects of the same type
        //  we use a list when we dont know how many objects we are going to store in that list.
        //  To create a list we use the list type
        //      var numbers = new List<int>();          or
        //      var numbers = new List<int>() { 1,  2,  3,  4,  5};
        /*
                USEFUL LISTS METHODS
                Add()                                   to add an object to the list
                AddRange()                              to add alist of objects (eg. anoother list or an array)   eg    numbers.AddRange(new int[3] {11,45,23,78});
                Remove()                                to remoeve one object from the list                 eg.  numbers.Remove(2)
                RemoveAt()                              this removes the object at the given index
                IndexOf()                               return the index of the given object                    eg  numbers.IndexOf(78);
                LastIndexOf()                           returns the last index if a given object (if you suspect it's duplicated)    eg   numbers.LastIndexOf(45);
                Contains()                              this tell us if the list contains the given object
                Count()                                 which returns the number of objects in a list.              eg. numbers.Count;


                NOTE:  Never modify a collection using a foreach loop   example
                                foreach(var number in numbers)
                                {
                                    if(number == 1)
                                    {
                                        numbers.Remove(number):
                                    }
                                }

                        The above statement will return an error. rather use a for loop
                                for(var i=0; i< numbers.Count; i++)
                                {
                                    if(numbers[i] == 1)
                                    {
                                        numbers.Remove(numbers[i]);
                                    }
                                }


        */



        //DATETIME

        //DATETIME is a structure defined in System namespace
        /*
            DATETIME has a number of constructors, you can specify various info you need or want to set

            var date = new DateTime(2015,12,24);

            You can get the current datetime using 
            var date = Datetime.Now;

            If you need just the date and not the tim you can set it like this,
            var date = DateTime.Today;

            
            Once you have a datetime object, you can access its components like (YEAR, MONTH, DAY, MINUTE, HOUR ETC)
            Example
                var date = Datetime.Now;
                COnsole.WriteLine("Hour: " + now.Hour ) ;
                COnsole.WriteLine("Minute: " + now.Minute ) ;

            DateTime Objects in c# are immutable ie. once you create them, we cannot change them.  However, we can modify them with a bunch of methods that start with
            'ADD'.  
            eg  
                now.Add();
                now.AddDays(1);                     This returns tommorrows............. we can go back too  [var yesterday = now.AddDays(-1);]
                now.AddHours();
                now.AddMilliseconds()
                now.AddSeconds();
                now.AddTicks();       and so on.............


            FORMATING A DATIME TO A STRING
            ------------------------------
            Datetime objects has a bunch of methods for converting it to a date or time string
            EG.                                 
                                                                              RETURNS
                Console.WriteLine(now.ToLongDateString());                                          Saturday, 23 May 2022
                Console.WriteLine(now.ToShortDateString());                                               23/09/2022
                Console.WriteLine(now.ToLongTimeString());                                                  12:43:21 pm
                Console.WriteLine(now.ToShortTimeString());                                                 12:44 pm
                                                If you want to return both date and time, we use ToString() method
                                                    var dateAndTime = now.ToString();     returns       23/09/2022 12:43:21 pm

                                                We can also specify the format for the ToString() when we type [ToString("")] we get
                                                intellisense of many formats we can use. For now we use [ToString("yyyy-MM-dd HH:mm")]
                                                    To get more specifiers go to google [ "c# datetime format specifier" ]    
        */

        //TIMESPAN

        //DateTime represents date and time value
        //TimeSpan represents a length of time.  
        /*
            When declaring Timespan please note that it has multiple useable constructors
            
            we use the constructor which takes hour, minutes and seconds
            var timeSpan = new TimeSpan(1, 2, 3);

            if we dont have a value for minutes and seconds, we can just pass zero
            var timeSpan2 = new TimeSpan(1, 0, 0);

            
            Sometimes the value in the parenthesis of the TimeSpan object is not understood or its uses known,  we can write a more readable code by
            using TimeSpan static methods that start with the prefir 'From'

            we can have 
            TimeSpan.FromDays
            TimeSpan.FromHours
            TimeSpan.FromMilliseconds
            TimeSpan.FromMinutes
            TimeSpan.FromSeconds
            TimeSpan.FromTicks   etc

            For now we use 

            var timeSpan3 = TimeSpan.FromHours(1);





            There is also a third way to create a timespan.  If you have two DateTime Objects and subtract them, the result, is a TimeSpan.

            Eg.
            var start = DateTime.Now;
            var end = DateTime.AddMinutes(2);
            var duration = end - start;

            the above code returns a timespan in the case, the result is TWO MINUTES



            Now once we have a timeSpan object, we can read its properties.
            NOTE: each timespan has aa number of properties that comes in pairs

            To understand, 
            a timespan may have properties like [   timeSpan3 = TimeSpan.'Hours'();   ]    The hours there is a property

            but the timespan also has paired properties that start with 'total' eg
            timeSpan3.TotalDays;
            timeSpan3.TotalHours;
            timeSpan3.TotalMilliseconds;
            timeSpan3.TotalMinutes;
            timeSpan3.TotalSeconds;

            to understand the difference, we use the first variable declared in this timespan sample 
            we can say
            Console.WriteLine("Minutes: " + timeSpan.Minutes);      //This returns the minute component of the timespan object
            Console.WriteLine("Total Minutes: " + timeSpan.TotalMinutes);  // this converts all the timespan components(hours,minutes,seconds) to minutes and returns the total minutes

            




            Similarly to the datetime object, the timespan object is immutable ie. once you create it, you cannot change it. but it provides a couple of methods
            to modify its value ('ADD' and 'SUBTRACT')
            Both these methods ('add' and 'subtract') returns a new TimeSpan

            The Add or Subtract methods takes a parameter of type timespan.  So we can create another timespan by using the new operator or 
            (recomended) we use the timespan static methods of FromMinutes,FromSeconds....etc and make our changes.

            //we use the first variable timespan as example

            timespan = timespan.Add(TimeSpan.FromMinutes(8));           //here we add 8 minutes to our original timespan.

            //the subtect method uses the same syntax 


            CONVERTING TIMESPAN TO AND FROM STRING
            To convert timespan to string we simply call the ToString() method on the timespan variable
            but we can pass the timespan variable just like that to the console.Writeline() method because the writeline() method automatically calls the ToString()Method.
                var timeSpan2 = timeSpan.ToString();
                Console.WriteLine(timeSpan);

            To convert from a string, we use the Parse method
                var timeSpan = TimeSpan.Parse("01:02:04");
        */





        //STRINGS
        //Strings is a class.  Strings are immutable, ie. once you create them, you cannot change them.
        /*
            FORMATING
            When formatting a string you can use the following method
            ToLower()       
            ToUpper()
            Trim();     //this is used to get rid of whitespaces around a string. [this is important when you capture user inputs]

            Array.Sort(place array here)  OR ArrayHere.Sort()  to sort an array in ascending order.     To sort an array in descdnding order use
            Array.Reverse(place array here).

            SEARCHING
            If you want to search for a character or a string inside a given string use;
            IndexOf('a')                    OR
            LastIndexOf("Hello")                                            //both these methods have overloads and they accept char or strings and they return
                                                                              an index of the 'first' or last 'occurence' of the given char or string

            SUBSTRINGS
            If you want to create a substring from a given string, you use the substring method
            the methods has a couple of overloads 
            Substring(startIndex)
            [one that takes a start index and then retrieves all the characters from that point to the end of the string]

            Substring(startIndex, length)
            the other takes a 'startIndex' and 'length' argument to limit the number of characters to retreive.

            
            REPLACING
            Replace('a', '!')
            Replace("mosh", "moshheamedani")
            if you want to replace a given character or a given substring in your string use the replace method 

            
            SPLITING STRINGS
            str.Split(' ')
            if you want to split a string use the split method 
            in the above example, we're splitting using an empty character.  That means if we have a sentence/string with multiple words, since there is an empty
            character btw these words, they will all be split and whet will be RETURNED FROM THIS METHOD IS AN ARRAY OF STRINGS with each element containing a word


            CONVERTING STRINGS TO NUMBERS
            we can use 'int.parse()' or 'Convert.To32Int()' to convert string to numbers
            it is best to use the Convert.Toint32 0r 64 () method.  this is because, if the input is null or invalid, this method returns zero while
            int.Parse throws an exception
            string s ="1234"
            var i = int.Parse(s);
            var j = Convert.ToInt32(s);      ---->>  RECOMMENDED

            
            CONVERTING NUMBERS TO STRINGS
            Also we can convert to string by calling the ToString() method on the variable/object
            int i = 1234;
            string s = i.ToString();

            we can format the string to the format of a currency
                        string s = i.ToString("C");     returns    //   "$1,234.00"

            use the 'C0' c-zero format to remove the decimals
                        string s = i.ToString("C0");    returns   //"$1,234"

            Google string formats in c# to get more ways to format strings
        */


        //STRING BUILDER
        //String builder makes it easier and fast to create and manipulate strings
        //The StringBuilder is not optimised for searching [ ie no (IndexOf(), LastIndexOf(), Contains(), StartsWith() ) etc]     instead it provides useful
        //methods for manipulating strings eg [ Append(), Insert(), Remove(), Replace(), Clear()  etc]



        //NOTE: The string class is immutable ie. once created, you cannot change its content.  Use String Builder when you have a lot opf maniuplations to 
        //be done on a string.   String builder makes it easier and fast to create and manipulate strings on the go

        //NOTE: In a normal string variable, when you perform operations like Appepnd(), Remove(); etc, all the methods, creates a new string object in the memory
        //but the string builder does not.
        /*
            >>  var builder = new StringBuilder();              (another sample [ var builder = new StringBuilder("Hello World"); ])
            >>  builder.Append('-', 10);     //this add the '-' symbol 10 times
            >>  builder.AppendLine()        // this add a new line
                    we can also state it like this

                builder.Append("Header")
                       .AppendLine()        //Note no semicolon
                       .Append('-', 10);

                builder.Replace('-','+');

                builder.Remove(0, 10);          //this removes from the index of zero till ten
                builder.Insert(0, new string('-', 10) );

            >>  Console.WriteLine(builder);
            >>  Console.WriteLine("First Char : " + builder[0]         //we can use indexer to access individual characters in a string
                       .

        */
    }
}
