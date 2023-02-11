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
    public partial class Escenario1 : Form
    {
        private Font fuente;
        private Font resultado;
        private Color colorBorde;

        public Escenario1()
        {
            InitializeComponent();
            this.fuente = new Font("Arial", 14);
            this.resultado = new Font("Arial", 12);
            this.colorBorde = Color.FromArgb(255, 135, 135); 
        }

        private void Escenario1_MouseMove(object sender, MouseEventArgs e)
        {
            this.txtX.Text = e.X.ToString();
            this.txtY.Text = e.Y.ToString();
        }

        private void Escenario1_MouseLeave(object sender, EventArgs e)
        {
            this.txtX.Clear();
            this.txtY.Clear();
        }

        private void gáficaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Pen bordeNodo = new Pen(this.colorBorde, 3);
                Pen lineaNodo = new Pen(Color.Black, 3);

                this.lblMensaje.Visible = false;

                //--------------------------------------------------------------------
                //Creación de los nodos
                //Nodo Raiz
                Graphics nodo;
                nodo = CreateGraphics();
                nodo.FillEllipse(Brushes.LightYellow, 495, 73, 60, 60);
                nodo.DrawString("13", fuente, Brushes.Black, 508, 90);
                nodo.DrawEllipse(bordeNodo, 495, 73, 60, 60);

                //Subnodo 1 del arbol izquierdo
                nodo = CreateGraphics();
                nodo.FillEllipse(Brushes.LightYellow, 300, 178, 60, 60);
                nodo.DrawString("4", fuente, Brushes.Black, 320, 195);
                nodo.DrawEllipse(bordeNodo, 300, 178, 60, 60);

                //Subnodo 2 del arbol izquierdo
                nodo = CreateGraphics();
                nodo.FillEllipse(Brushes.LightYellow, 200, 283, 60, 60);
                nodo.DrawString("3", fuente, Brushes.Black, 220, 300);
                nodo.DrawEllipse(bordeNodo, 200, 283, 60, 60);

                //Subnodo 3 del arbol izquierdo
                nodo = CreateGraphics();
                nodo.FillEllipse(Brushes.LightYellow, 400, 283, 60, 60);
                nodo.DrawString("11", fuente, Brushes.Black, 415, 300);
                nodo.DrawEllipse(bordeNodo, 400, 283, 60, 60);

                //Subnodo 4 del arbol izquierdo
                nodo = CreateGraphics();
                nodo.FillEllipse(Brushes.LightYellow, 300, 378, 60, 60);
                nodo.DrawString("8", fuente, Brushes.Black, 320, 395);
                nodo.DrawEllipse(bordeNodo, 300, 378, 60, 60);

                //Subnodo 5 del arbol izquierdo
                nodo = CreateGraphics();
                nodo.FillEllipse(Brushes.LightYellow, 200, 473, 60, 60);
                nodo.DrawString("6", fuente, Brushes.Black, 220, 490);
                nodo.DrawEllipse(bordeNodo, 200, 473, 60, 60);

                //Subnodo 6 del arbol izquierdo
                nodo = CreateGraphics();
                nodo.FillEllipse(Brushes.LightYellow, 100, 568, 60, 60);
                nodo.DrawString("5", fuente, Brushes.Black, 120, 585);
                nodo.DrawEllipse(bordeNodo, 100, 568, 60, 60);

                //Subnodo 7 del arbol izquierdo
                nodo = CreateGraphics();
                nodo.FillEllipse(Brushes.LightYellow, 300, 568, 60, 60);
                nodo.DrawString("7", fuente, Brushes.Black, 320, 585);
                nodo.DrawEllipse(bordeNodo, 300, 568, 60, 60);

                //--------------------------------------------------------------------
                //Subnodo 1 del arbol derecho
                nodo = CreateGraphics();
                nodo.FillEllipse(Brushes.LightYellow, 690, 178, 60, 60);
                nodo.DrawString("15", fuente, Brushes.Black, 705, 195);
                nodo.DrawEllipse(bordeNodo, 690, 178, 60, 60);

                //Subnodo 2 del arbol derecho
                nodo = CreateGraphics();
                nodo.FillEllipse(Brushes.LightYellow, 590, 283, 60, 60);
                nodo.DrawString("14", fuente, Brushes.Black, 605, 300);
                nodo.DrawEllipse(bordeNodo, 590, 283, 60, 60);

                //Subnodo 3 del arbol derecho
                nodo = CreateGraphics();
                nodo.FillEllipse(Brushes.LightYellow, 790, 283, 60, 60);
                nodo.DrawString("18", fuente, Brushes.Black, 805, 300);
                nodo.DrawEllipse(bordeNodo, 790, 283, 60, 60);

                //Subnodo 4 del arbol derecho
                nodo = CreateGraphics();
                nodo.FillEllipse(Brushes.LightYellow, 690, 378, 60, 60);
                nodo.DrawString("16", fuente, Brushes.Black, 705, 395);
                nodo.DrawEllipse(bordeNodo, 690, 378, 60, 60);

                //Subnodo 5 del arbol derecho
                nodo = CreateGraphics();
                nodo.FillEllipse(Brushes.LightYellow, 890, 378, 60, 60);
                nodo.DrawString("20", fuente, Brushes.Black, 905, 395);
                nodo.DrawEllipse(bordeNodo, 890, 378, 60, 60);

                //Subnodo 6 del arbol derecho
                nodo = CreateGraphics();
                nodo.FillEllipse(Brushes.LightYellow, 790, 473, 60, 60);
                nodo.DrawString("17", fuente, Brushes.Black, 805, 490);
                nodo.DrawEllipse(bordeNodo, 790, 473, 60, 60);

                //--------------------------------------------------------------------
                //Linea 1 arbol izquierdo
                nodo.DrawLine(lineaNodo, 498, 119, 356, 191);

                //Linea 2 arbol izquierdo
                nodo.DrawLine(lineaNodo, 307, 226, 247, 288);

                //Linea 3 arbol izquierdo
                nodo.DrawLine(lineaNodo, 355, 226, 410, 288);

                //Linea 4 arbol izquierdo
                nodo.DrawLine(lineaNodo, 407, 336, 354, 388);

                //Linea 5 arbol izquierdo
                nodo.DrawLine(lineaNodo, 307, 429, 249, 480);

                //Linea 6 arbol izquierdo
                nodo.DrawLine(lineaNodo, 208, 525, 151, 576);

                //Linea 6 arbol izquierdo
                nodo.DrawLine(lineaNodo, 251, 525, 308, 577);

                //--------------------------------------------------------------------
                //Linea 1 arbol derecho
                nodo.DrawLine(lineaNodo, 550, 119, 695, 190);

                //Linea 2 arbol derecho
                nodo.DrawLine(lineaNodo, 697, 229, 639, 288);

                //Linea 3 arbol derecho
                nodo.DrawLine(lineaNodo, 744, 229, 804, 288);

                //Linea 4 arbol derecho
                nodo.DrawLine(lineaNodo, 797, 333, 742, 388);

                //Linea 5 arbol derecho
                nodo.DrawLine(lineaNodo, 845, 329, 898, 388);

                //Linea 6 arbol derecho
                nodo.DrawLine(lineaNodo, 740, 433, 796, 482);

                recorridosToolStripMenuItem.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }           
        }

        private void preOrdenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Pen bordeNodo = new Pen(Color.LimeGreen, 3);

                Graphics nodo;
                nodo = CreateGraphics();
                nodo.DrawString("PreOrden:", resultado, Brushes.Black, 11, 697);

                nodo = CreateGraphics();
                nodo.DrawString("13", fuente, Brushes.Black, 139, 688);
                nodo.DrawEllipse(bordeNodo, 130, 675, 50, 50);

                nodo = CreateGraphics();
                nodo.DrawString("4", fuente, Brushes.Black, 205, 688);
                nodo.DrawEllipse(bordeNodo, 190, 675, 50, 50);

                nodo = CreateGraphics();
                nodo.DrawString("3", fuente, Brushes.Black, 265, 688);
                nodo.DrawEllipse(bordeNodo, 250, 675, 50, 50);

                nodo = CreateGraphics();
                nodo.DrawString("11", fuente, Brushes.Black, 319, 688);
                nodo.DrawEllipse(bordeNodo, 310, 675, 50, 50);

                nodo = CreateGraphics();
                nodo.DrawString("8", fuente, Brushes.Black, 385, 688);
                nodo.DrawEllipse(bordeNodo, 370, 675, 50, 50);

                nodo = CreateGraphics();
                nodo.DrawString("6", fuente, Brushes.Black, 445, 688);
                nodo.DrawEllipse(bordeNodo, 430, 675, 50, 50);

                nodo = CreateGraphics();
                nodo.DrawString("5", fuente, Brushes.Black, 505, 688);
                nodo.DrawEllipse(bordeNodo, 490, 675, 50, 50);

                nodo = CreateGraphics();
                nodo.DrawString("7", fuente, Brushes.Black, 565, 688);
                nodo.DrawEllipse(bordeNodo, 550, 675, 50, 50);

                nodo = CreateGraphics();
                nodo.DrawString("15", fuente, Brushes.Black, 619, 688);
                nodo.DrawEllipse(bordeNodo, 610, 675, 50, 50);

                nodo = CreateGraphics();
                nodo.DrawString("14", fuente, Brushes.Black, 679, 688);
                nodo.DrawEllipse(bordeNodo, 670, 675, 50, 50);

                nodo = CreateGraphics();
                nodo.DrawString("18", fuente, Brushes.Black, 739, 688);
                nodo.DrawEllipse(bordeNodo, 730, 675, 50, 50);

                nodo = CreateGraphics();
                nodo.DrawString("16", fuente, Brushes.Black, 799, 688);
                nodo.DrawEllipse(bordeNodo, 790, 675, 50, 50);

                nodo = CreateGraphics();
                nodo.DrawString("17", fuente, Brushes.Black, 859, 688);
                nodo.DrawEllipse(bordeNodo, 850, 675, 50, 50);

                nodo = CreateGraphics();
                nodo.DrawString("20", fuente, Brushes.Black, 919, 688);
                nodo.DrawEllipse(bordeNodo, 910, 675, 50, 50);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }        
        }

        private void inOrdenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Pen bordeNodo = new Pen(Color.LimeGreen, 3);

                Graphics nodo;
                nodo = CreateGraphics();
                nodo.DrawString("InOrden:", resultado, Brushes.Black, 11, 772);

                nodo = CreateGraphics();
                nodo.DrawString("3", fuente, Brushes.Black, 145, 763);
                nodo.DrawEllipse(bordeNodo, 130, 750, 50, 50);

                nodo = CreateGraphics();
                nodo.DrawString("4", fuente, Brushes.Black, 205, 763);
                nodo.DrawEllipse(bordeNodo, 190, 750, 50, 50);

                nodo = CreateGraphics();
                nodo.DrawString("5", fuente, Brushes.Black, 265, 763);
                nodo.DrawEllipse(bordeNodo, 250, 750, 50, 50);

                nodo = CreateGraphics();
                nodo.DrawString("6", fuente, Brushes.Black, 325, 763);
                nodo.DrawEllipse(bordeNodo, 310, 750, 50, 50);

                nodo = CreateGraphics();
                nodo.DrawString("7", fuente, Brushes.Black, 385, 763);
                nodo.DrawEllipse(bordeNodo, 370, 750, 50, 50);

                nodo = CreateGraphics();
                nodo.DrawString("8", fuente, Brushes.Black, 445, 763);
                nodo.DrawEllipse(bordeNodo, 430, 750, 50, 50);

                nodo = CreateGraphics();
                nodo.DrawString("11", fuente, Brushes.Black, 499, 763);
                nodo.DrawEllipse(bordeNodo, 490, 750, 50, 50);

                nodo = CreateGraphics();
                nodo.DrawString("13", fuente, Brushes.Black, 559, 763);
                nodo.DrawEllipse(bordeNodo, 550, 750, 50, 50);

                nodo = CreateGraphics();
                nodo.DrawString("14", fuente, Brushes.Black, 619, 763);
                nodo.DrawEllipse(bordeNodo, 610, 750, 50, 50);

                nodo = CreateGraphics();
                nodo.DrawString("15", fuente, Brushes.Black, 679, 763);
                nodo.DrawEllipse(bordeNodo, 670, 750, 50, 50);

                nodo = CreateGraphics();
                nodo.DrawString("16", fuente, Brushes.Black, 739, 763);
                nodo.DrawEllipse(bordeNodo, 730, 750, 50, 50);

                nodo = CreateGraphics();
                nodo.DrawString("17", fuente, Brushes.Black, 799, 763);
                nodo.DrawEllipse(bordeNodo, 790, 750, 50, 50);

                nodo = CreateGraphics();
                nodo.DrawString("18", fuente, Brushes.Black, 859, 763);
                nodo.DrawEllipse(bordeNodo, 850, 750, 50, 50);

                nodo = CreateGraphics();
                nodo.DrawString("20", fuente, Brushes.Black, 919, 763);
                nodo.DrawEllipse(bordeNodo, 910, 750, 50, 50);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }          
        }

        private void postOrdenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Pen bordeNodo = new Pen(Color.LimeGreen, 3);

                Graphics nodo;
                nodo = CreateGraphics();
                nodo.DrawString("PostOrden:", resultado, Brushes.Black, 10, 847);

                nodo = CreateGraphics();
                nodo.DrawString("13", fuente, Brushes.Black, 139, 838);
                nodo.DrawEllipse(bordeNodo, 130, 825, 50, 50);

                nodo = CreateGraphics();
                nodo.DrawString("4", fuente, Brushes.Black, 205, 838);
                nodo.DrawEllipse(bordeNodo, 190, 825, 50, 50);

                nodo = CreateGraphics();
                nodo.DrawString("3", fuente, Brushes.Black, 265, 838);
                nodo.DrawEllipse(bordeNodo, 250, 825, 50, 50);

                nodo = CreateGraphics();
                nodo.DrawString("11", fuente, Brushes.Black, 319, 838);
                nodo.DrawEllipse(bordeNodo, 310, 825, 50, 50);

                nodo = CreateGraphics();
                nodo.DrawString("8", fuente, Brushes.Black, 385, 838);
                nodo.DrawEllipse(bordeNodo, 370, 825, 50, 50);

                nodo = CreateGraphics();
                nodo.DrawString("6", fuente, Brushes.Black, 445, 838);
                nodo.DrawEllipse(bordeNodo, 430, 825, 50, 50);

                nodo = CreateGraphics();
                nodo.DrawString("5", fuente, Brushes.Black, 505, 838);
                nodo.DrawEllipse(bordeNodo, 490, 825, 50, 50);

                nodo = CreateGraphics();
                nodo.DrawString("7", fuente, Brushes.Black, 565, 838);
                nodo.DrawEllipse(bordeNodo, 550, 825, 50, 50);

                nodo = CreateGraphics();
                nodo.DrawString("15", fuente, Brushes.Black, 619, 838);
                nodo.DrawEllipse(bordeNodo, 610, 825, 50, 50);

                nodo = CreateGraphics();
                nodo.DrawString("14", fuente, Brushes.Black, 679, 838);
                nodo.DrawEllipse(bordeNodo, 670, 825, 50, 50);

                nodo = CreateGraphics();
                nodo.DrawString("18", fuente, Brushes.Black, 739, 838);
                nodo.DrawEllipse(bordeNodo, 730, 825, 50, 50);

                nodo = CreateGraphics();
                nodo.DrawString("16", fuente, Brushes.Black, 799, 838);
                nodo.DrawEllipse(bordeNodo, 790, 825, 50, 50);

                nodo = CreateGraphics();
                nodo.DrawString("17", fuente, Brushes.Black, 859, 838);
                nodo.DrawEllipse(bordeNodo, 850, 825, 50, 50);

                nodo = CreateGraphics();
                nodo.DrawString("20", fuente, Brushes.Black, 919, 838);
                nodo.DrawEllipse(bordeNodo, 910, 825, 50, 50);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }          
        }

        private void volverAlMenúToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();

            this.Hide();
            menu.ShowDialog();
            this.Close();
        }
    }
}
