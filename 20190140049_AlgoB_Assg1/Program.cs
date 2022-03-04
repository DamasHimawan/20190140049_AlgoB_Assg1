using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20190140049_AlgoB_Assg1
{
    /// <summary>
    /// main class
    /// </summary>
    class Program
    {
        /// <summary>
        /// pola
        /// </summary>
        /// <param name="args"></param>
        /// <remarks> class pola membuat pola dari angka</remarks>
        static void Main(string[] args)
        {

            int baris, a, b;
            Console.Write("\n\n");
            Console.Write("membuat pola dari angka:\n");
            Console.Write("-----------------------------------------------------------");
            Console.Write("\n\n");

            Console.Write("masukan angka 1-6 : ");
            baris = Convert.ToInt32(Console.ReadLine());
            for (a = 1; a <= baris; a++)
            {
                for (b = a - 1; b >= 1; b--)
                    Console.Write("{0}", b);
                Console.Write("\n");
                Console.ReadKey();

                //1.  Algoritma merupakan kumpulan perintah untuk menyelesaikan suatu masalah secara sistematis, terstruktur dan logis. Masalah itu dapat berupa apa saja, dengan syarat untuk setiap permasalahan memiliki kriteria kondisi awal yang harus dipenuhi sebelum menjalankan sebuah algoritma. Algoritma juga memiliki pengulangan proses (iterasi), dan juga memiliki keputusan hingga keputusan selesai.
                //2.  Struktur data adalah cara penyimpanan, penyusunan dan pengaturan data di dalam media penyimpanan komputer sehingga data tersebut dapat digunakan secara efisien.
                //3.  - Tidak menggunakan sintaks dari suatu bahasa pemrograman tertentu.
                //      - Tidak bergantung pada suatu bahasa pemrograman tertentu.
                //      -Notasi - notasi algoritma dapat diimplimentasikan untuk seluruh bahaa pemrograman manapun.
                //      -Algoritma dapat digunakan untuk merepresentasikan suatu urutan kejadian yang logis.
                //4.    -Memecahkan program rumit.
                //      -Bisa menjadikan program yang besar menjadi program yang lebih sederhana.
                //      - Fungsi Algoritma juga bisa digunakan secara berulang atau lebih dari satu kali penggunaan.
                //      -Memudahkan dalam pembuatan program.
                //      - Mengatasi segala masalah dengan logika dan urut
                //5.    a.Tipe Graph ini adalah tipe yang cukup sering digunakan dalam berbagai kesempatan.Graph sendiri merupakan struktur data yang non - linear dan terdiri dari kumpulan node.
                //      b.Tipe Tree, seperti namanya, tipe yang kedua ini bisa diibaratkan dengan akar di suatu pohon.Jadi, tipe ini bisa dimaknai sebagai kumpulan node dan masing - masing node tersebut tersusun dari value dan juga berbagai referensi lainnya. Nah, Tree yang terdiri atas maksimal 2 anak akan disebut sebagai Binary Tree.
                //      c.Tipe struktur data yang lainnya ialah Queue.Ini adalah struktur data yang bersifat LIFO atau Last In First Out. Dalam Queue ini juga ada 3 operasi sekaligus yang bisa Anda lakukan yakni peek atau melihat data yang paling awal dari suatu Queue, dequeue atau menghapus data yang pertama dari Queue dan enqueue atau memasukkan data dalam Queue.
                //      d.Stack ini adalah tipe yang mirip seperti Queue. Tipe ini juga mempunyai sifat LIFO karena termasuk struktur data yang linear.
                //      e.Jika diartikan secara kasar, maka Linked List berarti daftar yang terhubung. Ya, sesuai dengan namanya, tipe satu ini memang berupa potongan-potongan aneka macam data yang tersimpan secara acak.Berbagai potongan data tersebut akan ada dalam memori komputer dan data yang dimaksud memiliki referensi yang saling menunjuk satu sama lain
                //      f.Array.Ini adalah tipe yang memiliki kumpulan elemen dan elemen - elemen tersebut jaraknya saling berdekatan dalam memori. Dalam Array ada beberapa jenis operasi yang dipakai yaitu replace, sort, delete, insert, search dan lain sebagainya

            }
        }
    }
}
