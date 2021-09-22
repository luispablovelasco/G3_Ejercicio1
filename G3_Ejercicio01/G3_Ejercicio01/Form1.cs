using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G3_Ejercicio01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtletrascuenta_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Hacemos que por defecto al cambiar el combobox de tipo de cuenta ya nos ponga el codigo respectivo
            if (cmbtcuenta.SelectedItem.ToString() == "Cuenta Corriente")
            {
                txtletrascuenta.Text = "CC-";

            }
            if (cmbtcuenta.SelectedItem.ToString() == "Cuenta de Ahorros")
            {
                txtletrascuenta.Text = "CA-";
            }
            if (cmbtcuenta.SelectedItem.ToString() == "Cuenta a Plazos")
            {
                txtletrascuenta.Text = "CP-";
            }
            if (cmbtcuenta.SelectedItem.ToString() == "")
            {
                txtletrascuenta.Text = "---";
            }

        }
    }
}
