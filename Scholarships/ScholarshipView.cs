using System;
using System.Globalization;

namespace Scholarships
{
 
    public class ScholarshipView
    {
        public double Input()
        {
          
            return double.Parse(Console.ReadLine());
        }

        public void NeSeVpisva()
        {
            Console.WriteLine("Не можед да канидатстваш за стипендия");
        }

        public void SocialnaStipendia(int amount)
        {
            Console.WriteLine($"Взимаш социална стипендия за: {amount:C}");
        }

        public void ZaOtlichenUspeh(int amount)
        {
            Console.WriteLine($"Взимаш стипендия за отличен успех за: {amount:C}");
        }
    }
}
