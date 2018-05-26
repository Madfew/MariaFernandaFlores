using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaferFlores
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Buenas tardes, bienvenido a su cocina.");
            Console.WriteLine("Tienes un utensilio en forma de reicipiente.");
            Console.Write("¿Qué es? ");
            string targetObjetoRecipiente = Console.ReadLine();

            List<Recipientes> recipiente = new List<Recipientes>();
            recipiente.Add(new Recipientes(1.0f, "pequeño", "plástico"));
            recipiente.Add(new Recipientes(2.0f, "grande", "cerámica"));

            Console.WriteLine("Esto es un: " + targetObjetoRecipiente + ". De material "  + recipiente[1].material);

            //Console.WriteLine("Tambíen tienes una maquinaria eléctrica");

        }
    }
}
