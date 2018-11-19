using System;

namespace CSuma
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Escribe un número: ");
            string stringnum1 = Console.ReadLine();
            decimal num1 = decimal.Parse(stringnum1);
            Console.WriteLine("Ecribe otro número: ");
            string stringnum2 = Console.ReadLine();
            decimal num2 = decimal.Parse(stringnum2);
            decimal suma = num1 + num2;
            Console.WriteLine("El resultado es :" +suma);
        }
          //  private static decimal readDecimal(string label){
          //  Console.WriteLine(label);
          //  string stringDecimal = Console.ReadLine();
          //  return decimal.Parse(stringDecimal);
       // }
    }
}
