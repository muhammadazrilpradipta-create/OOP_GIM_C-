using System;
using System.Collections.Generic;
namespace KerangkaGame
{
    class Karakter
    {
        public int total, power;

        //encapsulation
        public string nama { get; private set; }
        public int kesehatan { get; private set; }
        public int senjata { get; private set; }

        public Karakter(string nama, int kesehatan, int senjata) //membuat constructor
        {
            this.nama = nama;
            this.kesehatan = kesehatan;
            this.senjata = senjata;
        }

        public void Serang(Karakter target) //membuat menthod menyerang
        {
            Console.WriteLine("===> Mulai Serangan <===");
            target.TerimaSerangan(this.senjata);
        }

        public void TerimaSerangan(int jumlahSerangan) // objek menerima serangan
        {
            kesehatan -= jumlahSerangan;
            Console.WriteLine($"{nama} diserang dengan {jumlahSerangan} sisa kesehatannya {kesehatan}");
        }

        public void Healing()
        {
            if (kesehatan <= 0)
            {
                Console.WriteLine($"{nama} sudah mati dan tidak bisa disembuhkan.");
                return;
            }

            Console.Write("Apakah mau disembuhkan? (Yes/No): ");
            string jawaban = Console.ReadLine().ToLower();

            if (jawaban == "yes") 
            {
                kesehatan += 20;
                Console.WriteLine($"{nama} disembuhkan dengan penambahan 20. Kesehatan sekarang: {kesehatan}");
            }
            else if (jawaban == "no") 
            {
                Console.WriteLine($"{nama} tidak disembuhkan.");
            }
            else
            {
                Console.WriteLine("Tidak ditemukan.");
            }
        }


        public void getData()
        {
            Console.WriteLine($"Karakter : {nama}");
            Console.WriteLine($"Kesehatan : {kesehatan}");
            Console.WriteLine($"Senjata : {senjata}");
        }
    }


    class MainProgram
    {
        static void Main(string[] args)
        {
            Karakter player1 = new Karakter("Nexaa", 100, 10); // player utama
            Karakter musuh1 = new Karakter("Nexii", 80, 50); //Musuh


            //interaksi
            player1.Serang(musuh1);
            musuh1.Serang(player1);
            player1.Healing();
        }
    }
}