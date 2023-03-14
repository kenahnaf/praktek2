using System;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace kalkulator
{
    class program
    {
        static void Main(string[]args)
        {
            // int a = 10;
            // int b = 6;

            Console.WriteLine("Pilih Menu Kalkulator:");
            Console.WriteLine("1. Penambahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");

            int a,b;
            string angka = Console.ReadLine();
            
           
            switch (angka)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("Penjumlahan");
                    Console.WriteLine("Input A: ");
                     a = int.Parse(Console.ReadLine());

                    Console.WriteLine("Input B:");
                    b = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Hasil Penambahan" + a + "+" + b + "=" + penambahan(a, b));
                    break;

                case "2":
                    Console.Clear();
                    Console.WriteLine("Pengurangan");

                    Console.WriteLine("Input A: ");
                    a = int.Parse(Console.ReadLine());

                    Console.WriteLine("Input B:");
                    b = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Hasil Pengurangan {0} - {1} = {2} ", a, b, pengurangan(a, b));
                    break;

                case "3":
                    Console.Clear();
                    Console.WriteLine("Perkalian");

                    Console.WriteLine("Input A: ");
                    a = int.Parse(Console.ReadLine());

                    Console.WriteLine("Input B:");
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Hasil Perkalian {0} * {1} = {2} ", a, b, perkalian(a, b));
                    break;



                case "4":
                    Console.Clear();
                    Console.WriteLine("Pembagian");

                    Console.WriteLine("Input A: ");
                    a = int.Parse(Console.ReadLine());

                    Console.WriteLine("Input B:");
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Hasil Pembagian {0} / {1} = {2} ", a, b, pembagian(a, b));
                    break;

                default:
                    Console.WriteLine(" Maaf, 1 sampai 4 ");
                    
                    break;
            }




            

            Console.WriteLine("press button");
            Console.ReadKey();
            
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