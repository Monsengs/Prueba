using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volumen
{
    class Class1
    {
        int[] volumen;
        int altura, longitud, ancho, total, i, final;

        public void getVolumen()
        {
            volumen = new int[2];
            for (i = 0; i < volumen.Length; i++)
            {
                Console.WriteLine("Ingrese la altura: ");
                altura = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la longitud: ");
                longitud = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el ancho: ");
                ancho = int.Parse(Console.ReadLine());

                total = altura * longitud * ancho;

                Console.WriteLine("El volumen es " + total);

                final += total;
            }
            suma(final);
        }

        public string suma(int final)
        {
            string frase = "El volumen de la tercera figura es " + final;
            Console.WriteLine("El volumen de la tercera figura es " + final);
            return frase;
        }
    }
}
