using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Busqueda_Secuencial
{
    class Program
    {
        static void Main(string[] args)
        {
            // Explicacion con mis palabras de como funciona este metodo 
            //Basicamente busca al inicio de la lista e ir a través
            //de cada registro hasta encontrar el elemento indicado, o hasta al final de la lista.
  
            Console.Title = "Busqueda Secuencial";
        Hola:
            Console.Clear();
        Console.WriteLine(@"Selecciona el ejercicio
1.- Ejercicio 1
2.- Ejercicio 2
3.- Salir");
        int a = int.Parse(Console.ReadLine());
        Busqueda TB = new Busqueda();
        if (a==1)
        {
            
            List<int> Lista = new List<int>();

            Lista.Add(78);
            Lista.Add(35);
            Lista.Add(243);
            Lista.Add(2);
            Lista.Add(65);
            Lista.Add(4);
            Lista.Add(243);
            Lista.Add(12);
            Lista.Add(1);

            int Buscador = 243;
            int Elemnto = 20;

            Console.WriteLine("BUSQUEDA SECUENCIAL");
            Console.WriteLine();
            Console.WriteLine("Buscador " + Buscador);
            Console.WriteLine("¿se encuentra en la lista? " + TB.BusquedaSecuencialNum(Buscador, Lista));
            Console.WriteLine("El elemento " + Elemnto);
            Console.WriteLine("¿se encuentra en la lista? " + TB.BusquedaSecuencialNum(Elemnto, Lista));
            Console.ReadKey();
            goto Hola;

        }
        if (a==2)
        {
            List<char> List = new List<char>();

            List.Add('A');
            List.Add('B');
            List.Add('C');
            List.Add('D');
            List.Add('E');
            List.Add('F');

            char Buscar = 'A';
            char Elemento = 'G';

            Console.WriteLine("BUSQUEDA SECUENCIAL");
            Console.WriteLine();
            Console.WriteLine("Buscador " + Buscar);
            Console.WriteLine("¿se encuentra en la lista? " + TB.BusquedaSecuencial(Buscar, List));
            Console.WriteLine("El elemento " + Elemento);
            Console.WriteLine("¿se encuentra en la lista? " + TB.BusquedaSecuencial(Elemento, List));
            Console.ReadKey();
            goto Hola;
        }
        if (a==3)
        {
            Console.WriteLine("Teclee Cualquier tecla :) ");
            Console.Clear();
            Console.ReadKey();
        }
        Console.ReadKey();
            
        }
    }
}
