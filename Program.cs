using System;
using System.Collections.Generic;

namespace Tugas01
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Buku buku = new Buku();
            var date = DateTime.Now;
            string nama = "Yepta Zagarino Samosir";
            string asal = "Institut Teknologi Del";
            int tahunLahir = 2000;
            string pembuka = "Selamat Datang Di Aplikasi Bank Buku";
            string kalimatPembuka = pembuka.ToUpper();
            int menu;
            Console.WriteLine($"{date:dddd, MMMM dd, yyyy}\n");
            Console.WriteLine($"Nama saya {nama}, berasal dari {asal}. Saya kelahiran tahun {tahunLahir} dan umur saya {2021-tahunLahir} tahun\n");
            Console.WriteLine( kalimatPembuka);
            Console.WriteLine();
            while (true)
            {
                Console.WriteLine("Pilih Menu Anda : ");
                Console.WriteLine("1. Lihat Daftar Buku");
                Console.WriteLine("2. Tambah Buku");
                Console.WriteLine("3. Hapus Buku");
                Console.WriteLine("4. Keluar Aplikasi\n");
                Console.Write("Pilihan : ");
                
                try
                {
                    menu = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    if (menu == 1)
                    {
                        buku.LihatBuku();
                    }
                    else if (menu == 2)
                    {
                        buku.TambahBuku();
                    }
                    else if (menu == 3)
                    {
                        buku.HapusBuku();
                    }
                    else if (menu == 4)
                    {
                        Keluar();
                        break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("\nHanya menerima inputan angka\n");
                    
                }
            }
            
        }
        
        
        static void Keluar()
        {
            Console.WriteLine("\nBerhasi Keluar Aplikasi. Terimakasih\n");
            
        }
    }
}
