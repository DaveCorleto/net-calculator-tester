using System;

namespace net_calculator_tester
{
    public class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            
            float risultatoSomma = calculator.Somma(8.0f, 2.0f);

           
            Console.WriteLine($"Risultato della somma: {risultatoSomma}");
        }
    }
}

