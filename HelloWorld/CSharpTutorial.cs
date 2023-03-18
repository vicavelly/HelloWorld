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
                       
        */





        /*
            WORKING WITH FILES
            ------------------
            ------------------

        In the namespace named System.IO is where you'll find the classes that work with files and directories.  The classes that work with files include
            
            File, FileInfo
            Directory, DirectoryInfo
            Path
            
            File, FileInfo,
                The file and FileInfo classes provides methods for creating, copying, deleting, moving, and opening of files.  The differences between File and FileInfo are
                    i.  FileInfo --  Provides Instance methods
                    ii. File     --  provides static methods

                If you're going to perform small operations e.g. (get file attributes) then it's a good practice to use static methods.
                The problem with static methods is that every time its used, some security checking is done by the OS to make sure the current user has access to
                the file.  You see, if you have a large number of operations this affects the performance of your operations.  In this case it's more efficient to 
                create a FileInfo Class and access all its instance methods. This way, security check is done only once during creation of a fileInfo object.

                Some useful methods in this classes
                Create()        --    To create a file
                Copy()          --    
                Delete()
                Exists()        --    To check if a file exists.
                GetAttributes() --    This returns the attributes of the given file
                Move()          --    Move the file around
                ReadAllText()   --    



            Directory, DirectotyInfo
                Very similar to the the above classes
                    i.  Directory       --  provides static methods
                    ii. DirectoryInfo   --  provides instance methods

                Some useful methods in these classes
                CreateDirectory()
                Delete()
                Exists()
                GetCurrentDirectory()   --  This returns where the application is currently sitting
                GetFiles()              --  This returns the files in your directory (you can specify the type(extension) of file needed
                Move()
                GetLogicalDrives()
            
            
            Path
                The path class provides methods to work with a string that contains a file or directory path information

                Some useful methods in this class
                GetDirectoryName()
                GetFileName()
                GetExtension()
                GetTempPath()



        WORKING WITH FILES DEMO

            >>  File.Copy(@"c:\temp\myFile.jpg", @"c:\temp\myFile.jpg", true); 'true' is used to overwrite if the file already exist.
            >>  var path =  @"c:\someFile\pic.jpg";
            >>  File.Delete(path);
            >>  if(File..Exists(path))
                  {
                    ...
                  }
            >>  File.ReadAllText(path)                      if you want to read all the text in a file  (this method returns a string.)


            >>  var fileInfo = new FileInfo(path);
            >>  fileInfo.CopyTo(source, destination);
            >>  fileInfo.Delete(path);
            >>  if(fileInfo.Exists)
                {
                    ....    
                }

        WORKING WITH DIRECTORY AND DIRECTORYINFO CLASS
            
            >>  var path = @"c:\temp\folder1";
            >>  Directory.CreateDirectory(path);
            The next static method 'getFiles' returns a string array and optionally you can paas at least one out of three 3 arguments.
            The first arfgument is the path, followed by search pattern (you can use this to recover specific files in the directory).
            then the third is SearchOptions.  For now, we use 'SearchOptions.AllDirectories'  this performs the required query in the current directory and its sub-directories

            >>  var directories = Directory.GetFiles(path,"*.*", SearchOptions.AllDirectories); the "*.*" specifies to return all files.  You can use "*.sln" to return
            all files with .sln extension.    This returns a IEnumerable

            //use foreach loop to loop throught the returned directories
            foreach(var directory in directories)
            {
                Console.Writeline(directory);
            }

            if you want to check if a directory exist use the Exists() static mathod
            >>  Directory.Exists(path)


            //Now for directoryInfo
            >>  var directoryInfo = new DirectoryInfo(path);
            >>  directoryInfo.GetFiles();                       //get all files in this directory
            >>  directoryInfo.GetDirectories();                 //gets all directories in this directory  


        WORKING WITH THE 'PATH' CLASS
            This class provides a number of methods that makes it easy to work with a string that represents a path and extract different parts of that class
            eg.
            
            >>  var path = @"C:\Projects\CSharpFundamentals\HelloWorld.sln";

            a poor way of getting the extension out of the path string above would be;
                i search for where the dot sign begins
            >>  var dotIndex = path.indexOf('.');
            >>  var extension = path.SubString(dotIndex);
            >>  Console.WriteLine(extension);


            But we dont want to do the above, instead we want to use the PATH class

            //so the get the extension from the path string we use

            //note: this is a static method
            >>  var pathExthesion = Path.GetExtension(path);
            >>  Console.WriteLine(pathExtension);

            //To extract the filename
            >>  var getFileName = Path.GetFileName(path);
            >>  Console.WriteLine(getFileName);

            //To get file name without extension
            >>  var getFileNameNoExtension = Path.GetFileNameWithoutExtension(path);
            >>  Console.WriteLine(getFileNameNoExtension);

            //To get directory name
            >>  var getDirectoryName = Path.GetDirectoryName(path);
            >>  Console.WriteLine(getDirectoryName);
            */


        /*
            DEBUGGING APPLICATIONS
            ----------------------
            ----------------------

        BREAKPOINTS
            Use Breakpoints when debugging
            >> f9
            Use f5 to run the program immediately in debug mode(it instantly runs the code till the first breakpoint.)

            After running the program(while using breakpoints) to 'step-over' or 'run' the next line of code, use f10
            
            Please note when we use f10, we stepOver that line of code Example: if we are on the line code that states >> GetSmallest(numbers, 3);
            and we use f10, we stepover this line of code onto the next line of code.  in order to step into that line of code and see the work going
            on there we use (F11) to stepinto the line of code.
            
            We can drag the yellow arrow to go 'BACK' the line of code we might want to execute. 

            To stepOUT of a method use (SHIFT + F11)

            To stop debugging, use (SHIFT + F5)

            To run the program to the next breakpoint, press F5

            We can delete Breaakpoints manually or we go the the toolbar and select 
            >> Debug > Windows > Breakp[oints      we can disable them or delete (X)  them.

        WATCH WINDOW
            In the ToolBar Go To 
            >> Debug > Windows > Watch > Watch 1

            A window opens up with which we can put the variable which are of interest to us and watch the values it holds at the runtime/debug mode.  That way,
            we wont need to hover our mouse all the time over a variable to find out what's holding at a particular runtime.

        Locals and Autos Windows
            When using the watch windows, it may get a bit tedious to type the name of the variables you might be interested in.  This is where the locals window and
            autos windows comes in.
            The Autos window is just like a watch window but will automatically display list of variables based on where you are (method) in the code.  The downside 
            is that these variable might be much. then we can use the locals window, it will show vaiabls in the current context.
            To use these windows, in the toolbar, go to 
            >> debug > windows > Autos                  OR
            >> debug > windows > Locals

        CALL STACK
            At times when running in debug mode, one might get lost as to how he got to the current debug position as a program may contain many functions.
            In the toolbar GoTo 
            >> Debug > windows > call stack
            a window is opened that shows the order of method that were called from the moment that the application ran up to where you are now.

            The top of the list will be your current location while the bottom will be the starting point
        */


        /*
            INDEXERS
            --------
            --------

            This is a way to access elements in a class that represents a list of values.   
                eg.  array[0] =1;
                     list[0]=1;                         using an indexer, we can access elements in the list/array

            
            Please note, we are not trying to reinvent the wheel of collection/list/array.  
            The need for indexers in a class is because of this;
            A class may be written to retrieve and hold data. For Instance a user details in a cookie file which may hold SOOO MUCH DETAILS.  
            We need indexer in that class to be able to retrieve and set the value using KEY <-> VALUE pairs.   Dictionary - HashTable

            
            WHEN TO USE DICTIONARY AND LIST
            if you need a list and would like to retrieve them using a key/value in the list cupList["serial240"] = 240; use a dictionary, but if you need to retrieve using 
            its index in the collection eg cupList[1] = 2;  use list or array

            To Declare an indexer
            please note:   An indexer is nothing but a property

            >>  public class User
                {
                    public string this [string key]
                    {
                        get{...}
                        set{...}
                    }
                 }



            >>  public class User
                {
                    //now we need a field to store the 'key' <-> 'value' pairs (the data structure we use is a dictionary)
                    private Dictionary<int, string> _dictionary;

                    public User()
                    {
                        _dictionary = new Dictionary<int, string>();
                    }

                    //the indexer           (Resharper shotcut - type 'indexer' + 'Tab' to create an indexer of the class you are in)

                    public string this[int index]
                    {
                        get{ return _dictionary[index]; }
                        set{ _dictionary[index] = value; }
                    }
                    
                }


            Now back in the main program,
            We create an instance of the indexed class User

            >>  static void Main(string[] args)
                {
                    var user = new User();
                    User[23467]= "Vitus C.E.";

                    console.Writeline(User[23467]);
                }
            
        */


        /*
            Class Coupling
            --------------
            --------------


            There are two types of relationships between classes
                1. Inheritance
                2. Composition

            INHERITANCE :  A kind of relationship between two classes that allow one to inherit code from another
                                                Eg.  A 'CAR' is a 'VEHICLE'                             'Is-A' Relationship

            COMPOSITION :  a kind of relationship that allows one to contain the other
                                                Eg.  A CAR has an Engine
        */


        /*
        
            ACCESS MODIFIERS
            ----------------
            ----------------

            PUBLIC          -   Accessible from anywhere
            PRIVATE         -   Accessible only from the class
            PROTECTED       -   Accessible only from the class and its derived classes.
            INTERNAL        -   Accessible only from the same assembly
            PROTECTED INTERNAL - Accessible only from the same assembly or any derived classes
        */

        /*
            CONSTRUCTORS AND INHERITANCE
            ----------------------------
            ----------------------------

            Lets say we have a class (vehicle) with a private field.  this field is initialised in the vehicle class constructor
            >>  public class Vehicle
                {
                    private string _regristrationNumber;
                    public Vehicle (string registrationNumber){
                        _registrationNumber = registrationNumber
                    }
                }

            Let's also say we have another class (car) that inherits from the vehicle class.  This class wont be able to access the _registrationNumber
            field.      For us to have access we may need to change the access modifier to 'Protected'  which mosh advises changes the idea of encapsulation as 
            this field that is supposed not to be accessible is now accessible in another class.

            Another way to have access is to use the base keyword

            >>  public class Car : Vehicle
                {
                    public Car (string registrationNumber) : base (registrationNumber)
                    {
                        
                    }
                }

            when we use the base keyword, its simply a method call to the base class and the method called when we use the base keyword is the constructor
            So we called the base constructor and passed a string to it   base(registrationNumber).         So basically when the Car class is called a string is 
            passed to it which in turn passes the string to the Vehicle class for use.

            Please Note:  The working/code in the base class is implemented first before the derived classs

        */


        /*
            DOWNCASTING AND UPCASTING
            -------------------------
            -------------------------
            This has to do with inheritance
            let's say we have the following classes in place
            public class Shape
            {
                
            }       and

            public class Circle : Shape
            {

            }

            Converting from a derived class to a base class is known as UPCASTING
            SAMPLE:
            Circle circle = new Circle();
            Shape shape = circle; 

            Converting from a base class to a derived class is known as DOWNCASTING
            SAMPLE:
            Shape shape = new Shape();
            Circle circle = shape;         OR   Circle circle = (Circle)shape;

            Imagine we have an object and would like to cast it to another object
            >>  Car car = new Car();
                Shape obj = new Shape();

                we can try casting the shape object to car
                Car car = obj as Car    if the casting is not possible it returns a null so
                if(car != null)
                {
                    ...
                }

                We also have the 'is' keyword.  With the is keyword we can check if an object can be casted to a type
                eg.
                if (obj is Car)
                {
                    //then we cast it
                    Car car = (Car) obj;
                    ...s
                }


            WHY WE NEED TO DOWNCAST OBJECTS
                Lets say we have the following code

            >>  Private void Button_Click(Object sender, RoutedEventsArgs e)
                {
                    ...
                }

            Now at the first parameter of the above function is of type 'Object' called sender   and this is the 'source' or initiator
            of the Button_Click events.

            the problem is, if you type
            >>  sender.             You wont see any intellisense or properties or methods related to the Button Class.  You'll only
                                    see members of the object class.

            This is a common case where we would need to downcast an object.   so we can do the fwllg.

            >>  var button = (Button) sender;

            When you now type [  button.  ]  you'll see that you have access to the members of the button class.




            NOW FOR A BIGGER PROBLEM 
            We cast to the Button Class because we know we are in function that handles the click event of a button.
            What if we don't know?

            Here is a solution.

            This is were we use the 'as' keyword

            >>  var button = sender as Button;                      Next we check if it is null.
            >>  if(button != null)
                {
                    ...
                }

        */

        /*
            BOXING AND UNBOXING
            All types in c# are divided into two categories.          1. Value Type       2. Reference Type

            VALUE TYPES
            -----------
            Value types are stored on the 'stack'  stack is the limited amount of memory allocated to your each thread of your program.
            This space is used to strore simple values like;
            1.  All primitive types : byte, int, float, char, bool as well as the 'struct' type.
            
            values stored in the stack has a short life span.  As soon as the program goes out of the scope '{}' they get 
            kicked out of the memory.
            
            REFERENCE TYPES
            ---------------
            Reference types are stored in the heap (This is a larger amount odf memory).   We use heap to store objects that requires
            a longer life-time. 
            Examples of reference types in c# is basically any classes (Object, Array, String, CustomClass, etc)
            
            Note: 'Object' class is the parent of all classes in c#.  That is all classes inherits the Object class.
            
            Earlier we learnt that we can convert an object reference (class/instance) to its base class, which is any class it inherits from
            Eg.
            >>  Circle circle = new Circle();
                Shape shape = circle;           //This custom 'circle' class inherits from the shape class, that's why the conversion
                                                    is possible
                                                    
            Since the object class is the base class for all classes in .net we can modify the code
            
            >>  object shape = circle;
            
        
            BOXING
            ------
            This is the process of converting a value type instance to an object reference.  In other words, its the conversion of 
            'value types' meant for the 'stack' to reference type (heap)
            Eg.     int num = 10;
                    object objNum = num;            or    object num = 10;
                    so the values are stored in the heap instead of the stack
                    
            UNBOXING
            --------
            This is the opposite of boxing
            Eg.   object obj = 10;
                  int number = (int)obj;               OR          var number = (int)obj; 


            LESSON:  bE AWARE THAT when youre calling method and that method gets an argument of type 'object' be aware that if you pass
                    a value type there, boxing is going to happen.  Boxing has a performance penalty 
        */

        /*
            GENERICS
            --------

            With generics we create a class once and use it multiple times, you see, the traditional way of instantiating a class, for
            instance if a class is used for storing value types,(int, double etc) every time you instantiate, it would have to be boxed
            and this have performance penalty.

            >>  public class GenericList<T>                     ('T' stands for template)
                {
                    public void Add (T value)
                    {

                    }

                    //To Objectify we add an index
                    public T this [int index]
                    {
                        get { throw new NotImplementedException(); }
                    }
                }

            In the main program
            >>  var numbers = new GenericList<int>();

            NOTE: when we try to access the Add Method, you'll notice in the intellisense That the required input is now 'int'
            >>  numbers.Add();

            We can also use the 'genericList' to store a list of books
            >>  var books = new GenericList<Book>();
            NOTE: when we try to access the Add Method, you'll notice in the intellisense That the required input is now 'Book'
            >>  books.Add(new Book());


            So now we have code reuseablility and we dont have that performance penalty 
            Why?  At runtime, our 'genericList' is actually a list of books not a list of objects. so there's no casting or boxing.

            The above codes are the basics of creating a Generic List.  Practically, We would be using generics list instead of creating one.
            To see all generics see in the intellisense when you type
            System.Collections.Generic.


            Stay tuned if you want to create a Generic (i didnt say generic list) for the application you are working on.
            
        
            You see when we created the genericList class we added a '<T>'     public class GenericList<T>
            you see the '<T>' there is a parameter and we could have multiple parameters '<T, T, T>'  for eg. a use case for that will
            be a dictionary.  (A dictionay is a data structure that uses a hashtable to store and retrieve objects) With dictyionary
            we need to specify a 'key' and 'value'  and they can be of any type.
            
            Lets create a dictionary here
            >>  public class GenericDictionary<TKey, TValue>    (Always prefix your parameters with 'T' and give it a meaningful name.)
                {
                    public void Add(TKey, TValue)
                    {
                    }
                }         

            Now we can create a dictionary with letsay 'string' for the key and the 'Book' class for value
            >>  var dictionary = new GenericDictionary<string, Book>();

                dictionary.Add("1234", new Book() );

            Another thing we need to know about generics is 'constraints'
            
            Take a look at the generic class and method declaration You'll see that the 'template' <T> is used to allow whatevere form
            of datatype we want to specify.    
            Sometimes we may want to limit what is being sent.

            Lets say we want to have a method that return the highest number out of two inputs

            NOrmally we would write
            >>  public int Max (int a, int b)
                {
                    return a > b ? a : b;
                }
                but generically,
            >>  public T Max<T> (T FirstValue, T SecondValue)
                {
                    return FirstValue > SecondValue ? FirstValue : SecondValue;
                    
                    // if you write the above return statement just like that you'll get an error because the compiler at this point
                        see 'FirstValue' and 'SecondValue' as an object.  we may need to apply constraints to specify what the variables are.
                                            
                }

            So we write it this way
            Since we are trying to compare the variables it also means they implement the 'IComparable' Interface, so we set a constraint
            using the IComparable Interface and with this we can compare the two objects.
            The IComparable has a method called 'CompareTo()' and with this we can compare the two objects.

            To apply a constraints, we go to the end of the parentheses and add (just like we do with inheritance - just with some  few
            modifications.

            >>  public T Max<T> (T FirstValue, T SecondValue) where T : IComparable            ( Where 'T'  is <->':'    IComparable
                {
                    //return FirstValue > SecondValue ? FirstValue : SecondValue;

                    return FirstValue.CompareTo(SecondValue) > 0 ? FirstValue : SecondValue;
                                         
                }   //Please note that this generic method was created in a non genric class.
                    //WE dont always need to start with a generic class,  likewise we can also move the constraints to the class level

            >>  public class Utilities<T> where T : IComparable
                {
                    public T Max (T FirstValue, T SecondValue)             ( Where 'T'  is <->':'    IComparable
                    {
                        return FirstValue.CompareTo(SecondValue) > 0 ? FirstValue : SecondValue;                
                    }
                }

            There are other types of constraints 
                //  Where T : IComparable               (Here we apply constraints to an interface)
                //  where T : Product                   (Here Product represents a class)
                //  where T : int                       (Here int represents value-type)
                //  where T : new()                     (here new() represents an object that has a default constructor)

            We've seen a constraints with an interface, now let take a look at a constraints with a class

            >>  public class Product
                {
                    public string Title {get;set;}
                    public float Price { get; set; }
                }

            >>  public class DiscountCalculator<TProd> where TProd : Product
                {
                    public float CalculateDiscount(TProd product)
                    {
                        return product.Price;
                    }
                }
            
            Now let's see a constraint for a value type

            in c# value types cannot be null (an 'int' for eg. should have values of 0,1,2.... we can use this class to give our 
                                              value types the ability to be nullable [NOTE: THIS CLASS ALREADY EXIST IN C#] )
            >>  public class Nullable<T> where T : struct
                {
                    private object _value;
                    //we create a default constructor
                    public Nullable()
                    {
                    }

                    //use this constructor to get a value and store it as an object (This is because we want it to be nullable)
                    public Nullable(T value)
                    {
                        _value = value;
                    }


                    //we create another property to check if _value has a value or is null
                    public bool HasValue 
                    { 
                        get { return _value != null } 
                    }

                    public T GetValueOrDefault()
                    {
                        if(HasValue)
                        {
                            // return _value;  (ERROR: This is because the varialbe is still an object we need to unbox it by upcasting
                            return (T)_value;
                        }
                        else
                        {
                            // if it doesnt have a value we return the default of the datatype (int will be zero(0) )
                            return default(T);
                        }
                    }
                }

                In the main program we can check

                >>  var number =    new Nullable<int>(5);
                    Console.WriteLine("Has Value :" + number.HasValue);
                    Console.WriteLine("Value :" + number.GetValueOrDefault);

                >>  var number =    new Nullable<int>();
                    Console.WriteLine("Has Value :" + number.HasValue);
                    Console.WriteLine("Value :" + number.GetValueOrDefault);

                We may need to instantiate an instance of 'T' in in the method/class thats when we use the 'new()' constranit

                >>  public class Utilities<T> where T : IComparable, new()
                    {
                        public void DoSomething(T value)
                        {
                            var obj = new T();
                        }
                    }
        */


        /*
        
            DELEGATES
            ---------
            A delegate is an object/reference that knows how to call a method or a group of method.
            In other words, a delegate is a reference or pointer to a method.

            we can call method directly so why do we need a delegate
            
            WHY?
            ---
            This techniques enables us to create applications that are extensible and flexible

            So lets say we have the following codes in the classes [Photo, PhotoProcessor, PhotoFilter]
                >>  public class Photo
                    {
                        public static Photo Load(string path)
                        {
                            return new Photo();
                        }

                        public void Save()
                        {

                        }
                    }

                >>  public class PhotoFIlter
                    {
                        public void ApplyBrightness(Photo photo)
                        {
                            Console.WriteLine("Applied Brightness!"):
                        }
                        
                        public void ApplyContrast(Photo photo)
                        {
                            Console.WriteLine("Applied Contrast!"):
                        }
                        
                        public void Resize(Photo photo)
                        {
                            Console.WriteLine("Resized Image"):
                        }
                    }


                >>  public class PhotoProcessor
                    {
                        public void Process(string path)
                        {
                            var photo = Photo.Load(path);

                            var filter = new PhotoFilter();

                            filter.ApplyBrightness(photo);
                            filter.ApplyContrast(photo);
                            filter.Resize(photo);

                            photo.Save();
                        }
                    }


            Lets say we have a group of people that wants to use the PhotoProcessor Framework.  The only Problem with this code/framework
            is that the code is not extensible.

            Why?  Here we already have 3 predefined 'filters', What if a developer(for instance) wants to use the framework and apply
                  a new filter. You(the developer) will need to add this undefined filter [The problem is, you'll have to do this 
                  each time, adding a filter, recompiling and deploying]  
            With delegates, we can make the framework extensible such that a developer can create their own filter without relying
            on you(the developer)
            
            To add a delegate, 1st we need to add/define a delegate type.  When defining delegate we need to define the 'signature' of 
            the type of method the delegate would be calling.

                >>  public delegate void PhotoFilterHandler(Photo photo);

            [void PhotoFilterHandler(Photo photo)] this is the signature.  Any method that is void and take Photo as an argument.

            Now in order to make the framework extensible, instead of hardcoding the filters, we're going to pass a delegate to the 
            method and remove the hardcoded 'filter'


                >>  public class PhotoProcessor
                    {
                        public delegate void PhotoFilterHandler(Photo photo);

                        public void Process(string path, PhotoFilterHandler filter)
                        {
                            var photo = Photo.Load(path);

                            //we call it here passing a photo object to it (what it means is that this code does not know what filter
                            // will be applied and it is the responsibility of the client(main program) of this code to define the 
                            // filters they want.
                            filterHandler(photo);

                            photo.Save();
                        }
                    }

            Now in the main program, we instantiate the PhotoProcessor 
                >>  static void Main(string[] args)
                    {
                        var processor = new PhotoProcessor();

                        //we create an instance of the filters class from which we would choose 'filters'
                        var filters = new PhotoFilters();

                        //Now lets create an instance of that delegate called 'PhotoFilterHandler' in PhotoProcessor class
                        //Here also, we set/point the delegate to an action/'filter' of our choice
                        
                        PhotoProcessor.PhotoFilterHandler filterHandler = filters.ApplyBrightness;
                        

                        //we can easily add another filter this way;
                        filterHandler += filters.ApplyContrast;
                        filterHandler += RemoveRedEyeFilter;
        
                        //In our process method of PhotoProcessor, we pass the filter
                        processor.Process("photo.png", filterHandler);  
                    }
                    //Now we can also create filters not predefdined in the filters class
                    static void RemoveRedEyeFilter(Photo filter)
                    {
                        //this method confors withe signature of delegate
                        Console.WriteLine("Removed RedEye"):
                    }




        PLEASE NOTE :     THIS IS THE RECOMENDED AND BEST WAY WHEN WE CHOOSE TO USE DELEGATES

        Instead of creating a custom delegate, we can use one or two of the existing delegates that comes with the DotNet Framework
        In DotNet There are two delegates that are generic and they are 
            1.  Action<>            can take up to 16 parameters and can point to any method that takes any of
                                    these parameters and has void as their return type IE. a method that does not return a value.
            2.  Func<>              used as delegate for method that have expected datatype/class returns

        They are in System.Action    OR System.Func    They both come in two forms one ordinary and another generic form

        DIFFERENCE
        Func -  Points to a method that returns a value             Func<T1,TResult>  TResult - represents the return type
        Action - Points to a method that returns 'void'             Action<T> T represents the Parammeters accepted

        So we change this in our photo processing framework. and instead use generic action delegates

        So in the PhotoProcessor Class
            >>  public class PhotoProcessor
                {
                    public void Process(string path, Action<Photo> filterHandler )
                    {
                        var photo = Photo.Load(path);

                        filterHandler(photo);
                        
                        photo.Save();
                    }
                }

        In the Main Method

            >>  static void Main(string[] args)
                {
                    var processor = new PhotoProcessor();
                    
                    var filters = new PhotoFilters();
                    
                    Action<Photo>  filterHandler = filters.ApplyBrightness;
                       
                    filterHandler += filters.ApplyContrast;
                    filterHandler += RemoveRedEyeFilter;
        
                    processor.Process("photo.png", filterHandler);          
                }
                static void RemoveRedEyeFilter(Photo filter)
                {
                     //this method confors withe signature of delegate
                     Console.WriteLine("Removed RedEye"):
                }

        NOTE:  Use delegates when we have an event design pattern.
        
        */



        //LAMBDA EXPRESSIONS
        /*
        A lambda expression is an anonymous method.  Ie. A method that has no ACCESS MODIFIER, no NAME, no RETRUN STATEMENT.
        We use them for convienience.
        SYNTAX
        args(arguments)  =>  expressions

        lets say we want to method that takes a number and returns the square of that number.

            >>  static int Square(int number)
                {
                    return number * number;
                }
            in the Main method
            >>  static void Main(string[] args)
                {
                    Console.WriteLine(Square(5));
                }

        To put the Square code in the form of lambda expression
            >>  static void Main(string[] args)
                {
                    //using the syntax
                    // args => expression
                    
                    number => number * number;
                }

        The entire square method is now shorter. we didnt have to specify access modifier the complier does that for us

        we need to assign that lambda expression to a delegate (remember that a delegate is a pointer to a method or a group of method)

            >>  static void Main(string[] args)
                {
                    Func<int, int> square = number => number * number;

                    COnsole.WriteLine( square(5) );
                }

        NOTE: If you have more than one argument, place them in a bracket
                Eg. (number, secNumber) => number * number;

        NOTE: If you dont have any argument, place a bracket
                Eg. () => number * number;

        NOTE:  The lambda expression has access to any variable declared in the lambda argument space and also variables declared 
                in the space/scope in which the lambda was declared in
                Eg    {
                        var num = 10;  //the lambda expression can use this variable because its declared in the scope in which the lambda was declared
                        Func<int, int> square = number => number * number;
                      }

        ANOTHER EXAMPLE
        We want to create a method that takes a number and multiples it by another number(constant)
        
            >>  const int factor = 5;
                Func<int, int> multiplier = n => n * factor;

                var result = multiplier(10);

                Console.WriteLine( result );

        ANOTHER EXAMPLE
        Here we have a class called BookRepository and this is responsible for returning a list of books from the database

            >>  public class BookRepository
                {
                    public List<Book> GetBooks()
                    {
                        return new List<Books> 
                        {
                            new Book() { Title = "Title 1", Price = 5 },
                            new Book() { Title = "Title 2", Price = 8 },
                            new Book() { Title = "Title 3", Price = 17 }
                        };
                    }
                }
                 
                Lets say we want to write a code that returns all the books that are cheaper than 10 dollars

                First we write the code without lambda expression and then we will refactor the code with lambda expression

            First, In the main method, lets get the list of books
            >>  static void Main(string[] args)
                {
                    var books =     new BookRepository().GetBooks();
                    
                    books.FindAll()
                }
            When we type 'books. ' in the intellisense we go to the Find methods that are used for filtering and collections, we select FindAll()
            if you look at the argument's intellisense, you'll find that here we need a 'predicate' of type book (a predicate is basically
            a delegate which points to a method that gets a 'book' [for this instance] and returns a boolean value specifying if a given
            condition was satisfied.

            For Example             We are going to create a predicate function and call it 'itsCheaperThan10Dollars'

            >>  static bool isCheaperThan10Dollars(Book book)
                {
                    //return true if book.Price is less that 10 dollars
                    return book.Price < 10;
                }
                The above is what we call a predicate method.  It gets an object of type 'Book' and returns 'true' if a given condition is 
                satisfied.
                
                Now Back to the main method
                static void Main(string[] args)
                {
                    var books =     new BookRepository().GetBooks();
                    
                    //we add it here
                    var cheapBooks = books.FindAll(isCheaperThan10Dollars)

                    //To the the selected books
                    foreach(var book in cheapBooks)
                    {
                        Console.WriteLine(book.Title);
                    }
                }
                in the FIndAll() method, it will iterate the colection(books) and for each book, it will pass that book to the 
                'isCheaperThan10Dollars' method to determine if the condition is satisfied.  If Yes, then it will return that book in
                the list of result.


            NOW TO REFACTOR THE CODE USING LAMBDA EXPRESSION
                
                All we need to do is 
                >>  var cheapBooks = books.FindAll(book => book.Price < 10);
                and that's all.                         Then we remove the method named 'isCheaperThan10Dollars'   The lamda expression
                above does the same work as the predicate below

                
                static bool isCheaperThan10Dollars(Book book)
                {
                    //return true if book.Price is less that 10 dollars
                    return book.Price < 10;
                }                
        */



        /*
        EVENTS AND DELEGATES
        --------------------

        Events is a mechanism for communication between objects.  That means when somethin happens inside an object, it can notify other 
        objects about that. 

        WHY WE NEED EVENTS?
        To help us build loosely-coupled application
        Helps extending applications

        Example
        We have a VideoEncoder Class with one method called 'encode' which encodes a video posted to it.

            >>  public class VideoEncoder
                {
                    public void Encode(Video video)
                    {
                        //Encoding Logic...
                        .....
                        _mailService.Send(new Mail() );     Here when the encoding is done, we send a mail to the owner of the video
                    }
                }
                let's say in the future we may want to send a text message to the video owner.  What we'll need to do is add the extre piece
                of code that does that  - sample
                public class VideoEncoder
                {
                    public void Encode(Video video)
                    {
                        //Encoding Logic...
                        .....
                        _mailService.Send(new Mail() );
                        _messageService.Send( new Text() );
                    }
                }
                The problem here is, because we add this extra piece of code here, Thae encode method changed.  Which means it has to be
                recompiled, includes the Video Encoded.    This ultimately means that any other class that is dependent of the VideoEncoder
                class will have to be recompile and redeployed.  We need to create applications such that when a change is made, the change 
                has little/no effect on the whole application.

                To solve this problem, we can use EVENTS

                The following is what the code will look like after implementing EVENTS
                public class VideoEncoder
                {
                    public void Encode(Video video)
                    {
                        //Encoding Logic...
                        .....
                        OnVideoEncoded();  //the purpose of this method will be to simply notify the subscribers.
                                           //Here this Encode method knows nothing about the mailService or messageService.
                                           //we can add more subscriber in their various classes without making any changes here
                    }
                }

                HOW DOES THE VIDEOENCODER NOTIFY THE SUBSCRIBERS?
                For a publisher class (in this case the VIDEOENCODER) to notify its subscribers, it need to send a message to them (in c#
                practical terms, it means invoking a method in the sunscriber.)
                HOW DOES THE VIDEOENCODER KNOWS WHAT METHOD TO CALL?
                For that to happen, there need to be an agreement/contract between the publisher and subscriber.  This is something they 
                agree upon and this is A METHOD WITH A SPECIFIC SIGNATURE
                below is a typical implementation of a method in a subscirber
                >>  public void OnVideoEncoded(object source, EventArgs e)
                    {
                    }
                    
               The above method is often called eventHandlers and that is the method that is called by the publisher when the EVENT is raised
               
        
               HOW DO WE TELL VIDEOENCODED WHAT METHOD TO CALL?
               This is when a delegate comes in 
                    - Here, a delegate is the agreement between the publisher and subscriber
                    - The delegate here determines the signature of the eventHandler method in the subscriber.


                The following is a complete program implementing - DELEGATES AND EVENTS

                First we have the 'video' class
                >>  public class Video
                    {
                        public string Title { get; set; }  //a basic class with a simple property for the title of a video
                    }

                We also have the vidoe 'encoder' class
                this class has one 'Encode' method that gets the 'video' the encode method displays a message as an alternate to encoding video
                >>  public class VideoEncoder
                    {
                        public void Encode(Video video)
                        {
                            Console.WriteLine("Encoding Video.......");
                            Thread.Sleep(3000);
                        }
                    } 

                Now in the 'Main' program
                static void Main (string[] args)
                {
                    //we instantiate and create Video
                    var video = new Video() { Title = "video 1" };

                    //Then we instantiate the VideoEncoder
                    var videoEncoder = new VideoEncoder;

                    //finally, we call the encode method while passing the video object
                    videoEncoder.Encode(video);
                }

                To give the Encode method the ability to publish an event There are three steps we need to follow
                    1. We need to define a delegate
                    2. We need to define an EVENT based on that delegate
                    3. Raise or publis the event


                >>  public class VideoEncoder
                    {
                      1 //Defining a delegate
                        //By convention in c#, when declaring a delegate for an event, the name would be suffixed with the term 'EventHandler'

                        public delegate void VideoEncodedEventHandler(object source, EventArgs args);

                      2 //Define an event based on that delegate

                        pubic event VideoEncodedEventHandler VideoEncoded;
                        public void Encode(Video video)
                        {
                            Console.WriteLine("Encoding Video.......");
                            Thread.Sleep(3000);

                            OnVideoEncoded();
                        }
                    }
                    
                      3 //To Raise an event
                        //To raise an event, we need a method that's responsible for it
                        //By convention in dotnet, the event publisher method be 'protected', 'virtual', and 'void'
                        //So we just need to call this method in the encode method after all processing to the Encode method is done 
                        //look at the encode method just above

                     protected virtual void OnVideoEncoded()
                     {
                        //we'll start with checking if there's any subscribers
                        if(VideoEncoded != null)
                        {
                            //now we call the event
                            //when we type VideoEncoded(  the intellisense show the parameters needed and they are that which was declared
                            //in the event handler. (object source, EventsArgs args)
                            //as for the parameter 'source' this depends on the source of the event/ OR who's publishing the events
                            //for this 'source', it is the current class OR the current object so we type 'this'

                            //The 'args' is used to send additional data.  Whenever we don't want to send any data for this parameter
                            // we use EventArgs.Empty

                            VideoEncoded(this, EventArgs.Empty);
                        }
                     }
                                
                     The OnVideoEncoded method will notify all subscribers
                                            THAT'S ALL FOR NOW

                    Now to create a couple of subscribers, we go to the main method and create some classes.
                    >>  public class MailService
                        {
                            //now to make this class a subscriber
                            public void OnVideoEncoded(object source, Events)
                            {
                                Console.WriteLine("Sending Email....................");
                            }
                        }
                        //Now we need to subscribe the MailService, we do that in the main method


                    >>  static void Main (string[] args)
                        {
                            var video = new Video() { Title = "video 1" };

                            var videoEncoder = new VideoEncoder;//publisher
                            var mailService = new MailService();//subscriber

                            videoEncoder.videoEncoded += mailService.OnVideoEncoded;    //now subscribed
                                                                                        //Note 'OnVideoEncoded' was pointed to, not a method
                                                                                        //call.  No 'OnVideoEncoded()'                                                                                                                                                                                                                                                                                                                                    


                            videoEncoder.Encode(video);
                        }
                    
                    Now we want to send a reference of the video, so that the subscriber knows what video was encoded.
                    To do that we use a custom class instead of 'EventsArgs'.       That custom class should derive from EventArgs and include
                    any additional data that you'ld like to send to subscribers.

                    So in the publisher class 'VideoEncoder' we create the custom class and ensure it derives from EventsArgs
                    
                    >>  public class VideoEventsArgs : EventsArgs
                        {
                            public Video video { get; set; }
                        }

                    So now in our delegate, instead of putting 'EventsArgs', We type VideoEventArgs

                    >>  public delegate void VideoEncodedEventsHandler(object source, VideoEventsArgs);

                    Also in the publisher virtual method 'OnVideoEncoded' we change

                    First we go back to the encode method (this is because we need details of the video that was encoded) and pass the 
                    video object to the 'protected vitual' method ( OnVideoEncoded() )

                    >>  public void Encode(Video video)
                        {
                            Console.WriteLine("Encoding Video.......");
                            Thread.Sleep(3000);

                            OnVideoEncoded(video);
                        }

                    Then in the method we add a parameter to receive the video object
                    >>   protected virtual void OnVideoEncoded(Video video)
                         {
                            if(VideoEncoded != null)
                            {
                                VideoEncoded(this, new VideoEventsArgs(){ Video = video });
                            }
                         }

                     NOTE:      in all subscribers change the parameter of EventsArgs to VideoEventsArgs   Example
                                                            public class MailService
                                                            {
                                                                public void OnVideoEncoded(object source, VideoEventsArgs e)
                                                                {
                                                                    Console.WriteLine("Sending Email.................... Title: " + e.Video.Title );
                                                                }
                                                            }
          
        
                    This next step is to show us how to acheive the same things above with less code
                    
        
                    Basically, dotnet came up with the idea that "We dont have to create a delegate each time we want to create an event"
                    so they came up with a delegate type called 'EventHandler' and it comes in two forms - a normal form and a generic form
                    
                    1 - EventHandler
                    2 - EventHandler<TEventsArgs>       //TEventsArgs represents the EventsArgs Or CustomEventsArgs parameter passed in the delegate


                    So

                    >>  public event EventHandler<VideoEventsArgs> VideoEncoded;

                    is the same as the codes below
                    
                    >>  public delegate void VideoEncodedEventHandler(object source, EventArgs args);
                    >>  pubic event VideoEncodedEventHandler VideoEncoded;    
                    
                    So if you want to use the new eventHnadler without sending any data/EventArgs use the normal form (ie the one without generic)
                    
                    >>  public event EventHandler VideoEncoded;                                                                                                                                                 
        */


        /*
        EXTENSION METHODS
        -----------------
        -----------------
        Extension method provides us the ability to add methods to an existing class without changing its source codes or creating a new type
        that inherit from it

        Here is an example
        let's say we have a string variable callled 'post' supposedly contains an insane amnount of text eg blog text

            >>  string post = "This is supposed to be an insane amount of text Blah! Blah! Blah!...";

        Let say we want to shorten the words 'post' for user display we can't create a custom class that derives from 'String' class.

        in situations like this, we can use extension methods to add new methods to an existing class.

        so lets say we want to create a string method called 'shorten' to help shorten the words according to how many words we want it to.

            >>  var shortnedPost = post.Shorten(4);

        to create an extension method, we need to create a static class (as per convention)
        Also a goo naming convention for this extension would be to start with the class we're extending 'string' and then add "Extensions"

            >>  public static class StringExtensions
                {
                    //write extension methods here
                }

        now we can create the shorten method 
        As per convention, when creating a extension method, the first argument should always be 'this' followed by the type you're extending
        'String' and then give it a name as below
        
             >>  public static class StringExtensions
                {
                    public static string Shorten(this String str)
                    {
                    }
                }

        Also we want this method to take a parameter of type 'int' called 'numberOfWords'

            >>  public static class StringExtensions
                {
                    public static string Shorten(this String str, int numberOfWord)
                    {
                        if(numberOfWords == 0)
                            return "";

                        var words = str.Split(' ');

                        if(words.Length <= numberOfWords)
                            return str;

                        //the vaariable 'words'at the point in the code is a string array and string array does not have a method called 'take'
                        //the 'take' method here is an extension method by microsoft that can be used in any class that implements IEnumerable
                        //interface and in this case, the string array

                        return string.Join(" ", words.Take(numberOfWords));

                    }
                }

        Now back to our main program. And then we run it.
        */

        /*
        
        LINQ
        ----
        ----

        Language Integrated Query gives the capability to query object.
                To Query objects in memory          -----       LINQ to objects
                to query Databases                  -----       LINQ to entities
                to query XML                        -----       LINQ to XML
                to query ADO.NET DataSets           -----       LINQ to Data Sets

        For this sample we have a simple 'Book' Class
                >>  public classs Book
                    {
                        public string Title { get; set; }
                        public float Price { get; set; }
                    }

        And also we have a 'Book Repository' class which has a method called GetBooks that simulates getting an IEnumerable of Books
                >>  public class BookRepository
                    {
                        public IEnumerable<Book> GetBooks()
                        {
                            return new List<Book>
                            {
                                new Book() {Title = "ADO.Net step by step", Price = 5}, 
                                new Book() {Title = "ASP.NET MVC", Price = 9.99f}, 
                                new Book() {Title = "ASP.NET WEB API", Price = 12}, 
                                new Book() {Title = "C# ADVANCED TOPICS", Price = 7}, 
                                new Book() {Title = "C# ADVANCED TOPICS", Price = 9}, 
                            };
                        }
                    }

        Now for the 'Main' method.  We instantiate the 'BookRepository' and get the list of Books
                >>  public void Main (string[] args)
                    {
                        var books = new BookRepository().GetBooks();
                    }

        Lets say we want a list of books that are cheaper than $10.  The following is what the code will look like if we didnt use LINQ
                >>  public void Main (string[] args)
                    {
                        var books = new BookRepository().GetBooks();

                        //first we create a new list
                        var cheapBooks = new List<Book>();

                        //then we iterate the books collection and add the selected books to the new list
                        foreach(var book in books)
                        {
                            if (book.Price < 10)
                            {
                                cheapBooks.Add(book);
                            }
                        }

                        //since we now have the list of cheap books we can display each one
                        foreach(var cheapbook in cheapbooks)
                        {
                            Console.WriteLine(cheapbook.Title + " " + cheapbook.Price);
                        }
                    }

        The following is what the code will look like if we use LINQ
                >>  public void Main (string[] args)
                    {
                        var books = new BookRepository().GetBooks();

                        //using LINQ
                        //we use 'Where' to filter collections
                        var cheapbooks = books.Where(b => b.Price < 10);

                        //since we now have the list of cheap books we can display each one
                        foreach(var cheapbook in cheapbooks)
                        {
                            Console.WriteLine(cheapbook.Title + " " + cheapbook.Price);
                        }
                    } 

        LINQ also has a method called 'OrderBy' and this is used for sorting collections.  We can say;
                >>  books.OrderBy(b => b.Title);

        LINQ also has one powerful method called 'Select' and this is used for projections/transformations.  lets say we want to iterate 
        the list of books and foreach books we have to convert it to another object OR maybe we want to just want to select one of its
        properties and display as a string.
                >>  books.Select(b => b.Title);

        One thing about LINQ is that you can chain these commands
                >>  book.Where(b => b.Price < 10).OrderBy(b => b.Title).Select(b => b.Title);

        You see, the code just above started as an IEnumerable of 'Book' and because of the 'Select' (which returns strings) statement 
        ended up as IEnumerable of string.  You see, the select statement has TRANSFORMED the object state of books to another state of strings
        and because of that, following statement becomes void.  as the book/cheapbook state has now been transformed to strings 
                >>  foreach(var cheapbook in cheapbooks)
                        {
                            Console.WriteLine(cheapbook.Title + " " + cheapbook.Price); --- void

                            //instead simply display
                            Console.WriteLine(cheapbook);
                        }


        So this syntax of writing LINQ is called LINQ extension methods
                >>  book
                        .Where(b => b.Price < 10)
                        .OrderBy(b => b.Title)
                        .Select(b => b.Title);

        Another syntax to writing LINQ codes is called LINQ query operators
        So we're writing the same codes using query operators
                >>  var cheapbooks = 
                        from b in books
                        where b.Price < 10
                        orderby b.Title
                        select b.Title;
                        //select b;             use this to select 'book' object
                        
        LINQ query operators always start with 'from' and always finish with the 'select' statement 

        if we want to return/search for only one result, we use the 'SingleOrDefault' instead of the 'Where' extension method
                >>  var bookSearch = books.SingleOrDefault(b => b.Title == "ASP.NET MVC");

        Also there is another extension method called 'First' used to get the first object in a collection.
        For instance i want the first instance of a book titled 'C# ADVANCED TOPICS' in the book collection
                >>  var bookSearch = books.First( b => b.Title == "C# ADVANCED TOPICS" );

        Just like the 'Single' extension method,  this method 'First' returns the first occurence or it gives an error.  If you want the 
        statement to return 'null' if it does'nt find a first occurence use 'FirstOrDefault'. 
                >>  var bookSearch = books.FirstOrDefault( b => b.Title == "C# ADVANCED TOPICS" );

        Also, just like we have a 'FirstOrDefault' we also have a 'LastOrDefault' which returns the last occurence of a given statement
                >>  var bookSearch = books.LastOrDefault( b => b.Title == "C# ADVANCED TOPICS" );

        Anothe LINQ extension method are 'Skip()' and 'Take()'.
        The 'Skip(2)'  skips(for instance) the first 2 two records on the collection, while the 'Take(3)' method takes or continues execution
        from the 3rd third object in the collection and these returns an IEnumerable
                >>  var pagedBooks = books.Skip(2).Take(3);
                    foreach (var pagedBook in pagedBooks)
                    {
                        Console.WriteLine(pagedBook.Title);
                    }

        There's is also an extension method called Max used to return the maximum number of a given statement
                >>  var priceCount = books.Max(b => b.Price);
                    Console.WriteLine(priceCount);
                    //likewise we can use the 'Min' method to check which is the cheapest book we have on the collection
                    //Also there's the 'Sum' method which can be used to get the Summation of prices
                    //Also there's the 'Average' method which can be used to get the average of prices

        */
    }
}
