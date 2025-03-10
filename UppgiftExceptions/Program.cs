﻿using System;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;
class Program
{
    static void Main(string[] args)
    {
        //Del 1
        try
        {
            Console.WriteLine("Ange ett tal:");
            int tal1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ange ett annat tal:");
            int tal2 = int.Parse(Console.ReadLine());

            int resultat = tal1 / tal2;  // Möjlig division med noll
            Console.WriteLine($"Resultat: {resultat}");
        }
        catch (FormatException ex)
        {
            Console.Writeline("Ogiltig inmatning, vänligen ange ett heltal")
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Ett fel uppstod" + ex.Message);
        }

        //Möjliga fel:
        //Att använderaen inte matar in ett tal
        //Att vi försöker dividera med 0


        /*------------------------------------------------------------------------------------------*/
        //Del 2
        public class MyOwnException: Exception
    {
        public MyOwnException() : base() { }
        public MyOwnException(string message) : base(message) { }
        public MyOwnException (string message, Exception innerExeption) : base(message, innerException) { }

    }
        try
        {
            Console.WriteLine("Ange sidolängden på en kub:");
            int sida = int.Parse(Console.ReadLine());
             if (sida < 0)            
                   throw new MyOwnException(" ")

            Console.WriteLine("Volymen blir: " + (Math.Pow(sida, 3)));
            //Möjliga fel att hantera
            //Användaren försöker mata in negativa värden. 
            
        }

        catch (MyOwnException ex)
        {
            Console.Writeline("Sidan får inte vara negativ");
        }

        /*------------------------------------------------------------------------------------------*/
        //Del 3
        // Kom på en egen uppgift där du behöver skapa din egna Exception. Skriv koden nedan

    }

}
}

