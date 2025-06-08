using Ejercicio1.Models;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        Servicio servicios = new Servicio();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegistrarValor_Click(object sender, EventArgs e)
        {
            int valor = Convert.ToInt32(tbNumero.Text);
            servicios.RegistrarValor(valor);
            tbNumero.Clear();
        }

        private void btnActualizarMaxyMin_Click(object sender, EventArgs e)
        {
            if (servicios.contador > 0)
            {
                lbMaximo.Text = $"{servicios.Maximo}";
                lbMinimo.Text = $"{servicios.Minimo}";
            }
            else
            {
                lbMaximo.Text = $"No existen valores";
                lbMinimo.Text = $"No existen valores";
            }
        }

        private void btnActualizarPromedio_Click(object sender, EventArgs e)
        {
            if (servicios.contador > 0)
            {
                lbPromedio.Text = $"{servicios.CalcularPromedio()}";
            }
            else
            {
                lbPromedio.Text = $"No existen valores";
            }
        }

        private void btnVerCantidad_Click(object sender, EventArgs e)
        {
            if (servicios.contador > 0)
            {
                lbCantidad.Text = $"{servicios.contador}";
            }
            else
            {
                lbCantidad.Text = $"No existen valores";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            servicios = new Servicio();
        }
    }
}
