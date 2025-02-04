using System;
using System.Runtime.ConstrainedExecution;
class Program
{
    static void Main(string[] args)
    {
        //Del 1
            Console.WriteLine("Ange ett tal:");
            int tal1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ange ett annat tal:");
            int tal2 = int.Parse(Console.ReadLine());

            int resultat = tal1 / tal2;  // Möjlig division med noll
            Console.WriteLine($"Resultat: {resultat}");

        //Möjliga fel:
        //Att använderaen inte matar in ett tal
        //Att vi försöker dividera med 0


        /*------------------------------------------------------------------------------------------*/
        //Del 2
        Console.WriteLine("Ange sidolängden på en kub:");
        int sida = int.Parse(Console.ReadLine());

        Console.WriteLine("Volymen blir: " + (Math.Pow(sida,3)));
        //Möjliga fel att hantera
        //Användaren försöker mata in negativa värden. 

        
        /*------------------------------------------------------------------------------------------*/
        //Del 3
        // Kom på en egen uppgift där du behöver skapa din egna Exception. Skriv koden nedan

    }

}
}

