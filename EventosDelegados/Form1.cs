using Delegado.Clasesdelegadas;
using System.Security.Cryptography.X509Certificates;

namespace EventosDelegados
{
    public partial class Form1 : Form
    {
        public delegate string Sirviente(string m);
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonDele_Click(object sender, EventArgs e)
        {
            Sirviente señor = new Sirviente(Radio.Mensaje);
            MessageBox.Show(señor("Mitologia griega"));
        }

        private void Cosocaja_Popup(object sender, PopupEventArgs e)
        {

        }

        private void Botontele_Click(object sender, EventArgs e)
        {
            Sirviente señor = new Sirviente(Television.Mostratele);
            MessageBox.Show(señor("Deporte extremo"));
        }

        private void Pasarboton1(object sender, EventArgs e)
        {
            Imagenpro.ImageLocation = "C://Users//camba//Downloads//Perro.png";
        }

        private void Imagenpro_Click(object sender, EventArgs e)
        {
            MessageBox.Show("*Explosión.png");
        }

        private void PasarBoton2(object sender, EventArgs e)
        {
            Imagenpro.ImageLocation = "C://Users//camba//Downloads//Graciaspe.jpg";
        }

        private void Pasarfoto(object sender, EventArgs e)
        {
            Mostrarlabel.Text = "Adios";
        }

        private void Quitarfoto(object sender, EventArgs e)
        {
            Mostrarlabel.Text = "Hola";
        }
    }
}
