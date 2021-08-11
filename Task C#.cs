using System;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main()
        {

            //Find Perimeter of a circle:

            //            double r, per_circ;
            //            double PI = 3.14;
            //
            //            r = Convert.ToDouble(Console.ReadLine());
            //            per_circ = 2 * PI * r;
            //
            //            Console.WriteLine("Perimeter of Circle: {0}", per_circ);
            //--------------------------------------------------------------------------------
            //Program that takes two numbers as input and perform an operation (+,-,*,/) on then and displays the result of that operation.
            //int i, j;
            //char operation;

            //Console.WriteLine("Input first number:");
            //i = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Input operation:");
            //operation = Convert.ToChar(Console.ReadLine());
            //Console.Write("Input second number:");
            //j = Convert.ToInt32(Console.ReadLine());

            //if (operation == '+')
            //    Console.WriteLine("{0} + {1} = {2}", i, j, i + j);
            //else if (operation == '-')
            //    Console.WriteLine("{0} - {1} = {2}", i, j, i - j);
            //else if (operation == '*')
            //    Console.WriteLine("{0} * {1} = {2}", i, j, i * j);
            //else if (operation == '/')
            //    Console.WriteLine("{0} / {1} = {2}", i, j, i / j);
            //------------------------------------------------------------------------------------------------
            //string username, password;
            //int loginAttempts = 0;
            //do
            //{
            //    Console.WriteLine("Type UserName: ");
            //    username = Console.ReadLine();

            //    Console.WriteLine("Type password: ");
            //    password = Console.ReadLine();

            //    if (username != "admin" || password != "admin")
            //    loginAttempts++;
            //    else
            //        loginAttempts = 1;
            //}
            //while ((username != "admin" || password != "123456") && (loginAttempts != 3));

            //if (loginAttempts == 3)
            //    Console.WriteLine("\nLogin failed!\n");
            //else
            //    Console.WriteLine("\nCorrect!\n");
            //--------------------------------------------------------------------------------------------------------
            //Print the Sum of two numbers:
            //        int sum;
            //        sum = x + y;
            //        return sum;
            //    }
            //public static void Main()
            //{
            //    Console.WriteLine("Input first number: ");
            //    int x = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Input second number: ");
            //    int y = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("\nThe sum is: {0}\n", Sum(x, y));
            //-------------------------------------------------------------------------------------
            //Print the result of the specified operations:
            //System.Console.WriteLine(-1 + 4 * 6);
            //System.Console.WriteLine((35 + 5) % 7);
            //System.Console.WriteLine(14 + -4 * 6 / 11);
            //System.Console.WriteLine(2 + 15 / 6 * 1 - 7 % 2);
            //---------------------------------------------------------------------------------------
            //The first 10 natural numbers          
            //int i;

            //for (i = 1; i <= 10; i++)
            //{
            //    Console.Write("{0} ", i);
            //}
            //int i;
            //int Sum;
            //-----------------------------------------------------------------------
            //Sum of first 10 natural numbers

            //int i; int sum = 0;

            //Console.WriteLine("The first 10 natural number is:");

            //for (i = 1; i <= 10; i++)
            //{
            //    Console.Write("{0} ", i);
            //    sum = sum + i;
            //}
            //{
            //    Console.Write("\nThe sum is: {0}\n", sum);
            //}
            //-----------------------------------------------------------------------------
            //Display n terms of natural number and their sum:

            //Console.WriteLine("The first 7 natural number is: ");

            //for (i = 1; i <= 7; i++)
            //{
            //    Console.Write("{0}", i);
            //    sum += i;
            //}

            //Console.WriteLine("\nThe sum of natural number upto 7 terms: {0}\n ", sum);
            //---------------------------------------------------------------------------------------
            //Display the cube of the number:

            //int n=5;
            //int cube;

            //for (int i = 1; i <= n; i++)
            //{
            //    cube = i * i * i;
            //    Console.WriteLine("The cube of number {0} is={1}", i, cube);
            //}

            //Console.ReadLine();
            //------------------------------------------------------------------------------------
            //Method task 1:

            //int a, b, Sum, Product;


            //Console.WriteLine("Input first number: ");
            //a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Input second number: ");
            //b = Convert.ToInt32(Console.ReadLine());

            //Sum = a + b;
            //Product = a * b;

            //Console.WriteLine("\nSum is:\n" + Sum);
            //Console.WriteLine("\nProduct is:\n" + Product);          

            //---------------------------------------------------------------------------
            //Equal or not:

            //int int1, int2;

            //Console.Write("\nCheck whether two integers are equal or not:\n");

            //Console.Write("Input 1st number: ");
            //int1 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Input 2nd number: ");
            //int2 = Convert.ToInt32(Console.ReadLine());

            //if (int1 == int2)
            //    Console.WriteLine("{0} and {1} are equal.\n", int1, int2);
            //else
            //    Console.WriteLine("{0} and {1} are not equal.\n", int1, int2);
            //----------------------------------------------------------------------------------------------
            //Even or odd:

            //            int i;

            //            Console.Write("\nCheck whether a given number even or odd:\n");

            //            Console.Write("Input number: ");
            //            i = Convert.ToInt32(Console.ReadLine());


            //            if (i%2==0)
            //                Console.WriteLine("{0} is even integer.\n", i);
            //            else
            //                Console.WriteLine("{0} is odd integer.\n", i);
            //------------------------------------------------------------------------------------------
            //Positive or negative:

            //int i;

            //Console.Write("\nCheck whether a given number positive or negative:\n");

            //Console.Write("Input number: ");
            //i = Convert.ToInt32(Console.ReadLine());


            //if (i > 0)
            //    Console.WriteLine("{0} is positive.\n", i);
            //else
            //    Console.WriteLine("{0} is negative.\n", i);
            //----------------------------------------------------------------------------------------------
            //Eligible or not:

            //int i;

            //Console.Write("\nCheck and, find out that you eligible for casting your own vote or not:\n");

            //Console.Write("Enter your age: ");
            //i = Convert.ToInt32(Console.ReadLine());


            //if (i>=18)
            //    Console.WriteLine("Congratulation! Your are eligible for casting your vote.\n", i);
            //else
            //    Console.WriteLine("Sorry. You are not eligible for casting your vote", i);

            //-------------------------------------------------------------------------------------------
            //Multiplication table:

            //int j, a;


            //Console.Write("Display the multiplication table:\n");

            //Console.Write("Input the number (Table to be calculated) : ");
            //a = Convert.ToInt32(Console.ReadLine());
            //Console.Write("\n");
            //for (j = 1; j <= 10; j++)
            //{
            //    Console.Write("{0} X {1} = {2} \n", a, j, a * j);
            //}

            //-------------------------------------------------------------------------------------------
            //The largest of three numbers:

            //int n1, n2, n3;

            //Console.Write("Find the largest of three numbers:\n");


            //Console.Write("Input the first number :");
            //n1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Input the second number :");
            //n2 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Input the third  number :");
            //n3 = Convert.ToInt32(Console.ReadLine());

            //if (n1 > n2)
            //{
            //    if (n1 > n3)
            //    {
            //        Console.Write("The fist Number is the greatest among three. ");
            //    }
            //    else
            //    {
            //        Console.Write("The third Number is the greatest among three. ");
            //    }
            //}
            //else if (n2 > n3)
            //    Console.Write("The second Number is the greatest among three ");
            //else
            //    Console.Write("The third Number is the greatest among three ");

            //--------------------------------------------------------------------------------------------
            //
            //Display the multiplication table:
           

            //int j, a;


            //Console.Write("Display the multiplication table:\n");

            //Console.Write("Input the number (Table to be calculated) : ");
            //a = Convert.ToInt32(Console.ReadLine());
            //Console.Write("\n");
            //for (j = 1; j <= 10; j++)
            //{
            //    Console.Write("{0} X {1} = {2} \n", a, j, a * j);
            //}

        }
    }
}

