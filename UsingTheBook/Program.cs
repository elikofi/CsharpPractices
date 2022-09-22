/* Printing out all prime numbers from 1 to 100 */


//for (int i = 2; i <= 100; i++)
//{
//    bool isPrimeNumber = true;

//    for (int j = 2; j < i; j++)
//    {
//        if (i % j == 0)
//        {
//            isPrimeNumber = false;
//            break;
//        }
//    }
//    if (isPrimeNumber)
//    {
//        Console.WriteLine(i);
//    }
//}












/* Write a program that checks if a given number n (1 < n < 100) is a prime number */

//Console.Write("Enter a number:");
//int a = int.Parse(Console.ReadLine());

//int divisor = 1;
//for (int i = 2; i < 100; i++)
//{
//    if (a % i == 0)
//    {
//        divisor++;
//    }
//}
//if (divisor == 2)
//{
//    Console.WriteLine(a + " is prime");
//}
//else
//{
//    Console.WriteLine("is not prime");
//}














/*             find sum of numbers from 1 to n                     */

//Console.WriteLine("Enter a number:");
//int n = Convert.ToInt32(Console.ReadLine());

//// all numbers below n
//int number = 1;

//int sum = 1;

//while (number < n)
//{
//    number++;
//    sum += number;
//}
//Console.WriteLine(sum);











/*      find the product of all numbers in the range a and b     */


//Console.WriteLine("Enter first number: a ");
//int a = int.Parse(Console.ReadLine());

//Console.WriteLine("Enter second number: b ");
//int b = int.Parse(Console.ReadLine());

//int number = a;
//long product = 1;

//do
//{
//    product = product * number;
//    number++;
//} while (number <= b);

//Console.WriteLine($"The products of numbers between {a} and {b} is = {product}");

//Console.WriteLine("Enter first number: a ");
//int a = int.Parse(Console.ReadLine());

//Console.WriteLine("Enter second number: b ");
//int b = int.Parse(Console.ReadLine());
//long product = 1;

//for (int i = a; i <= b; i++)
//{
//    product *= i;
//}
//Console.WriteLine(product);










/*           PROGRAM TO RAISE THE POWER OF N TO M             */

//Console.WriteLine("n =");
//int n = int.Parse(Console.ReadLine());

//Console.WriteLine("m =");
//int m = int.Parse(Console.ReadLine());

//double outcome = 1;

//for (int i = 0; i < m; i++)
//{
//    outcome *= n;
//}
//Console.WriteLine(outcome);










/*         calculate the sum of all odd numbers in the range [1...n], which are not divisible by 7 by using the for-loop */

//Console.WriteLine("Enter the number:");
//int n = int.Parse(Console.ReadLine());
//int sum = 0;
//for (int i = 1; i <= n; i+=2)
//{
//    if (i % 7 == 0)
//    {
//        continue;
//    }
//    sum += i;
//}
//Console.WriteLine(sum);










/* TRIANGLE WITH NESTED FOR LOOPS */

//int n = int.Parse(Console.ReadLine());

//for (int row = 1; row <= n; row++)
//{
//    for (int col = 1; col <= row; col++)
//    {
//        Console.Write(col + " ");
//    }
//    Console.WriteLine();
//}








/*           print on the console all prime numbers in the interval [n...m].       */


//Console.Write("n = ");
//int n = int.Parse(Console.ReadLine());

//Console.Write("m = ");
//int m = int.Parse(Console.ReadLine());

//for (int num = n; num <= m; num++)
//{
//    bool prime = true;
//    int divider = 2;
//    int maxDivider = (int)Math.Sqrt(num);
//    while (divider <= maxDivider)
//    {
//        if (num % divider == 0)
//        {
//            prime = false;
//            break;
//        }
//        divider++;
//    }
//    if (prime)
//    {
//        Console.Write(" " + num);
//    }
//}








/* reversing an array   */

//int[] array = { 1, 2, 3, 4, 5 };
//Array.Reverse(array);

//foreach (int arr in array)
//{
//    Console.WriteLine(arr);
//}







/* doubling the numbers in an array */
//int[] array = new int[] { 1, 2, 3, 4, 5 };

//for (int i = 0; i < array.Length; i++)
//{
//    array[i] = 2 * array[i];

//    Console.WriteLine(array[i]);
//}











/* MULTI DIMENSIONAL ARRAYS. */

//int[,] matrix ={
//    {1, 2, 3, 4},
//    {5, 6, 7, 8}, };

//for (int row = 0; row < matrix.GetLength(0); row++)
//{
//    for (int col = 0; col < matrix.GetLength(1); col++)
//    {
//        Console.Write(matrix[row, col]);
//    }
//    Console.WriteLine();
//}










//int[][] myJaggedArray = {
//   new int[] {5, 7, 2},
//   new int[] {10, 20, 40},
//   new int[] {3, 25}
//};


//using System;
//class Triangle
//{
//    static void Main()
//    {
//        // Entering the value of the variable n
//        Console.Write("n = ");
//        int n = int.Parse(Console.ReadLine()); Console.WriteLine();
//        // Printing the upper part of the triangle
//        for (int line = 1; line <= n; line++)
//        {
//            PrintLine(1, line);
//        }
//        // Printing the bottom part of the triangle // that is under the longest line
//        for (int line = n - 1; line >= 1; line--)
//        {
//            PrintLine(1, line);
//        }
//    }


//    static void PrintLine(int start, int end)
//    {
//        for (int i = start; i <= end; i++)
//        {
//            Console.Write(i + " ");
//        }
//        Console.WriteLine();
//    }
//}



//for (int i = 2; i < 100; i++)
//{
//    bool isPrime = true;
//    for (int j = 2; j < i; j++)
//    {
//        if (i % j == 0)
//        {
//            isPrime = false;
//            break;
//        }
//    }
//    if (isPrime)
//    {
//        Console.WriteLine(i);
//    }
//}

//Console.ReadLine();







//Console.WriteLine("Enter a number: ");
//double num1 = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine("Enter a number: ");
//double num2 = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine(FinalAnswer(num1, num2));
//Console.ReadLine();


//static double FinalAnswer(double num1, double num2)
//{
//    double finalAnswer = num1 * num2;
//    return finalAnswer;
//}







// method of strings.




//concat
//string sentence = "This is the main reason why we don't go";

//string full = string.Concat(sentence, " the house.");

//Console.WriteLine();
//Console.ReadLine();



/* Converting string to a list of characters*/

//string name = "Elijah Kofi";
//char[] nameChar = name.ToCharArray();
//foreach (char item in nameChar)
//{
//    Console.WriteLine(item);
//}
//Console.ReadLine();


/*Converting a list of characters to string. */

//char[] ch = new char[3];

//ch[0] = 'E';
//ch[1] = 'l';
//ch[2] = 'i';

//string name = string.Concat(ch);

//Console.WriteLine(name);
//Console.ReadLine();



/* here, we are finding all prime numbers between n and m*/


//Console.WriteLine("enter a number");
//int n = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Enter a higher number:");
//int m = Convert.ToInt32(Console.ReadLine());


//for (int i = n; i < m; i++)
//{
//    bool prime = true;
//    for (int j = n; j < i; j++)
//    {
//        if (i % j == 0)
//        {
//            prime = false;
//        }
//    }
//    if (prime)
//    {
//        Console.WriteLine(i);
//    }
//}Console.ReadLine();






//Console.WriteLine("Enter a number to check if it is prime.");
//int n = Convert.ToInt32(Console.ReadLine());

//int divisor = 1;
//for (int i = 2; i < 100; i++)
//{

//    if (n % i == 0)
//    {
//        divisor++;
//    }
//}

//if (divisor == 2)
//{
//    Console.WriteLine(n + "is prime.");
//}
//else
//{
//    Console.WriteLine(n + "is not prime.");
//}
//Console.Read();


using System.Text;

static string GetRandomPassword(int length)
{
    const string chars = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";

    StringBuilder sb = new StringBuilder();
    Random rnd = new Random();

    for (int i = 0; i < length; i++)
    {
        int index = rnd.Next(chars.Length);
        sb.Append(chars[index]);
    }

    return sb.ToString();
}

int length = 10;

string password = GetRandomPassword(length);
Console.WriteLine(password);

Console.ReadLine();