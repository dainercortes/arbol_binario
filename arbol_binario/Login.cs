using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arbol_binario
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            if (txtContraseña.Text != "")
            {
                if (txtContraseña.Text == "123")
                {
                    Menu frmMenu = new Menu();

                    this.Hide();
                    frmMenu.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("La contraseña es incorrecta");
                }
            }
            else
            {
                MessageBox.Show("Ingrese una contraseña");
            }
        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            dtpFecha.Text = DateTime.Now.ToString();
        }
    }
}
