using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace ProyectoTelegramas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcularPrecio_Click(object sender, EventArgs e)
        {
            string textoTelegrama;
            int numPalabras = 0;
            double coste = 0.0;
            //Leo el telegrama  
            textoTelegrama = txtTelegrama.Text;
            // telegrama urgente? 
            //Obtengo el número de palabras que forma el telegrama  
            string[] palabras = textoTelegrama.Split(' '); //separa las palabras y las introduce en una estructura
            numPalabras = palabras.Length; //Obtiene la longitud de la estructura, que será el número de palabras
            if (Ordinario.Checked)
            {
                if (numPalabras <= 10)
                {
                    coste = 3.0;
                }
                else
                {
                    coste = 3.0 + 0.5 * (numPalabras - 10);
                }
            }
            else
            {
                if (numPalabras <= 10)
                {
                    coste = 6.0;
                }
                else
                {
                    coste = 6.0 + 0.75 * (numPalabras - 10);
                }
            }
            txtPrecio.Text = coste.ToString() + " euros";
        }

        private void Ordinario_CheckedChanged(object sender, EventArgs e)
        {
            string textoTelegrama;
            textoTelegrama = txtTelegrama.Text;
            string[] palabras = textoTelegrama.Split(' ');
            int numPalabras = palabras.Length;
            double coste = 0.0;
            if (numPalabras <= 10)
            {
                 coste = 2.5;
            }
            else
            {
                 coste = 2.50 + 0.5 * (numPalabras - 10);
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            string textoTelegrama;
            textoTelegrama = txtTelegrama.Text;
            string[] palabras = textoTelegrama.Split(' ');
            int numPalabras = palabras.Length;
            double coste = 0.0;
            if (numPalabras <= 10)
            {
                 coste = 5;
            }
            else
            {
                 coste = 5 + 0.75 * (numPalabras - 10);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

