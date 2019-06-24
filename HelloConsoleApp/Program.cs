﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //tu piszemy kod
            Console.WriteLine("Program na powitanie.");

            Console.Write("Podaj imię: ");
            string imie;
            imie = Console.ReadLine();

            Console.Write("Podaj nazwisko: ");
            string nazwisko;
            nazwisko = Console.ReadLine();

            Console.WriteLine("Witaj {0} {1}. Jak mija dzień? Za chwilę poprosze Cię o więcej informacji", imie, nazwisko);
        

            Console.Write("Podaj wiek: ");
            int wiek = Convert.ToInt32(Console.ReadLine());

            if (wiek < 67)
            {
                Console.WriteLine(" do emerytury zostało Ci {0} lat", 67 - wiek);
            }
           
            else
            {
                Console.WriteLine("Jesteś emerytem");
            }
        
        }

    }
}
