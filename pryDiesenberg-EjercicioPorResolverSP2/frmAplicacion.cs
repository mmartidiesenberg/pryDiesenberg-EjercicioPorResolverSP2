using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryDiesenberg_EjercicioPorResolverSP2
{
    public partial class frmAplicacion : Form
    {
        int Distancia;
        int Dias; 
        public frmAplicacion()
        {
            InitializeComponent();
        }
        
        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int Distancia = int.Parse(mskDistancia.Text);
            int Dias = int.Parse(txtDias.Text);
            if (Distancia == 0 && Dias == 0)
            {
                MessageBox.Show("Ingrese Datos Válidos");
                return;
            }
            int distanciaTotal = Distancia * 2;
            int precio = distanciaTotal * 5;
            if (Distancia >= 100 && Dias >= 7)
            {
                precio = precio / 2;
            }
            MessageBox.Show("El precio del boleto es: $" + precio);
        }

        private void frmAplicacion_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
    
