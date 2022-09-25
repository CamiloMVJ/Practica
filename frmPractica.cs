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
        int a = 0;
        public frmPractica()
        {
            InitializeComponent();
        }

        private void buttRegistrar_Click(object sender, EventArgs e)
        {
            Datos();
            ListViewItem info = new ListViewItem(Motos[0].Tipo);
            info.SubItems.Add(Motos[0].Estado);
            info.SubItems.Add(txtMotor.Text);
            info.SubItems.Add(Motos[0].DeterPrecio().ToString());
            lvInfo.Items.Add(info);
        }
        public void Datos()
        {
            int motor = 0;
            switch (txtMotor.Text)
            {
                case "Motor pequeño": motor = 1; break;
                case "Motor mediano": motor = 2; break;
                case "Motor grande": motor = 3; break;
            }
            Motos[a] = new Moto(motor, txtTipo.Text, txtEstado.Text, 0);
            
        }
    }
}
