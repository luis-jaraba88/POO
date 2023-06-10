using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_introduccion_c_
  
{
    public class Ejercicio3
    {
        private List<string> DiasSemana { get; set; }
        private List<string> FinSemana { get; set; }

        //constructor es un método especial dentro de una clase que se utiliza para inicializar los objetos de esa clase. Al igual que en otros lenguajes de programación orientados a objetos, el constructor se invoca automáticamente al crear una nueva instancia (objeto) de la clase y se encarga de asignar los valores iniciales a los atributos de la clase.
        public Ejercicio3() 
        {
            DiasSemana = new List<string>{"lunes","martes","miercoles","jueves","viernes" };
            FinSemana = new List<string> { "sabado","domingo" };
        }

        // "Funcion" privada que devuelve un dato boleano
        private bool VerificarDiaSemana(string dia) 
        {
            bool resultado = false;
            //verificar si es dia de semana 
            foreach (var item in DiasSemana)
            {
                if (dia == item)
                { 
                    resultado = true;
                    return resultado;
                }
            }
            return resultado;
        }
 
        private bool VerificarFinSemana(string dia)
        {
            bool resultado = false;
            //verificar si es fin de semana 
            foreach (var item in FinSemana)
            {
                if (dia == item)
                {
                    resultado = true;
                    return resultado;
                }
            }
            return resultado;
        }

        // "procedimiento" que ejecuta la logica del ejercicio
        public void Ejecutar() 
        {
            Console.WriteLine("digite el  dia de la semana");
            string? tempDia = Console.ReadLine();

            // estructura condicionales anidadas

            if (tempDia != null) 
            {
            
                if (VerificarDiaSemana(tempDia))
                {

                    Console.WriteLine($"el dia {tempDia} es dia de semana");
                }
                else if (VerificarFinSemana(tempDia))
                {
                    Console.WriteLine($"el dia {tempDia} es fin de semana");
                }
                else
                {
                    Console.WriteLine("el dato no es un dia valido");
                }
        
            }

            





        } 
    }
}
