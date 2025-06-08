using Ejercicio2.Models;

namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        Servicios servicios = new Servicios();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegistrarMonto_Click(object sender, EventArgs e)
        {
            double montorepartir = Convert.ToDouble(tbMonto.Text);
            servicios.RegistrarMontoRepartir(montorepartir);

        }

        private void btnRegistrarEdades_Click(object sender, EventArgs e)
        {
            int edades = Convert.ToInt32(tbEdad1.Text);
            servicios.RegistrarEdades(edades, 0);

            edades = Convert.ToInt32(tbEdad2.Text);
            servicios.RegistrarEdades(edades, 1);

            edades = Convert.ToInt32(tbEdad3.Text);
            servicios.RegistrarEdades(edades, 2);

            edades = Convert.ToInt32(tbEdad4.Text);
            servicios.RegistrarEdades(edades, 3);
        }

        private void btnMontoyPorcentaje_Click(object sender, EventArgs e)
        {
            servicios.CalcularMontoyPorcentaje();

            tbResultados.Text = $@"Niña 1 ({servicios.Edad0}), Porcentaje: ({servicios.Porcentaje0}), Monto: ${servicios.Monto0:f2}
Niña 2 ({servicios.Edad1}), Porcentaje: ({servicios.Porcentaje1}), Monto: ${servicios.Monto1:f2}
Niña 3 ({servicios.Edad2}), Porcentaje: ({servicios.Porcentaje2}), Monto: ${servicios.Monto2:f2}
Niña 4 ({servicios.Edad3}), Porcentaje: ({servicios.Porcentaje3}), Monto: ${servicios.Monto3:f2}";
        }
    }
}
