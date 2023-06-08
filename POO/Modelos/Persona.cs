using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Modelos
{
    public class Persona    
    {
        public int Edad { get; set; }
        public void Saludar(string texto)
        {
            Console.WriteLine($"Hola, soy {texto} " );
        }
        public void SetEdad(int parametro)
        { 
            Edad = parametro;
        }
        public virtual void VerEdad()
        {
            //Console.WriteLine("Mi edad es " + Edad);
            //Console.WriteLine("Mi edad es {0}", Edad);
            Console.WriteLine($"Mi edad es {Edad}");
        }

    }
}
