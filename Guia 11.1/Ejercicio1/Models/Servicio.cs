using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    internal class Servicio
    {
        public int acumulador;
        public int contador;
        public int Maximo;
        public int Minimo;

        public Servicio()
        {
            acumulador = 0;
            contador = 0;
        }

        public void RegistrarValor(int valor)
        {
            acumulador += valor;

            if (valor > Maximo)
            {
                Maximo = valor;
            }
            if (valor < Minimo)
            {
                Minimo = valor;
            }
            contador++;
        }
        public double CalcularPromedio()
        {
            double promedio = 0;
            if (contador > 0)
                promedio = 1.0 * acumulador / contador;
            return promedio;
        }
    }
}
