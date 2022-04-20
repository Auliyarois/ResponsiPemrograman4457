using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman4457
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Karyawan karyawan1 = new Karyawan("445", "sutri", 91090101);
            Karyawan karyawan2 = new Karyawan("554", "lisman 2", 19010909);
            Console.WriteLine("No   Nik/Nama        Gaji Bulanan");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("1    {0}/{1}         {2}", karyawan1.NIK, karyawan1.Nama, karyawan1.GajiBulanan);
            Console.WriteLine("2    {0}/{1}         {2}", karyawan2.NIK, karyawan2.Nama, karyawan2.GajiBulanan);

            Console.WriteLine();
            Console.WriteLine("Naikkan Gaji Sebesar 10%");
            Console.WriteLine();

            karyawan1.NaikkanGaji(10);
            karyawan2.NaikkanGaji(10);

            Console.WriteLine("No   Nik/Nama        Gaji Bulanan");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("1    {0}/{1}         {2}", karyawan1.NIK, karyawan1.Nama, karyawan1.GajiBulanan);
            Console.WriteLine("2    {0}/{1}         {2}", karyawan2.NIK, karyawan2.Nama, karyawan2.GajiBulanan);
        }
    }
}
