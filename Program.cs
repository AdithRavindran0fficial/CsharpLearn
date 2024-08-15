// int a = 1;
// int b = 2;
// int sum = a+b;
// Console.WriteLine(sum);


// double num1 = 1.2;
// double num2 =33.9;
// double sums_2 =num1+num2;
// Console.WriteLine(sums_2);

// int a = 6;
// int b = a;
// b=2;
// Console.WriteLine(b);
// Console.WriteLine(a);

// /---------------------------------------------------*TYPE CONVERTION--------------------------------------*/
//  QUESTION 1
// string num_str = "1212";
// int num;
// bool val = int.TryParse(num_str,out num);
// System.Console.WriteLine(val.GetType());

//  question2

// string date =  "21-04-2003";
// DateTime date_time;
// bool val = DateTime.TryParse(date,out date_time) ;
// System.Console.WriteLine(date_time);
       
//  question2

// bool value = true;
// string str = Convert.ToString(value);
// System.Console.WriteLine(str);

using System;
using myCalculator;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
           MyApp myApp = new MyApp();
        // var myApp = new MyApp();
           myApp.Introduce();


           Calculator calculator= new Calculator();

          int a=  calculator.Add(1,2);
           int b = calculator.Minus(5,3);
          int c =  calculator.Divide(10,2);
           int d  = calculator.Multiply(2,7);
           Console.WriteLine(a);
           Console.WriteLine(b);
           Console.WriteLine(c);
           Console.WriteLine(d);

           Mystruct mystruct = new Mystruct();
           mystruct.name = "adith";
           Console.Write(mystruct.name);
           





        }
    }
}






        