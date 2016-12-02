using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classiastratte
{
    class Program
    {
        static void Main(string[] args)
        {
            Cavallo caval = new Cavallo();
            Corvo corv = new Corvo();
            Pinguino ping = new Pinguino();
            Salmone salm = new Salmone();
            Tonno ton = new Tonno();
            Uomo uom = new Uomo();
            string risp ="";
            while (risp != "x")
            {
                
                Console.WriteLine("Scegli una opzione");
                Console.WriteLine("A_Animale terrestre");
                Console.WriteLine("B_Animale acquatico");
                Console.WriteLine("X_Esci");
                risp = Console.ReadLine();
                if (risp == "a")
                {
                    
                    Console.WriteLine("A_Bipede");
                    Console.WriteLine("B_Quadrupede");
                    Console.WriteLine("C_Uccello");
                    risp = Console.ReadLine();
                    if (risp == "a")
                    {
                        uom.Epilogo();
                        Console.ReadLine();
                    }
                    if (risp == "b")
                    {
                        caval.Epilogo();
                        Console.ReadLine();
                    }
                    if (risp == "c")
                    {
                        ping.Epilogo();
                        corv.Epilogo();
                        Console.ReadLine();
                    }
                    
                }
                if (risp == "b")
                {
                    Console.WriteLine("A_Animale marin");
                    Console.WriteLine("B_Animale fluvial");
                    risp = Console.ReadLine();
                    if (risp == "a")
                    {
                        ton.Epilogo();
                        Console.ReadLine();
                    }
                    else
                    {
                        salm.Epilogo();
                        Console.ReadLine();
                    }
                    
                }
                Console.Clear();
            }
            Console.ReadLine();
        }
    }
}
