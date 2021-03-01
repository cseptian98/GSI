using System;

namespace nomorLantai
{
    class Program
    {
        static void nomorLantai(int nomorLoker)
        {
            if (nomorLoker >= 1 && nomorLoker <= 9)
            {
                Console.WriteLine("Lantai 1");
            }
            else if (nomorLoker >= 10 && nomorLoker <= 12)
            {
                Console.WriteLine("Lantai 2");
            }
            else if (nomorLoker >= 13 && nomorLoker <= 19)
            {
                Console.WriteLine("Lantai 3");
            }
            else if (nomorLoker >= 20 && nomorLoker <= 21)
            {
                Console.WriteLine("Lantai 4");
            }
            else if (nomorLoker >= 22 && nomorLoker <= 30)
            {
                Console.WriteLine("Lantai 5");
            }
            else if (nomorLoker >= 31 && nomorLoker <= 33)
            {
                Console.WriteLine("Lantai 6");
            }
            else if (nomorLoker >= 34 && nomorLoker <= 40)
            {
                Console.WriteLine("Lantai 7");
            }
            else
            {
                Console.WriteLine("Lantai 8");
            }
        }
        static void Main(string[] args)
        {
            nomorLantai(7);
            nomorLantai(16);
            nomorLantai(33);
        }
    }
}
