using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_introduccion_c_
{
    public class Ejercicio4
    {
        //Ejercicio5
        public void Ejecutar()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i + "es numero par");
                }
                else
                {
                    Console.WriteLine(i + "es numero impar");
                }

            }

        }
    }
}
