using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_introduccion_c_
{
    public class Ejercicio10
    {
        //Pide 10 números por consola, muestra el resultado por consola de sumar los pares y restarle los impares.
        private List<int> Numeros = new List<int>();
        private int Pares { get; set; }
        private int Impares { get; set; }   

        public void Ejecutar()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"digite numero {i}");
                var dato = Console.ReadLine();
                if ( dato != null ) 
                {
                    Numeros.Add(int.Parse(dato));
                }
                
            }
           
            foreach (int num in Numeros) 
            {
                //valida que el numero sea par
                if (num % 2==0)
                {
                    //acumulador para sumar todos los numeros que sean pares
                    Pares = Pares + num;
                }
                else
                {
                    //acumula los valores de los numeros que sean impares
                    Impares= Impares + num;
                }
            }
            var resultado = Pares - Impares;
            Console.WriteLine($"la resta de los numeros pares menos los numeros impares es {resultado}");
        }

    }

}
