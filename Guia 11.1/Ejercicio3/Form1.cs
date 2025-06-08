using Ejercicio3.Models;

namespace Ejercicio3
{
    public partial class Form1 : Form
    {
        Servicios servicios = new Servicios();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrarEstudiante_Click(object sender, EventArgs e)
        {
            string nombre = tbNombre1.Text;
            int libreta = Convert.ToInt32(tbLibreta1.Text);
            servicios.RegistrarNombres_Libretas(nombre, libreta);

            nombre = tbNombre2.Text;
            libreta = Convert.ToInt32(tbLibreta2.Text);
            servicios.RegistrarNombres_Libretas(nombre, libreta);

            nombre = tbNombre3.Text;
            libreta = Convert.ToInt32(tbLibreta3.Text);
            servicios.RegistrarNombres_Libretas(nombre, libreta);
        }

        private void btnListaOrdenada_Click(object sender, EventArgs e)
        {
            tbResultadosOrdenados.Text = $@"{servicios.Nombre0}  :  {servicios.NumLibreta0}
{servicios.Nombre1}  :  {servicios.NumLibreta1}
{servicios.Nombre2}  :  {servicios.NumLibreta2}";
        }
    }
}
