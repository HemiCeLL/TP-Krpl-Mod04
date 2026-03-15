using System;

namespace TP_MODUL4_103022430015
{
    public class KodePos
    {
        private string[] kelurahan = {
            "Batununggal", "Kujangsari", "Mengger", "Wates", "Cijaura",
            "Jatisari", "Margasari", "Sekejati", "Kebonwaru", "Maleer"
        };

        private string[] kode = {
            "40266", "40287", "40267", "40256", "40287",
            "40286", "40286", "40286", "40272", "40274"
        };

        public string getKodePos(string inputKelurahan)
        {
            for (int i = 0; i < kelurahan.Length; i++)
            {
                if (kelurahan[i] == inputKelurahan)
                {
                    return kode[i];
                }
            }
            return "Kode pos tidak ditemukan.";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            KodePos kp = new KodePos();
            Console.Write("Masukkan nama kelurahan: ");
            string input = Console.ReadLine();

            Console.WriteLine("Kode pos: " + kp.getKodePos(input));
        }
    }
}