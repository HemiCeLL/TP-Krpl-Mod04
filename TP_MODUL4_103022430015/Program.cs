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

    public class DoorMachine
    {
        private string currentState = "Terkunci";

        public DoorMachine()
        {
            Console.WriteLine("Pintu terkunci");
        }

        public void BukaPintu()
        {
            if (currentState == "Terkunci")
            {
                currentState = "Terbuka";
                Console.WriteLine("Pintu tidak terkunci");
            }
        }

        public void KunciPintu()
        {
            if (currentState == "Terbuka")
            {
                currentState = "Terkunci";
                Console.WriteLine("Pintu terkunci");
            }
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

            DoorMachine pintu = new DoorMachine();
            pintu.BukaPintu();
            pintu.KunciPintu();
        }
    }
}