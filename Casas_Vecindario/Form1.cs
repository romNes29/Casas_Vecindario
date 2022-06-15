using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Datos;
namespace Casas_Vecindario
{
    public partial class VECINDARIO : Form
    {
        private ListaCasas casa_nueva = new ListaCasas();
        public VECINDARIO()
        {
            InitializeComponent();
        }

        private void VECINDARIO_Load(object sender, EventArgs e)
        {
            casa_nueva.cargar_lista_inicio();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if ((txtPoseeBalcon.Text.ToLower() != "si" && txtPoseeBalcon.Text.ToLower() != "no")||
                (txtAmueblado.Text.ToLower() != "si" && txtAmueblado.Text.ToLower() != "no") ||
                (txtPoseePiscina.Text.ToLower() != "si" && txtPoseePiscina.Text.ToLower() != "no"))
            {
                MessageBox.Show("Por favor ingrese solamente (Si o No)");

            }
            else
            {
                int numero_casa = int.Parse(txtNumeroCasa.Text);
                string propietario = txtPropietario.Text;
                int cantidad_pisos = int.Parse(txtPisos.Text);
                int cantidad_bannos = int.Parse(txtBannos.Text);
                string posee_balcon = txtPoseeBalcon.Text;
                int total_habitaciones = int.Parse(txtHabitaciones.Text);
                string amueblado = txtAmueblado.Text;
                string piscina = txtPoseePiscina.Text;
                casa_nueva.Registrar_casa(new Casa(numero_casa, propietario, cantidad_pisos, cantidad_bannos
                    ,posee_balcon, total_habitaciones, amueblado, piscina));

                MessageBox.Show("CASA REGISTRADA CON ÉXITO");
                limpiaEspacios();
            }
            {

            }

        }
            
        private void btnMostrarCasas_Click(object sender, EventArgs e)
        {
            foreach(Casa casa in casa_nueva.ListaCasa)
            {
                MessageBox.Show(casa.toSttring());
            }

        }

        private void btnCasasMasHabitaciones_Click(object sender, EventArgs e)
        {
            foreach (Casa casa in casa_nueva.ListaCasa)
            {
                if(casa.Total_habitaciones > 2)
                {
                    MessageBox.Show(casa.toSttring());
                }
            }
        }

        private void btnCasasPiscina_Click(object sender, EventArgs e)
        {
            foreach (Casa casa in casa_nueva.ListaCasa)
            {
                if (casa.Piscina.ToLower().Equals("si"))
                {
                    MessageBox.Show(casa.toSttring());
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            casa_nueva.almacenar_informacion();
            Application.Exit();
        }

        public void limpiaEspacios()
        {
            txtNumeroCasa.Text = "";
            txtPropietario.Text = "";
            txtPisos.Text = "";
            txtBannos.Text = "";
            txtPoseeBalcon.Text = "";
            txtHabitaciones.Text = "";
            txtAmueblado.Text = "";
            txtPoseePiscina.Text = "";
        }
        
    }
}
