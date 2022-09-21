// calculator program
using System;
using System.Collections.Generic;

namespace CalculatorSkilvul
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("Selamat datang di kalkulator sederhana");
            Console.WriteLine("1. Pertambahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");
            Console.Write("Masukan Angka : ");
            int masukan = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.Write("Masukan Angka Pertama : ");
            float angka1 = float.Parse(Console.ReadLine());
            Console.Write("Masukan Angka Kedua : ");
            float angka2 = float.Parse(Console.ReadLine());
            float hasil = 0;
            switch (masukan)
            {
                case 1:
                    hasil = angka1 + angka2;
                    Console.WriteLine("Pertambahan " + angka1 + " dan " + angka2 + " adalah " + hasil);
                    break;
                case 2:
                    hasil = angka1 - angka2;
                    Console.WriteLine("Pengurangan " + angka1 + " dan " + angka2 + " adalah " + hasil);
                    break;
                case 3:
                    hasil = angka1 * angka2;
                    Console.WriteLine("Perkalian " + angka1 + " dan " + angka2 + " adalah " + hasil);
                    break;
                case 4:
                    hasil = angka1 / angka2;
                    Console.WriteLine("Pembagian " + angka1 + " dan " + angka2 + " adalah " + hasil);
                    break;
                default:
                    Console.WriteLine("Tidak ada pilihan");
                    break;
            }


            Console.WriteLine("Press Any Key To Exit");
            Console.ReadKey();
        }

    }
}