using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pjTransporte
{
    public partial class frmPractica : Form
    {
        Moto[] Motos = new Moto[10];
        public frmPractica()
        {
            InitializeComponent();
        }
        private void buttRegistrar_Click(object sender, EventArgs e)
        {
            if (txtTipo.Text != "(Seleccione)")
            {
                if (txtEstado.Text != "(Seleccione)")
                {
                    if (txtMotor.Text != "(Seleccione)")
                    {
                        if (txtMarca.Text != "(Seleccione)")
                        {
                            Datos();
                            ListViewItem info = new ListViewItem(Motos[0].Tipo);
                            info.SubItems.Add(Motos[0].Estado);
                            info.SubItems.Add(txtMotor.Text);
                            info.SubItems.Add(Motos[0].DeterPrecio().ToString());
                            info.SubItems.Add(Motos[0].GeneradorCodigo().ToString());
                            info.SubItems.Add(txtMarca.Text);
                            lvInfo.Items.Add(info);
                        }
                        else
                        {
                            MessageBox.Show("Erro en la seleccion de la marca", "Notificacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtMarca.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error en la seleccion del motor", "Notificacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtMotor.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Error en la seleccion del estado", "Notificacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtEstado.Focus();
                }
            }
            else
            {
                MessageBox.Show("Error en la seleccion del tipo", "Notificacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTipo.Focus();
            }
        }
        public void Datos()
        {
            int motor = 0;
            switch (txtMotor.Text)
            {
                case "Pequeño": motor = 1; break;
                case "Mediano": motor = 2; break;
                case "Grande": motor = 3; break;
            }
            Motos[0] = new Moto(motor, txtTipo.Text, txtEstado.Text, 0);
        }
    }
}