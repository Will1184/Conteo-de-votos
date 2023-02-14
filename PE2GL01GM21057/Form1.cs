// Evaluado:#2
// Ejercicio:
// Fecha: 13/10/2022
// Autor: BRANDON WILLIAM GOMEZ MONGE
// Carnet: GM21057
// GD: #1
// GT: #1
// Instructora: ING. NELLY LISSETTE HENRIQUEZ SANCHEZ
using static System.Net.Mime.MediaTypeNames;

namespace PE2GL01GM21057
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool validar()
        {
            bool validacion=false;
          
            if (textBoxName.Text == string.Empty)
            {
                errorProvider.SetError(textBoxName, "Ingrese el Nombre");
                validacion = false;
            }
            if (textBoxName.Text == string.Empty)
            {
                errorProvider.SetError(textBoxPassword, "Ingrese el Password");
                validacion = false;
            }

            if ((textBoxName.Text.Equals("JUAN PEREZ")) && (textBoxPassword.Text.Equals("IAI115")))
            {
                validacion = true;
            }

            return validacion;
        }
        private void buttonInciarSesion_Click(object sender, EventArgs e)
        {
           if (validar())
            {
                Votos votos = new Votos();
                votos.MostrarDatos(dataGridVotos, dataGridPartidosVotos, dataGridTotalVotos, dataGridGanadores);

            }
           else
            {
               MessageBox.Show("USUARIO O CONTRASEÑA NO ES VALIDA","ERROR");
            }



        }

       
    }
}