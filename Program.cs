using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luas_Segitiga
{
    /// <summary>
    /// class hitung
    /// </summary>
    /// <remarks>dalam class ini akan menghitung dari input, hitung, dan tampil</remarks>
    class Hitung
    {
        /// <summary>
        /// untuk menginisiasi variabel tipe data double jari, luas, kelling yang menyimpan nilai
        /// </summary>
        double panjang, tinggi, luas;
        /// <summary>
        /// method ini digunakan untuk input data yang kemudian disimpan ke variabel 
        /// </summary>
        public void input()
        {
            Console.WriteLine("\t=== Program Menghitung Luas Segitiga Dengan C# ===");
            Console.Write("\tMasukkan panjang (cm) : ");
            panjang = double.Parse(Console.ReadLine());
            Console.Write("\tMasukkan tinggi (cm)  : ");
            tinggi = double.Parse(Console.ReadLine());
        }
        /// <summary>
        /// method ini digunakan untuk menghitung luas segitiga
        /// </summary>
        public void hitung()
        {
            luas = 0.5 * panjang * tinggi;
        }
        /// <summary>
        /// method ini untuk menampilkan nilai luas
        /// </summary>
        public void tampil()
        {
            Console.WriteLine("");
            Console.WriteLine("luas lingkaran => {0}", luas);
        }
    }
    /// <summary>
    /// class program memanggil method yang sudah dibuat 
    /// </summary>
    class Program
    {
        /// <summary>
        /// menginisiasi class hitung 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Hitung ll = new Hitung();
            ll.input();
            ll.hitung();
            ll.tampil();

            Console.ReadKey();
        }
    }
}
