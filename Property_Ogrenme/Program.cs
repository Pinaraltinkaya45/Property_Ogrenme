using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property_Ogrenme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();

            musteri1.sinav1 = 100;
            musteri1.sinav2 = 90;

            Console.WriteLine("Değişken Olan sinav1 : " + musteri1.sinav1);
            Console.WriteLine("Property Olan sinav2 : " + musteri1.sinav2);


            musteri1.KİLO = 85;  // değer atama yapıyorum o zaman set blokları çalışır,
            //eğer değer ataması yapmsaydım o zamanda get bloklarım çalışacaktı

            Console.WriteLine(musteri1.KİLO);

            Console.ReadLine(); 
        }
    }
}
