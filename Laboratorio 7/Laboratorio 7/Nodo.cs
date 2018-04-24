using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_7
{
    
    class Nodo<T>
    {
        Nodo<T> NodoPadre;
        Nodo<T> HijoDerecho;
        Nodo<T> HijoIzquierdo;
        T Contenido;

        public Nodo(T Contenido, Nodo<T>NodoPadre=null )
        {
            HijoIzquierdo = null;
            HijoDerecho = null;
            this.Contenido = Contenido;
            NodoPadre = NodoPadre;
        }

        public T MostrarContenido()
        {
            return Contenido;
        }

        public Nodo<T> MostrarNodoPadre()
        {
            try
            {
                return NodoPadre;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
