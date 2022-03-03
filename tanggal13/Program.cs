using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soalmenentukankelulusan
{
    /// <summary>
    /// Main Class
    /// </summary>
    /// <remarks>Class ratarata dapat membuat operasi perhitungan yang dapat menentukan nilai rata-rata dari 2 mata pelajaran</remarks>
    class ratarata
    {
        /// <summary>
        /// Variabel dengan tipe data doble
        /// </summary>
        double IPA, MTK, RATA;

        /// <summary>
        /// <para name="inputnilai">untuk memasukan nilai/memasukan data</para>
        /// input data
        /// </summary>
        public void inputnilai()
        {
            Console.Write("masukkan nilai IPA : ");
            IPA = Convert.ToDouble(Console.ReadLine());
            Console.Write("masukkan nilai MTK : ");
            MTK = Convert.ToDouble(Console.ReadLine());
        }

        /// <summary>
        /// <para name="rataratanilai">untuk menentukan rata2 nilai dari perhitungan ipa dan mtk</para>
        /// untuk rata-rata nilainya. mtk ditambah ipa dibagi 2
        /// </summary>
        /// <returns>Hasil dari penjumlahan dan pembagian</returns>
        public double rataratanilai()
        {
            return (IPA + MTK) / 2;
        }

        /// <summary>
        /// <para name="statuskelulusan">terdapat kondisi</para>
        /// </summary>
        /// <returns>Hasil kondisi dari status kelulusan</returns>
        public string statuskelulusan()
        {
            string status;

            if ((MTK >= 80) && (rataratanilai() >= 75))
            {
                status = "Selamat anda dinyatakan lulus";
            }
            else
            {
                status = "Anda dinyatakan tidak lulus";
            }
            return status;
        }

        /// <summary>
        /// <para name="tampilan">untuk menampilkan hasil dari rata rata nilai</para>
        /// </summary>
        public void tampilan()
        {
            Console.WriteLine("Nilai rata-rata = {0} \nStatus kelulusan = {1}", rataratanilai(), statuskelulusan());
            Console.ReadKey();
        }

    }

    /// <summary>
    /// Sub Class
    /// untuk memanggil inputnilai dan juga tampilan
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            ratarata obj = new ratarata();
            obj.inputnilai();
            obj.tampilan();

        }
    }
}