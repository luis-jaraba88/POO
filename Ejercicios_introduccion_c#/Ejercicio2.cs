using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

Console.WriteLine ("digite el numero 1");
int d = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("digite el numero 2");
int e = Convert.ToInt32(Console.ReadLine());
if (d > e)
{
    Console.WriteLine($"el numero mayor es: {d}");
}
else
{
    Console.WriteLine("el numero mayor es: " + e);
}
    
