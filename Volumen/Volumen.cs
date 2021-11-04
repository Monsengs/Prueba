using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volumen
{
    public class Volumen
    {
        public decimal Altura { get; set; }
        public decimal Longitud { get; set; }
        public decimal Ancho { get; set; }

        public decimal getVolumen()
        {
            return Altura * Longitud * Ancho;
        }

        public static Volumen getVolumen(Volumen prisma1, Volumen prisma2)
        {
            Volumen prisma3 = new Volumen();
            prisma3.Altura = prisma1.Altura + prisma2.Altura;
            prisma3.Ancho = prisma1.Ancho + prisma2.Ancho;
            prisma3.Longitud = prisma1.Longitud + prisma2.Longitud;
            return prisma3;
        }

        public static void Main(string[] args)
        {
            Volumen prisma1 = new Volumen();
            prisma1.Altura = 5;
            prisma1.Longitud = 3;
            prisma1.Ancho = 2;
            Console.WriteLine(prisma1.getVolumen());

            Console.WriteLine("-----------------------------------------");

            Volumen prisma2 = new Volumen();
            prisma2.Altura = 4;
            prisma2.Longitud = 2;
            prisma2.Ancho = 4;
            Console.WriteLine(prisma2.getVolumen());

            Console.WriteLine("-----------------------------------------");

            
            Volumen prisma_3 = getVolumen(prisma1, prisma2);
            Console.WriteLine(prisma_3.getVolumen());
            

            Console.ReadLine();
            
        }
    }
}
