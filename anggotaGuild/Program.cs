using System;
using System.Collections.Generic;

namespace anggotaGuild
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,j;
            List<string> daftar = new List<string>();
            string thnmsk="",nim = "",nama ="", kelamin="", Ps="", kls="", print="", tambah="";
            Console.Write("Berapa Data = ");
            int data = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            for (i = 0; i < data; i++)
            {
                Console.WriteLine("Data ke - {0}", i + 1);
                Console.Write("NIM\t\t: ");
                nim = Console.ReadLine();
                Console.Write("Nama\t\t: ");
                nama = Console.ReadLine();
                Console.Write("Jenis Kelamin\t: ");
                kelamin = Console.ReadLine();
                Console.Write("Tahun Masuk\t: ");
                thnmsk = Console.ReadLine();
                Console.Write("Program Studi\t: ");
                Ps = Console.ReadLine();
                Console.Write("Kelas\t\t: ");
                kls = Console.ReadLine();
                Console.WriteLine();
                daftar.Add(nim);
                daftar.Add(nama);
                daftar.Add(kelamin);
                daftar.Add(thnmsk);
                daftar.Add(Ps);
                daftar.Add(kls);
            }
            Console.Write("Print Hasil ? (y/n) ");
            print = Console.ReadLine();
            while (print == "y")
            {
                Console.WriteLine("NO\tNIM\tNama\t\tJenis Kelamin\tTahun Masuk\tProgram Studi\tKelas");
                foreach (var e in daftar)
                {
                    Console.Write("{0}\t", i+1);
                    Console.WriteLine($"{nim}\t{nama}\t\t{kelamin}\t\t{thnmsk}\t\t{Ps}\t\t{kls}", e);
                }
                Console.Write("Tambah Data? (y/n)");
                tambah = Console.ReadLine();
                if (tambah == "y")
                {
                    Console.Write("Berapa Data = ");
                    data = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    for (i = 0; i < data; i++)
                    {
                        Console.WriteLine("Data ke - {0}", i + 1);
                        Console.Write("NIM\t\t: ");
                        nim = Console.ReadLine();
                        Console.Write("Nama\t\t: ");
                        nama = Console.ReadLine();
                        Console.Write("Jenis Kelamin\t: ");
                        kelamin = Console.ReadLine();
                        Console.Write("Tahun Masuk\t: ");
                        thnmsk = Console.ReadLine();
                        Console.Write("Program Studi\t: ");
                        Ps = Console.ReadLine();
                        Console.Write("Kelas\t\t: ");
                        kls = Console.ReadLine();
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
