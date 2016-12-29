
// hello world
/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace HelloWorld
    {

    class Program
        {
            static void Main(string[] args)
            {
                System.Console.WriteLine("Hello World");
                for (int i = 0; i < 5; i++)
                {
                    System.Console.WriteLine(i);   
                }

                }
        }
    }

*/

/*
 * ////////// basic class and method
using System;
namespace StaticTester
{
    class Tester
    {
        public void Run ()
        {
            Console.WriteLine("Hello World");
        }
        static void Main()
        {
            Tester t= new Tester();
            t.Run();
        }
    }
}

 */

//assign variable
/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Example_3_3_Definite_assignment
{
    class Values
    {
        static void Main( )
        {
        int myInt;
        //other code here...
        myInt = 7; // assign to it
        System.Console.WriteLine("Assigned, myInt: {0}", myInt);
        myInt = 5;
        System.Console.WriteLine("Reassigned, myInt: {0}", myInt);
        }
    }
}
*/
// example 3.2  variables in string {0} {1} {2}
////////////////////////////////////////////////////////////////////////////////////////////////////
/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Example_3_2_Definite_Assignment
{
class Values
{
static void Main( )
{
int myInt;
myInt = 7;
    System.Console.WriteLine("Initialized, myInt: {0}", myInt);
myInt = 5;
System.Console.WriteLine("After assignment, myInt: {0}", myInt);
}
}
}
*/
//exercise 3.1 variables in string  {0} {1} {2}
////////////////////////////////////////////////////////////////////////////////////////////////////
/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace exercise_3_1_Definite_Assignment
{
class Values
{
static void Main( )
{
    int myInt=42;
    float myFloat=98.6f;
    double myDouble=12345.6789;
    char myChar='Z';
    string myString="The brown fox jumped";
    System.Console.WriteLine("myInt= {0} myFloat= {1} myDouble= {2} myChar= {3} myString= {4}", myInt, myFloat, myDouble,myChar, myString);
    
    myInt = 25;
    myFloat = 100.3f;
    myDouble = 98765.4321;
    myChar = 'M';
    myString = "A quick movement of the enemy";

    System.Console.WriteLine("myInt= {0} myFloat= {1} myDouble= {2} myChar= {3} myString= {4}", myInt, myFloat, myDouble, myChar, myString);
}
}
}
*/

/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Exercise_3_4_Definite_Assignment
{
    class Values
    {
        enum Months {Jan=1, Feb=2, March=3 };

        static void Main()
        {
           System.Console.WriteLine("March is the {0} month", (int) Months.March);
          }
    }
}*/

/*
//exercise 4.1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace exercise_4_1_operators
{
    class Values
    {
        static void Main()
        {
            int myX = 25;
            int myY = 5;
            System.Console.WriteLine("myX devided by myY= {0}", myX/myY);
            System.Console.WriteLine("myX plus by myY= {0}", myX + myY);
            System.Console.WriteLine("myX minus by myY= {0}", myX - myY);
            System.Console.WriteLine("myX remonder by myY= {0}", myX % myY);
            System.Console.WriteLine("myX multiplied by myY= {0}", myX * myY);
        }
    }
}
*/
//exercise 4.3
/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace exercise_4_3_operators
{
    class Values
    {
        static void Main()
        {
            const int MinW=100;
            const int MaxW = 300;
            
            int Abby = 135;
            int Bob = 175;
            int Charlie = 55;
            int Dawn = 45;


            int ridersTotalW;

            ridersTotalW=Abby+Bob;

            System.Console.WriteLine("Can Abby and Bob ride togehter? {0}", ridersTotalW < MaxW && ridersTotalW>MinW);

            ridersTotalW = Charlie + Bob;
            System.Console.WriteLine("Can Charlie and Bob ride togehter? {0}", ridersTotalW < MaxW && ridersTotalW > MinW);
  
            ridersTotalW = Charlie + Dawn;
            System.Console.WriteLine("Can Charlie and Dawn ride togehter? {0}", ridersTotalW < MaxW && ridersTotalW > MinW);
  
        }
    }
}
*/
/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace exercise_4_4_operators
{
    class Values
    {
        static void Main()
        {
            const int Radius = 5;
            const float Pi = 3.14159f;

            float surface = 4* Pi * Radius*Radius;
            float volume = (4/3)*Pi*Radius*Radius*Radius;


 
            System.Console.WriteLine("suface is: {0}. volume is: {1}. which is bigger? {2}",surface, volume, surface>volume?"surface":"volume");


        }
    }
}

*/
// for statement
////////////////////////////////////////////////////////////////////////////////////////////////////
/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace exercise_5_1
{
    class Values
    {
        static void Main()
        {

            for (int counter1=1; counter1<=3;counter1++)
            {
                for (int counter2 = 1; counter2 <= 10; counter2++)
                {
                    Console.WriteLine(counter2);
                }
            Console.WriteLine("that was counter {0}\n",counter1);
            }
        }
    }
}
*/
//while statement
////////////////////////////////////////////////////////////////////////////////////////////////////
/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace exercise_5_1
{
    class Values
    {
        static void Main()
        {
            int counter1=1;
            int counter2=1;

            while (counter1<=3)
            {
                while (counter2 <= 10)
                {
                    Console.WriteLine(counter2);
                    counter2++;
                }
            Console.WriteLine("that was counter {0}\n",counter1);
            counter2 = 1;
            counter1++;
            }
        }
    }
}
*/
// if statement
////////////////////////////////////////////////////////////////////////////////////////////////////
/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace exercise_5_2
{
    class Values
    {
        static void Main()
        {
            int inputString;
            inputString = int.Parse( Console.ReadLine());

            if (inputString>100)
                Console.WriteLine("INPUT STRING IS GREATER THAN 100");
            else
                if (inputString==0)
                    Console.WriteLine("INPUT STRING IS 0");

            if (inputString % 2 == 1)
                Console.WriteLine("input string is an odd number");
            else
            {
                Console.WriteLine("input string is an even number");
                if (inputString%10==0)
                    Console.WriteLine("input string is a multiple of 10:");
            }
         }
     }
}
*/


// swtich statement
////////////////////////////////////////////////////////////////////////////////////////////////////
/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Exercise_5_3
{
    class Program
    {
        enum numericCondition
        {
            even,
            multiple,
            odd,
            tooBig,
            unknown,
            zero
        }

        static void Main()
        {
            while (true)
            {
                Console.Write("Enter a number, please: ");

                string theEntry = Console.ReadLine();
                int theNumber = Convert.ToInt32(theEntry);

                numericCondition condition = numericCondition.unknown; // initialize
                condition = (theNumber % 2 == 0) ?
                    numericCondition.even : numericCondition.odd;
                if (theNumber % 10 == 0) condition = numericCondition.multiple;
                if (theNumber == 0) condition = numericCondition.zero;
                if (theNumber > 100) condition = numericCondition.tooBig;

                // switch on the condition and display the correct message
                switch (condition)
                {
                    case numericCondition.even:
                        Console.WriteLine("Your number is even");
                        break;
                    case numericCondition.multiple:
                        Console.WriteLine("You have picked a multiple of 10");
                        break;
                    case numericCondition.odd:
                        Console.WriteLine("What an odd number to enter");
                        break;
                    case numericCondition.tooBig:
                        Console.WriteLine("Your number is too big for me.");
                        break;
                    case numericCondition.zero:
                        Console.WriteLine("zero is not even or odd or a multiple of 10");
                        break;
                    default:
                        Console.WriteLine("I'm sorry, I didn't understand that.");
                        break;
                }
            }
        }
    }
}
 */


//in exercise 7.1 we call a class object. methods can be public.
// in exercisse 7.2 call a class without instantiating an object. methods should be static
////////////////////////////////////////////////////////////////////////////////////////////////////
/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace exercise7_1
{

    class Math
    {   private static int XX = 4;
    private static int YY = 2;

    public void Add(int X, int Y)
    {
        System.Console.WriteLine("{0} plus by {1} equals {2}", X, Y, X+Y);

    }

    public void Subtract(int X, int Y)
    {
        System.Console.WriteLine("{0} minus by {1} equals {2}", X, Y, X - Y);

    }

    public void Multiply(int X, int Y)
    {
        System.Console.WriteLine("{0} times by {1} equals {2}", X, Y, X * Y);

    }
        public void Divide(int X, int Y)
        {
            System.Console.WriteLine("{0} divided by {1} equals {2}", X, Y, X / Y);

        }

        class Program
        {

            static void Main()
            {


                Math M = new Math();
                M.Add(XX, YY);
                M.Subtract(XX, YY);
                M.Multiply(XX, YY);
                M.Divide(XX, YY);
            }
        }
    }
}*/
/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

 namespace exercise7_2

{

    class Math
    {
        private static int XX = 4;
        private static int YY = 2;

        static void Add(int X, int Y)
        {
            System.Console.WriteLine("{0} plus by {1} equals {2}", X, Y, X + Y);

        }

        static void Subtract(int X, int Y)
        {
            System.Console.WriteLine("{0} minus by {1} equals {2}", X, Y, X - Y);

        }

        static void Multiply(int X, int Y)
        {
            System.Console.WriteLine("{0} times by {1} equals {2}", X, Y, X * Y);

        }
        static void Divide(int X, int Y)
        {
            System.Console.WriteLine("{0} divided by {1} equals {2}", X, Y, X / Y);

        }

        class Program
        {

            static void Main()
            {
                Math.Add(XX, YY);
                Math.Subtract(XX, YY);
                Math.Multiply(XX, YY);
                Math.Divide(XX, YY);
            }
        }
    }
}

*/
//7.3
//use of constructor
/////////////////////////////////////////////////////////////////////////////////////////
/*
namespace exercise7_3
{

    class Book
    {
        private static string title;
        private static string author;
        private static string publisher="O'Reilly";
        private static string ISBN;

        public void displayBook()
        {
            System.Console.WriteLine("title is {0} , author is {1}, publisher is {2}, ISBN is {3}", title,author,publisher,ISBN);

        }

    //constructor
    public Book (string theTitle, string theAuthor, string theISBN)
        {
        title=theTitle;
        author=theAuthor;
        ISBN=theISBN;
        }


    }

        class Run
        {

            static void Main()
            {

                Book firstB = new Book("Programing C#", "Jesse1","197806");
                firstB.displayBook();
                Book secondB = new Book("Programing D#", "Jesse2", "297806");
                secondB.displayBook();
                Book thirdB = new Book("Programing E#", "Jesse3", "397806");
                thirdB.displayBook();


            }
   }
}

*/
// 7.4
//constructor
////////////////////////////////////////////////////////////////
/*
namespace exercise7_4
{

    class Point
    {
       public static int X;
       public static int Y;
       public static string pointName;

        public void displayXY()
        {
            System.Console.WriteLine("point number {0} x is {1} , y is {2}",pointName, X, Y);

        }

        //constructor
       public Point(int theX, int theY,string thePointName)
        {
            
            X = theX;
            Y = theY;
            pointName = thePointName;
        }


    }

    class Square
    {
        public static int X1;
        public static int Y1;
        private static int X2;
        private static int Y2;
        string pointName1="one";
        public static string pointName2="two";
        public static string pointName3="three";
        public static string pointName4="four";
        public static int length;

        //constructor
        public Square(int thisX, int thisY, int thisLength)
        { 
            X1 = thisX;
            Y1 = thisY;
            length = thisLength;
            X2 = thisX + length;
            Y2 = thisY + length;
        }

        public void displayBox()
        {
            Point PointA = new Point(X1,Y1,pointName1);
            PointA.displayXY();           
            Point PointB = new Point(X2, Y1,pointName2);
            PointB.displayXY(); 
            Point PointC = new Point(X1, Y2,pointName3);
            PointC.displayXY(); 
            Point PointD = new Point(X2, Y2,pointName4);
            PointD.displayXY(); 
        }
    }


    class Run
    {

        static void Main()
        {
            int X = 4;
            int Y = 5;
            int myLength = 3;
            Square mySquare = new Square(X, Y,myLength);
            mySquare.displayBox();

        }
    }
}
*/

//Example A-17. One solution to Exercise 7-4
//create objects in the class. initialize them in the constructor
// the class does not need to have the input parameters. the constructor does
////////////////////////////////////////////////////////////////
/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Exercise_7_4
{
    public class Point
    {
        public int xCoord;
        public int yCoord;

        public void DisplayPoint()
        {
         Console.WriteLine("({0}, {1})", xCoord, yCoord);
        }

        //constructor
        public Point(int x, int y)
        {
        xCoord = x;
        yCoord = y;
        }
    }


public class Square
{
    private Point topLeft;
    private Point topRight;
    private Point bottomRight;
    private Point bottomLeft;
    private int sideLength;

    public void displaySquare()
    {
        Console.WriteLine("The four corners are:");
        topLeft.DisplayPoint();
        topRight.DisplayPoint();
        bottomLeft.DisplayPoint();
        bottomRight.DisplayPoint();
    }

    //constructor
    public Square(Point myPoint, int myLength)
    {
        sideLength = myLength;
        topLeft = myPoint;
        topRight = new Point(topLeft.xCoord + sideLength, topLeft.yCoord);
        bottomLeft = new Point(topLeft.xCoord, topLeft.yCoord + sideLength);
        bottomRight = new Point(topLeft.xCoord + sideLength,topLeft.yCoord + sideLength);
    }

}


class Program
{
    static void Main(string[] args)
    {
        Point startPoint = new Point(3, 3);
        int length = 5;
        Square mySquare = new Square(startPoint, length);
        mySquare.displaySquare();
    }
}
}*/

//exercise 8.1
/// one class with overloading- two methods with the same name, triple, and different parameter types.
/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Exercise_8_1

{
    class Tester
    {
        public void triple(int X)
        {
            int tripleX = 3 * X;
            Console.WriteLine("The triple value of X is {0}", tripleX);
        }

        public void triple(float X)
        {
            float doubleX = 2 * X;
            Console.WriteLine("The double value of X is {0}", doubleX);
        }

        public static void Main()
        {
        int Y=3;
        float Z = 3.5f;
        Tester t = new Tester();
        t.triple(Y);
        t.triple(Z);
        }
    }
}*/

// excercise 8.2
// property and constructor, readline, convert to int
/* two ways to set a value for a variable: 
 * 1. using the constructor. the constructor has an input parameter which insde sets the private variable of the class
 * 2. using a property. inside the property the private variable is set. the client calls the property as if it is member field. 
 */ 

////////////////////////////////////////////////////////////////
/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Exercise_8_2
{
    class Dog
    {
        //private. cannot be accessed outside the class
        private string color="black";
        private int weight;

        //color="black";

        //property
        // client call WeightExposedToClient which set the weight private variable
        public int WeightExposedToClient
        {
            get
            {
                return weight;
            }
            set
            {
                weight = value*2;
            }
        }


        public void displayDogColorAndWeight()
        {
            Console.WriteLine("The dog color is {0} and it's weight is {1}",color,weight);
        }

        //constructor. the client set the weight when creating a new class object
        public Dog(int theWeight)
        {
            weight = theWeight;
          }
    }

    public class myProgram
    {
        public static void Main()
        {
            Console.WriteLine("enter the dog's weight");
            int myDogWeight = Convert.ToInt32(Console.ReadLine());
            Dog marvin = new Dog(myDogWeight);  //you are using the constructor to set the dog's weight
            marvin.displayDogColorAndWeight();
            Console.WriteLine("new weight was set");
            marvin.WeightExposedToClient = 10;   //setting the weight of the dog which is a private variable by calling the property
            marvin.displayDogColorAndWeight();
        }
    }
}*/

// exercise 8.3
//update global value using reference. boolean
/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Exercise_8_3
{
    class Tester
    {
        public void Run(ref int oneInt, bool toDouble)
        {
            if (toDouble== true)
                oneInt = oneInt * 2;
            else
                oneInt = oneInt * 3;
        }

        static void Main()
        {
            int myInt;
            Console.WriteLine("enter an integer to get double and triple");
            myInt=Convert.ToInt32(Console.ReadLine());
            Tester myTester= new Tester();
            myTester.Run(ref myInt,true);
            Console.WriteLine("the double value of oneInt is {0}", myInt);
            myInt = myInt / 2;
            myTester.Run(ref myInt,false);
            Console.WriteLine("the triple value of oneInt is {0}", myInt);

        }
    }
}*/
/*
 //2 classes. calling a method in one class from the other class
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Exercise_8_4
{
        class Multiplier
    {
        public void multiplyIt (int theInt,out int doubleInt, out int tripleInt)
        {
        doubleInt=theInt*2;
        tripleInt=theInt*3;
        }
   }
        class Tester
        {
            private void Run()
            {
                int myInt;
                int doubleInt1;
                int tripleInt1;

                Console.WriteLine("enter an integer to get double and triple");
                myInt = Convert.ToInt32(Console.ReadLine());

                // call a method that is in a different class
                Multiplier M = new Multiplier();
                M.multiplyIt(myInt, out doubleInt1, out tripleInt1);
                Console.WriteLine("double is {0} and triple is {1}", doubleInt1, tripleInt1);
            }


            static void Main()
            {
                Tester myTester = new Tester();
                myTester.Run();
            }
        }
}*/
// one class. to call a method in the same class. using 'out' for parameter so not to initialize it.
/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Exercise_8_4
{
    class Tester
    {
        private void Run()
        {
            int myInt;
            int doubleInt;
            int tripleInt;

            Console.WriteLine("enter an integer to get double and triple");
            myInt = Convert.ToInt32(Console.ReadLine());

            //call a method that is in the same class.
            multiplyIt(myInt, out doubleInt, out tripleInt);
            Console.WriteLine("double is {0} and triple is {1}", doubleInt, tripleInt);
        }

         static void multiplyIt(int myInt, out int doubleInt, out int tripleInt)
            {
                doubleInt = myInt * 2;
                tripleInt = myInt * 3;
            }

        static void Main()
        {
            Tester myTester = new Tester();
            myTester.Run();
        }
    }
}*/

/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Exercise_9_1
{
    class Tester
    {
        public void Run( )
        {
            int myInt = 42;
            float myFloat = 9.685f;
            Console.WriteLine("Before starting: \n value of myInt:{0} \n value of myFloat: {1}", myInt, myFloat);
            // pass the variables by reference
            Multiply( ref myInt, ref myFloat );
            Console.WriteLine("After finishing: \n value of myInt:{0} \n value of myFloat: {1}", myInt, myFloat);
        }

        private static void Multiply (ref int theInt,
        ref float theFloat)
        {
            theInt = theInt * 2;
            theFloat = theFloat *2;
            Divide( ref theInt, ref theFloat);
        }

        private static void Divide (ref int theInt,
        ref float theFloat)
        {
            theInt = theInt / 3;
            theFloat = theFloat / 3;
            Add(ref theInt, ref theFloat);
        }

        public static void Add(ref int theInt,
        ref float theFloat)
        {
            theInt = theInt + theInt;
            theFloat = theFloat + theFloat;
        }

        static void Main( )
        {
            Tester t = new Tester( );
            t.Run( );
        }
    }
}*/
/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Exercise_9_2
{
    class Tester
    {
        public void Run( )
        {
            int myInt = 42;
            float myFloat = 9.685f;
            Console.WriteLine("Before starting: \n value of myInt:{0} \n value of myFloat: {1}", myInt, myFloat);
            // pass the variables by reference
            Multiply( ref myInt, ref myFloat );
            Console.WriteLine("After finishing: \n value of myInt:{0} \n value of myFloat: {1}", myInt, myFloat);
        }

        private static void Multiply (ref int theInt,  ref float theFloat)
        {
            theInt = theInt * 2;
            theFloat = theFloat *2;
            Divide( ref theInt, ref theFloat);
        }

        private static void Divide (ref int theInt, ref float theFloat)
        {
            theInt = theInt * 3;
            theFloat = theFloat * 3;
            Add(ref theInt, ref theFloat);
        }
        public static void Add(ref int theInt,  ref float theFloat)
        {
            theInt = theInt - theInt;
            theFloat = theFloat - theFloat;
        }
        static void Main( )
        {
            Tester t = new Tester( );
            t.Run( );
        }
    }
}*/
/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Exercise_9_3
{
    class Program
    {
        public static int Factorial(int myInt)
        {
            int result = 1;
            for (int i = 1; i <= myInt; i++)
        {
            result = result * i;
    }

    return result;
}

       static void Main( )
        {
            int input = 5;
            Console.WriteLine("{0} factorial is {1}", input, Factorial(input) );
        }
    }
}*/
/*
//arrays. 
 * one way to handle arrays:
1. initializing an array with three mebers. 
 2. set the values of the members of arrays using constructor 
 * 3. use the property to get the values
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Exercise_10_1
{
    class Dog
    {
        //properties
        private int WeightExposed { get; set; }
        private string NameExposed { get; set; }

        //constructor
        public Dog(int weight, string name)
        {
            WeightExposed = weight;
            NameExposed = name;
        }

        public void displayDog()
        {
            Console.WriteLine("the weight of {0} is {1}", NameExposed, WeightExposed);
        }
    }


    public class myProgram
    {
   static void Main()
        {
            Dog[] myDogs= new Dog[3];  // declaring an array called myDogs. each member of the array is a an object of a type Dog. The array has 3 members
            myDogs[0]= new Dog(26,"Milo");  // the values of the first member are 26 and Milo. using the constructor to set the values
            myDogs[1] = new Dog(10, "Frisky"); //using the constructor to set the values
            myDogs[2] = new Dog(50, "Laika");  //using the constructor to set the values
            for (int i=0;i<myDogs.Length;i++)
                myDogs[i].displayDog();

        }

    }
}
*/
/* a different way to handle arrays:
 * 1 first declare three objects of type dog. use the constructor to assign values to the objects
 * 2. then declare an array and store the three dogs in it
 * 3. use the property to get the name and weight for each member of the array
*/
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Exercise_10_1
{
    class Dog
    {
        private int privateWeight;

        //properties
        public int WeightExposed 
        { 
            get
            {
                return privateWeight;
            }
            
            set
            {
              privateWeight = value*10;
            } 
        }

        public string NameExposed { get; set; }

        //constructor
        public Dog(int weight, string name)
        {
            WeightExposed = weight+1;
            NameExposed = name;
        }

    }


    public class myProgram
    {
   static void Main()
        {
           Dog Milo = new Dog(26, "Milo");  // declaring an object of type dog called Milo. using the constructor to set the values
           Dog mySecondDog = new Dog(10, "Frisky"); //using the constructor to set the values
           Dog myThirdDog = new Dog(50, "Laika");  //using the constructor to set the values
           Dog[] myDogs = new Dog[3] {Milo, mySecondDog,myThirdDog} ;  //declaring an array of dogs called myDogs. initializing the members to the three objects we created

            for (int i=0;i<myDogs.Length;i++)
                Console.WriteLine("weight of {0} is {1}",myDogs[i].NameExposed,myDogs[i].WeightExposed);

        }

    }
}*/
//arrays. sort and reverse order
//////////////////////////////////////////////////////////////////////
/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Exercise_10_2
{
    public class myProgram
    {
        static void Main()
        {
             int[] myNumbers = new int[5];

             for (int i = 0; i < myNumbers.Length; i++)
             {
                 Console.WriteLine("Enter number {0}",i+1);
                 myNumbers[i] = Convert.ToInt32(Console.ReadLine());
             }

           Array.Sort(myNumbers);
           Array.Reverse(myNumbers);
           Console.WriteLine("the number sorted:");

           foreach (int j in myNumbers)
                {
                    Console.Write(j);
                    Console.Write(",");
                }
        }

    }
}*/
// two dimentional array
///////////////////////////////////////////////////////////
/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Exercise_10_4
{

    public class myProgram
    {
        static void Main()
        {

            string[,] chessBoard= new string[8,8];
            string reverseRow = "white";
            string reverseColumn;
            int rowNum;
            int columnNum;
 
            for (int i = 0; i < 8; i++)
            {
                if (reverseRow == "white") reverseRow = "black"; else reverseRow = "white";
                reverseColumn = reverseRow;
                for (int j = 0; j < 8; j++)
                {
                    if (reverseColumn == "white") reverseColumn = "black"; else reverseColumn = "white";
                    chessBoard[i,j]=reverseColumn;
                    Console.WriteLine("the name of position {0}, {1} is {2}",i,j,chessBoard[i,j]);


                }
            }
            Console.WriteLine("enter row number from 1 to 8");
            rowNum=Convert.ToInt32((Console.ReadLine()))-1;
            Console.WriteLine("enter column number from 1 to 8");
            columnNum=Convert.ToInt32((Console.ReadLine()))-1;

            
            
            Console.WriteLine("the color of this cell is {0}", chessBoard[rowNum, columnNum]);
        }
   }
}*/

//base and derived class
// the variable phoneType is created in the base class. the constructor of the derived class set the variable
///////////////////////////////////////////////////////////////////////////////
/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Exercise_11_2
{
    public class Telephone
    {
        protected string phoneType;

        public void Ring()
        {
            Console.WriteLine("phone of type {0} is ringing", phoneType);
        }
    }


    public class electronicPhone: Telephone
    {
    
        // constrcutor
        public electronicPhone (string exposedPhoneType)
        {
        phoneType=exposedPhoneType;
        }
    }

    public class myProgram
    {
        static void Main()
        {

            electronicPhone myPhone = new electronicPhone("digital");
            myPhone.Ring();

        }
    }
}*/

//base and derived class. polymorphic method
// using the base constructor in the derived class constructor
// note that the variable in the derived class constructor has to have the same name as the variable in the base class constructor
////////////////////////////////////////////////////////////////////////////////
/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Exercise_11_2
{
    public class Telephone
    {
        protected string phoneType;  //protected variables can be accessed by derived classes

        //base class constructor
        public Telephone(string exposedPhoneType)
        {
            this.phoneType = exposedPhoneType;
        }

        public virtual void Ring()
        {
            Console.WriteLine("phone of type {0} is ringing", phoneType);
        }
    }


    public class electronicPhone: Telephone
    {
        public string electronicPhoneType;

        // constrcutor
        public electronicPhone(string exposedPhoneType)  : base(exposedPhoneType)
        {
            electronicPhoneType=exposedPhoneType;
        }

         public override void Ring()
        {
            Console.WriteLine("overriding the base class. phone of type {0} is ringing", electronicPhoneType);
        }
    }

    public class myProgram
    {
        static void Main()
        {

            electronicPhone myPhone = new electronicPhone("digital");
            myPhone.Ring();

        }
    }
}*/

/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Exercise_11_2
{
    public abstract class Telephone
    {
        protected string phoneType;  //protected variables can be accessed by derived classes

        //base class constructor
        public Telephone(string exposedPhoneType)
        {
            this.phoneType = exposedPhoneType;
        }

        public abstract void Ring();
    }


    public class electronicPhone : Telephone
    {
        public string electronicPhoneType;

        // constrcutor
        public electronicPhone(string exposedPhoneType)
            : base(exposedPhoneType)
        {
            electronicPhoneType = exposedPhoneType;
        }

        public override void Ring()
        {
            Console.WriteLine("overriding the base class. phone of type {0} is ringing", electronicPhoneType);
        }
    }

    public class talkingPhone : Telephone
    {
        public string talkingPhoneType;

        // constrcutor
        public talkingPhone(string exposedPhoneType)
            : base(exposedPhoneType)
        {
            talkingPhoneType = exposedPhoneType;
        }

        public override void Ring()
        {
            Console.WriteLine("overriding the base class. phone of type {0} is ringing", talkingPhoneType);
        }
    }
    public class myProgram
    {
        static void Main()
        {

            electronicPhone myPhone = new electronicPhone("digital");
            talkingPhone myTalkingPhone = new talkingPhone("talking phone");

            myPhone.Ring();
            myTalkingPhone.Ring();
        }
    }
}
*/

// creating an interface
/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Exercise_13_2
{
    interface IConvertible 
    {
        void convertToCSharp(string S);
        void convertToVB(string S);
    }

    public class programTools: IConvertible
    {
        // constructor
        public programTools()
        {
            Console.WriteLine("using my program tools");
        }

        #region IConvertible
             public void convertToCSharp( string inputString)
            {
                Console.WriteLine("converting string {0} to C#",inputString);
            }

            public void convertToVB( string inputString)
            {
                Console.WriteLine("converting string {0} to VB",inputString);
            }
        #endregion

    }

    public class myProgram
    {
        static void Main()
        {
            string stringToConvert="jj";

            programTools myTools= new programTools();
            myTools.convertToCSharp(stringToConvert);
            myTools.convertToVB(stringToConvert);
        }
    }

}*/

//2 interfaces. boolean
/*
 * second interface is extending first interface.
 * second interface has a boolean output.
 */

/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Exercise_13_3
{
    interface IConvertible 
    {
        void convertToCSharp(string S);
        void convertToVB(string S);
    }

    interface ICodeChecker : IConvertible
    {
        bool checkYourCode(string S);
    }

    public class programTools: IConvertible, ICodeChecker
    {
        // constructor
        public programTools()
        {
            Console.WriteLine("using my program tools");
        }

        #region IConvertible
             public void convertToCSharp( string inputString)
            {
                Console.WriteLine("converting string {0} to C#",inputString);
            }

            public void convertToVB( string inputString)
            {
                Console.WriteLine("converting string {0} to VB",inputString);
            }
        #endregion

        #region ICodeChecker
            public  bool checkYourCode(string inputCode)
            {
                Console.WriteLine("checking code");
                return true;
            }
        #endregion
    }

    public class myProgram
    {
        static void Main()
        {
            string stringToConvert="jj";
            string codeToCheck = "this is my code";

            programTools myTools= new programTools();

            myTools.convertToCSharp(stringToConvert);
            myTools.convertToVB(stringToConvert);
            Console.WriteLine("the check for the code was {0}",myTools.checkYourCode(codeToCheck));

        }
    }

}
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Exercise_13_4
{
    interface IConvertible 
    {
        void convertToCSharp(string S);
        void convertToVB(string S);
    }

    interface ICodeChecker : IConvertible
    {
        bool checkYourCode(string S);
    }

    // this class implements the IConvertible interface
    public class programConverter: IConvertible
    {
        // constructor
        public programConverter(int docID)
        {
            Console.WriteLine("creating a program converter object for doc ID {0}", docID);
        }

        #region IConvertible
             public void convertToCSharp( string inputString)
            {
                Console.WriteLine("converting string {0} to C#",inputString);
            }

            public void convertToVB( string inputString)
            {
                Console.WriteLine("converting string {0} to VB",inputString);
            }
        #endregion
    }

    //this class inherits from base class and implement another interface
    public class programConverterAndChecker: programConverter , ICodeChecker
    {
        //constructor
        public programConverterAndChecker(int docID) : base(docID)
        {
            Console.WriteLine("creating a program helper object for docID {0}", docID);
        }
            #region ICodeChecker
            public  bool checkYourCode(string inputCode)
            {
                Console.WriteLine("checking code");
                return true;
            }
        #endregion
    }

    public class myProgram
    {
        static void Main()
        {
           string stringToConvert="jj";
           string codeToCheck = "this is my code";

            //declare an array of program converters with 5 objects
            programConverter[] myConverterArray = new programConverter[5];

            //populating the myConverter array. even objects are programConverter. odd objects are programHelper
            for (int i=0;i<5;i++)
            {
                if (i%2==0)
                {
                    programConverter myConvertorObject=new programConverter(i);
                    myConverterArray[i] = myConvertorObject;
                }
                else
                {
                    programConverterAndChecker myHelperObject = new programConverterAndChecker(i);
                    myConverterArray[i] = myHelperObject;
                }

            }

            //for program converter objects we can call the program converter interface.
            // for programHelper objects we call both program converter interface and programHelper interface
            foreach (programConverter myObject in myConverterArray)
            {
                //using the my converter methods
                myObject.convertToVB(stringToConvert);
                myObject.convertToCSharp(stringToConvert);
                //
                //check to see if the object implements the interface
                if (myObject is ICodeChecker)
                {
                    Console.WriteLine("this is a program converter and checker object. We can use both program converter and program helper methods");

                   // myObject.checkYourCode(codeToCheck);
                    //create a new object and cast the helper interface to it
                  ICodeChecker myHelperObject2 = myObject as ICodeChecker;
                  myHelperObject2.checkYourCode(codeToCheck);

                }
                else
                {
                    Console.WriteLine("this is not a program checker object. We can use only program converter methods1");
                }
            }

       }
    }

}


