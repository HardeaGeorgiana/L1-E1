using System;

namespace Hârdea_Georgiana_L1
{
    class Program
    {
        /* E1.Scrieti un program care citind de la tastaura cele trei dimensiuni ale unui
           paralelipiped dreptunghic, va afisa volumul lui*/
        static void Main(string[] args)
        {
            int lungime;
            int latime;
            int inaltime;
           
            Console.WriteLine("Introduceti lungimea");
         
            lungime = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti latimea");
            latime = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti inaltimea");
            inaltime = int.Parse(Console.ReadLine());

            int volumulParalelipipedDreptunghic = lungime * latime * inaltime;

            Console.WriteLine("Aria paralelipipedului dreptunghic este " + volumulParalelipipedDreptunghic);

           
            
        }
    }
}
