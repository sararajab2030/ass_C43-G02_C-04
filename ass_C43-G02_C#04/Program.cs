// See https://aka.ms/new-console-template for more information

#region Q1
using System;
using System.ComponentModel.Design;
using System.Diagnostics.Metrics;
using System.Diagnostics.Tracing;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

//Console.WriteLine("Please enter the number");
//int X = int.Parse(Console.ReadLine());
//if (X%3==0&&X%4==0)
//{
//    Console.WriteLine("yes");
//}
//else
//{
//    Console.WriteLine("wrong");
//}
#endregion

#region Q2

//int number = int.Parse(Console.ReadLine());

//if(number <0)
//{
//    Console.WriteLine($"{number}:is negative number");
//}
//else
//{
//    Console.WriteLine($"{number}:is positive number");

//}
#endregion

#region Q3
//Console.WriteLine("enter the first number");
//int X1 =int.Parse(Console.ReadLine());

//Console.WriteLine("enter the second number");
//int X2 = int.Parse(Console.ReadLine());

//Console.WriteLine("enter the third number");
//int X3 = int.Parse(Console.ReadLine());

//int max = Math.Max(X1,Math.Max(X2,X3));
//Console.WriteLine($"The Max number:{max}");

//int min = Math.Min(X1, Math.Min(X2, X3));
//Console.WriteLine($"The Min number:{min}");

#endregion

#region Q4
//int Number = int.Parse(Console.ReadLine());
//if (number % 2==1)
//{
//    Console.WriteLine($"{Number}:is odd number");

//}
//else 
//{
//    Console.WriteLine($"{Number}:is even number");

//}
#endregion

#region Q5

//Console.WriteLine("Please enter the Char");
//char cha =Convert.ToChar (Console.ReadLine());
//if (cha=='a'||cha=='e'||cha=='i'||cha=='o'||cha=='u')
//{
//    Console.WriteLine($"{cha} is vowel char"); 
//}
//else
//{
//    Console.WriteLine($"{cha} is Consonant char");
//}

#endregion

#region Q6

//Console.WriteLine("Please enter the number: ");


//if (int.TryParse(Console.ReadLine(), out int Num))
//{
//    Console.WriteLine($"Numbers from 1 to {Num}:");
//    for (int i = 1; i <= Num; i++)
//    {
//        Console.WriteLine(i);
//    }
//}

#endregion

#region Q7

//Console.Write("Enter the number");
//int num02 = int.Parse(Console.ReadLine());

//Console.WriteLine($"Multiplication Table for {num02}:");

//for (int i = 1; i <= 12; i++)
//{
//    Console.WriteLine($"{num02} x {i} = {num02 * i}");
//}

#endregion

#region Q8
//Console.WriteLine("Please enter the number: ");


//if (int.TryParse(Console.ReadLine(), out int Num01))
//{
//    Console.WriteLine($"Numbers from 1 to {Num01}:");
//    for (int i = 0; i <= Num01; i+=2)
//    {
//        Console.WriteLine(i);
//    }
//}

#endregion

#region Q9
//Console.WriteLine("enter the power");
//int j = int.Parse(Console.ReadLine());

//Console.WriteLine("enter the number");
//int x = int.Parse(Console.ReadLine());

//double pow =  Math.Pow(x, j);
//Console.WriteLine($"{x}^{j}={pow}");
#endregion

#region Q10
//Console.WriteLine("enter the marks");
//float Subject1 = float.Parse(Console.ReadLine());
//float Subject2 = float.Parse(Console.ReadLine());
//float Subject3 = float.Parse(Console.ReadLine());
//float Subject4 = float.Parse(Console.ReadLine());
//float Subject5 = float.Parse(Console.ReadLine());

//float Total = Subject1 + Subject2 + Subject3 + Subject4 + Subject5;
//Console.WriteLine($"Total={Total}");

//float Average = Total / 5;
//Console.WriteLine($"Average={Average}");

//float Percentage = (Total/500 ) * 100;
//Console.WriteLine($"Percentage={Percentage}%");



#endregion

#region Q11

//Console.WriteLine("Enter the month");
//int month = int.Parse(Console.ReadLine());

//switch (month)
//{
//    case 1:
//    case 3:
//    case 5:
//    case 7:
//    case 8:
//    case 10:
//    case 12:

//        Console.WriteLine($"{month} is 31 days ");
//        break;

//    case 4:
//    case 6:
//    case 9:
//    case 11:
//        Console.WriteLine($"30 days of month {month}");
//        break;

//    case 2:
//        Console.WriteLine($"29 days of month {month}");
//        break;
//    default:
//        Console.WriteLine("out of range");
//        break;

//}


#endregion

#region Q12

//double num1;
//double num2;
//double result;
//string operation;

//Console.WriteLine("Simple Calculator");

//Console.Write("Enter the first number: ");
//num1 = Convert.ToDouble(Console.ReadLine());

//Console.Write("Enter the second number: ");
//num2 = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine("Choose an operation (+, -, *, /): ");
//operation = Console.ReadLine();

//switch (operation)
//{
//    case "+":
//        result = num1 + num2;
//        Console.WriteLine("The result of {0} + {1} is: {2}", num1, num2, result);
//        break;

//    case "-":
//        result = num1 - num2;
//        Console.WriteLine("The result of {0} - {1} is: {2}", num1, num2, result);
//        break;

//    case "*":
//        result = num1 * num2;
//        Console.WriteLine("The result of {0} * {1} is: {2}", num1, num2, result);
//        break;

//    case "/":
//        if (num2 != 0)
//        {
//            result = num1 / num2;
//            Console.WriteLine("The result of {0} / {1} is: {2}", num1, num2, result);
//        }
//        else
//        {
//            Console.WriteLine("Error: Cannot divide by zero.");
//        }
//        break;

//    default:
//        Console.WriteLine("Invalid operation. Please enter +, -, *, or /.");
//        break;
//}

#endregion

#region Q13
//Console.WriteLine("enter the name");
//string name = Console.ReadLine();
//char[] CharArray = name.ToCharArray();
//Array.Reverse(CharArray);
//string Reversed = new string(CharArray);
//Console.WriteLine($"name is: {name} and revered name is: {Reversed}");

#endregion

#region Q14

//Console.WriteLine("enter the number");
//int numberss =int.Parse( Console.ReadLine());

//string reversed_num = new string(numberss.ToString().Reverse().ToArray());
//int rev_num = int.Parse(reversed_num);
//Console.WriteLine($"reversed number of {numberss} is: {rev_num}");


#endregion

#region Q15

#endregion

#region Q16

        //Console.Write("Enter a decimal number: ");

        //int decimalNumber = int.Parse(Console.ReadLine());

        //if (decimalNumber == 0)
        //{
        //    Console.WriteLine("Binary: 0");
    
        //}
        
        //string binary = "";

        //while (decimalNumber > 0)
        //{
        //    int remainder = decimalNumber % 2;  
        //    binary = remainder + binary;  
        //    decimalNumber = decimalNumber / 2;  
        //}

        
        //Console.WriteLine("Binary: " + binary);

#endregion

#region Q17

#endregion