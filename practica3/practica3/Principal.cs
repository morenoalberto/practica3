using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace practica3
{
    class Principal
    {
        static void Main(string[] args)
        {
            Programa programa = new Programa();
            programa.capturar();
            Console.Clear();
            programa.editar();
            Console.Clear();
            programa.eliminar();
            Console.Clear();
            programa.imprimirTodos();
        }
    }
}
