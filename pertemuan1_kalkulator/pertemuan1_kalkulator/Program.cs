using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pertemuan1_kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aplikasi Calculator";
            int a, b;
            string input;

            Console.WriteLine("Pilih menu kalkulator: ");
            Console.WriteLine("\n1. Penambahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");
            Console.Write("\nInput nomor menu [1..4] = ");
            input = Console.ReadLine();

            if (input == "1")
            {
                Console.Write("\nInputkan nilai a : ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Inputkan nilai b : ");
                b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\nHasil Penambahan " + a + " + " + b + " = " + penambahan(a, b));

                Console.Write("\nTekan key sembarang untuk keluar");
                Console.ReadKey();
            }
            else if (input == "2")
            {
                Console.Write("\nInputkan nilai a : ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Inputkan nilai b : ");
                b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\nHasil Pengurangan {0} - {1} = {2} ", a, b, pengurangan(a, b));

                Console.Write("\nTekan key sembarang untuk keluar");
                Console.ReadKey();
            }
            else if (input == "3")
            {
                Console.Write("\nInputkan nilai a : ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Inputkan nilai b : ");
                b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Hasil Pengurangan {0} * {1} = {2} ", a, b, perkalian(a, b));

                Console.Write("\nTekan key sembarang untuk keluar");
                Console.ReadKey();

            }
            else if (input == "4")
            {
                Console.Write("\nInputkan nilai a : ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Inputkan nilai b : ");
                b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Hasil Pengurangan {0} / {1} = {2} ", a, b, pembagian(a, b));

                Console.Write("\nTekan key sembarang untuk keluar");
                Console.ReadKey();

            }
            else
            {
                Console.Write("\nMaaf menu yang anda pilih tidak tersedia\n");

                Console.Write("\nTekan key sembarang untuk keluar");
                Console.ReadKey();

            }
        }
        static int penambahan(int a, int b)
        {
            return a + b;
        }
        static int pengurangan(int a, int b)
        {
            return a - b;
        }
        static int perkalian(int a, int b)
        {
            return a * b;
        }
        static int pembagian(int a, int b)
        {
            return a / b;
        }
    }
}


