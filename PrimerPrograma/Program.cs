using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerPrograma
{
    class Program
    {
        static void Main(string[] args)
        {  
            Console.WriteLine("Bienvenidos a C#");
            Console.WriteLine("Primer programa!!!");
        
            string nombre, apellido;
            Console.Write("Ingresa tu nombre:");
            nombre = Console.ReadLine();
            Console.Write("Ingresa tu apellido:");
            apellido = Console.ReadLine();
            
            Int32 edad;
            Console.Write("Ingresa tu edad:");
            edad=Int32.Parse(Console.ReadLine());
            Console.WriteLine("Hola {0} {1}. Tu tienes {2} años", nombre, apellido, edad);
            Console.WriteLine("Pulsa <enter> para continuar.");
           
            decimal x = 100.1593m;
            Console.WriteLine(x);
            Console.WriteLine("El valor de x con 4 decimales de precisión = {0:c4}", x);
            Console.ReadKey();

        }
    }
}
