using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3.Models
{
    internal class Servicios
    {
        public string Nombre0;
        public string Nombre1;
        public string Nombre2;
        public int NumLibreta0;
        public int NumLibreta1;
        public int NumLibreta2;
        public int Orden = 0;

        public void Reiniciar()
        {
            NumLibreta0 = 0;
            NumLibreta1 = 0;
            NumLibreta2 = 0;
        }
        public void RegistrarNombres_Libretas(string nombre, int numlibretas)
        {
            if (Orden == 0)
            {
                Nombre0 = nombre;
                NumLibreta0 = numlibretas;
            }
            else if (Orden == 1)
            {
                if (numlibretas < NumLibreta0)
                {
                    Nombre1 = Nombre0;
                    NumLibreta1 = NumLibreta0;
                    Nombre0 = nombre;
                    NumLibreta0 = numlibretas;
                }
                else
                {
                    Nombre1 = nombre;
                    NumLibreta1 = numlibretas;
                }
            }
            else if (Orden == 2)
            {
                if (numlibretas < NumLibreta0)
                {
                    Nombre2 = Nombre1;
                    NumLibreta2 = NumLibreta1;
                    Nombre1 = Nombre0;
                    NumLibreta1 = NumLibreta0;
                    Nombre0 = nombre;
                    NumLibreta0 = numlibretas;
                }
                if (numlibretas < NumLibreta1)
                {
                    Nombre2 = Nombre1;
                    NumLibreta2 = NumLibreta1;
                    Nombre1 = nombre;
                    NumLibreta1 = numlibretas;
                }
                else
                {
                    Nombre2 = nombre;
                    NumLibreta2 = numlibretas;
                }
            }
            Orden++;
        }
    }
}
