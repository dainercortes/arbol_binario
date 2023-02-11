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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Escenario1 escenario1 = new Escenario1();

            this.Hide();
            escenario1.ShowDialog();
            this.Close();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Escenario2 escenario2 = new Escenario2();

            this.Hide();
            escenario2.ShowDialog();
            this.Close();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
