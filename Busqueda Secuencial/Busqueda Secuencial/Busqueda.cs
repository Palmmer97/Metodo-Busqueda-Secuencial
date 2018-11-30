using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Busqueda_Secuencial
{
    class Busqueda
    {
        public bool BusquedaSecuencialNum(int Elemento, List<int> Lista)
        {
            int Tamaño = Lista.Count;
            int Posicion = 0;

            while (Posicion < Tamaño)
            {
                if (Lista[Posicion] == Elemento)
                {
                    return true;
                }
                else
                {
                    Posicion++;
                }
            }
            return false;
        }
        public bool BusquedaSecuencial(char Elemento, List<char> List)
        {
            int Tamaño = List.Count;
            
            int Posicion = 0;

            while (Posicion < Tamaño)
            {
                if (List[Posicion] == Elemento)
                {
                    return true;
                }
                else
                {
                    Posicion++;
                }
            }
            return false;
        }
    }
}
