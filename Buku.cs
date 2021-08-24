using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas01
{
    class Buku
    {
        string namaBuku;
        int hargaBuku, jumlahBuku;
        static List<string> namaBukus = new List<string>();
        static List<int> hargaBukus = new List<int>();
        static List<int> jumlahBukus = new List<int>();
        public void LihatBuku()
        {
            int ind = 1;
            if (namaBukus.Count != 0)
            {
                for (int i = 0; i < namaBukus.Count; i++)
                {
                    Console.WriteLine(ind+".\tNama Buku : " + namaBukus[i]);
                    Console.WriteLine("\tHarga Buku :" + hargaBukus[i]);
                    Console.WriteLine("\tJumlah Buku:" + jumlahBukus[i]);

                    ind++;
                }
            }
            else
            {
                Console.WriteLine("Buku Kosong\n");
            }
        }
        public void TambahBuku()
        {
            Console.Write("Nama Buku : ");
            namaBuku = Console.ReadLine();
            namaBukus.Add(namaBuku);
            Console.Write("Harga Buku: ");
            hargaBuku = Convert.ToInt32(Console.ReadLine());
            hargaBukus.Add(hargaBuku);
            Console.Write("Jumlah Buku: ");
            jumlahBuku = Convert.ToInt32(Console.ReadLine());
            jumlahBukus.Add(jumlahBuku);
        }

        public void HapusBuku()
        {
            Console.Write("Masukkan nomor buku: ");
            int pilih = Convert.ToInt32(Console.ReadLine());
            namaBukus.RemoveAt(pilih - 1);
            hargaBukus.RemoveAt(pilih - 1);
            jumlahBukus.RemoveAt(pilih - 1);
        }
    }
}
