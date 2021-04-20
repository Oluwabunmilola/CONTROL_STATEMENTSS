using System;

namespace CONTROL_FLOW_STATEMENTS
{
    class Program
    {
        static void Main(string[] args)
        {
         //   Console.WriteLine("Hello World!");

              // CONDITIONAL STATEMENTS
        //  int  number=10;
        //  if(number==10)
        //  {
        //      Console.WriteLine("number is 10");
        //  }
        //  else if(number==20)
        //  {
        //    Console.WriteLine("number is 20");   
        //  }
        //  else if(number==30)
        //  {
        //      Console.WriteLine("number is 30");
        //  }
        //  else
        //  {
        //      Console.WriteLine("Please enter a number");
        //  }

//SWITCH STATEMENTS.

// int number=40;
// switch (number)
// {
//     case 10:
//     Console.WriteLine("number is 10");
//     break;

//     case 20:
//  Console.WriteLine("number is 20");
//     break;

//     case 30:
// Console.WriteLine("number is 30");
//     break;
//     default:
// Console.WriteLine("invalid entry");
//      break;
//  }


//DO WHILE LOOP
// int a=10;
// do
// {
//     Console.WriteLine("value of a is " + a);
//     a=a+1;
// }
// while(a<=20);


// 

//FOR LOOP

// for(int i=0; i<5; i++)
//  {
//      Console.WriteLine(i);
//  }


   //FOREACH LOOP
      string[] cars = { "Volvo", "Benz", "Mazda" };

      foreach(var car in cars)
      {
          Console.WriteLine(car);
     }
        }
    }
}
