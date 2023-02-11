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
    public partial class Escenario2 : Form
    {
        private Font fuente;
        private Font resultado;
        private Color colorBorde;

        public Escenario2()
        {
            InitializeComponent();
            this.fuente = new Font("Arial", 14);
            this.resultado = new Font("Arial", 12);
            this.colorBorde = Color.FromArgb(255, 135, 135);
        }

        private void Escenario2_MouseMove(object sender, MouseEventArgs e)
        {
            this.txtX.Text = e.X.ToString();
            this.txtY.Text = e.Y.ToString();
        }

        private void Escenario2_MouseLeave(object sender, EventArgs e)
        {
            this.txtX.Clear();
            this.txtY.Clear();
        }

        private void gáficaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Pen bordeNodo = new Pen(Color.LimeGreen, 3);
                Pen lineaNodo = new Pen(Color.Black, 3);

                this.lblMensaje.Visible = false;

                //--------------------------------------------------------------------
                //Creación de los nodos
                //Nodo Raiz
                Graphics nodo;
                nodo = CreateGraphics();
                nodo.FillEllipse(Brushes.LightGreen, 495, 73, 60, 60);
                nodo.DrawString("15", fuente, Brushes.Black, 508, 90);
                nodo.DrawEllipse(bordeNodo, 495, 73, 60, 60);

                //Subnodo 1 del arbol izquierdo
                nodo = CreateGraphics();
                nodo.FillEllipse(Brushes.LightGreen, 260, 178, 60, 60);
                nodo.DrawString("6", fuente, Brushes.Black, 280, 195);
                nodo.DrawEllipse(bordeNodo, 260, 178, 60, 60);

                //Subnodo 2 del arbol izquierdo
                nodo = CreateGraphics();
                nodo.FillEllipse(Brushes.LightGreen, 130, 283, 60, 60);
                nodo.DrawString("3", fuente, Brushes.Black, 150, 300);
                nodo.DrawEllipse(bordeNodo, 130, 283, 60, 60);

                //Subnodo 3 del arbol izquierdo
                nodo = CreateGraphics();
                nodo.FillEllipse(Brushes.LightGreen, 60, 378, 60, 60);
                nodo.DrawString("1", fuente, Brushes.Black, 80, 395);
                nodo.DrawEllipse(bordeNodo, 60, 378, 60, 60);              

                //Subnodo 4 del arbol izquierdo
                nodo = CreateGraphics();
                nodo.FillEllipse(Brushes.LightGreen, 200, 378, 60, 60);
                nodo.DrawString("4", fuente, Brushes.Black, 220, 395);
                nodo.DrawEllipse(bordeNodo, 200, 378, 60, 60);

                //Subnodo 5 del arbol izquierdo
                nodo = CreateGraphics();
                nodo.FillEllipse(Brushes.LightGreen, 370, 283, 60, 60);
                nodo.DrawString("9", fuente, Brushes.Black, 390, 300);
                nodo.DrawEllipse(bordeNodo, 370, 283, 60, 60);

                //Subnodo 6 del arbol izquierdo
                nodo = CreateGraphics();
                nodo.FillEllipse(Brushes.LightGreen, 300, 378, 60, 60);
                nodo.DrawString("7", fuente, Brushes.Black, 320, 395);
                nodo.DrawEllipse(bordeNodo, 300, 378, 60, 60);

                //Subnodo 7 del arbol izquierdo
                nodo = CreateGraphics();
                nodo.FillEllipse(Brushes.LightGreen, 440, 378, 60, 60);
                nodo.DrawString("12", fuente, Brushes.Black, 455, 395);
                nodo.DrawEllipse(bordeNodo, 440, 378, 60, 60);

                //--------------------------------------------------------------------
                //Subnodo 1 del arbol derecho
                nodo = CreateGraphics();
                nodo.FillEllipse(Brushes.LightGreen, 740, 178, 60, 60);
                nodo.DrawString("20", fuente, Brushes.Black, 755, 195);
                nodo.DrawEllipse(bordeNodo, 740, 178, 60, 60);

                //Subnodo 2 del arbol derecho
                nodo = CreateGraphics();
                nodo.FillEllipse(Brushes.LightGreen, 660, 283, 60, 60);
                nodo.DrawString("18", fuente, Brushes.Black, 675, 300);
                nodo.DrawEllipse(bordeNodo, 660, 283, 60, 60);

                //Subnodo 3 del arbol derecho
                nodo = CreateGraphics();
                nodo.FillEllipse(Brushes.LightGreen, 580, 378, 60, 60);
                nodo.DrawString("17", fuente, Brushes.Black, 595, 395);
                nodo.DrawEllipse(bordeNodo, 580, 378, 60, 60);

                //Subnodo 4 del arbol derecho
                nodo = CreateGraphics();
                nodo.FillEllipse(Brushes.LightGreen, 810, 283, 60, 60);
                nodo.DrawString("24", fuente, Brushes.Black, 825, 300);
                nodo.DrawEllipse(bordeNodo, 810, 283, 60, 60);

                //--------------------------------------------------------------------
                //Linea 1 arbol izquierdo
                nodo.DrawLine(lineaNodo, 498, 119, 314, 191);

                //Linea 2 arbol izquierdo
                nodo.DrawLine(lineaNodo, 263, 226, 178, 288);

                //Linea 3 arbol izquierdo
                nodo.DrawLine(lineaNodo, 313, 226, 385, 288);

                //Linea 4 arbol izquierdo
                nodo.DrawLine(lineaNodo, 138, 336, 103, 380);

                //Linea 5 arbol izquierdo
                nodo.DrawLine(lineaNodo, 180, 336, 215, 380);

                //Linea 6 arbol izquierdo
                nodo.DrawLine(lineaNodo, 378, 336, 343, 380);

                //Linea 6 arbol izquierdo
                nodo.DrawLine(lineaNodo, 422, 336, 454, 380);

                //--------------------------------------------------------------------
                //Linea 1 arbol derecho
                nodo.DrawLine(lineaNodo, 550, 119, 744, 191);

                //Linea 2 arbol derecho
                nodo.DrawLine(lineaNodo, 748, 229, 706, 288);

                //Linea 3 arbol derecho
                nodo.DrawLine(lineaNodo, 667, 336, 629, 385);

                //Linea 4 arbol derecho
                nodo.DrawLine(lineaNodo, 793, 229, 830, 285);

                recorridosToolStripMenuItem.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Pre-Orden
        private void preOrden()
        {
            try
            {
                Pen bordeNodo = new Pen(colorBorde, 3);

                Graphics nodo;
                nodo = CreateGraphics();
                nodo.DrawString("PreOrden:", resultado, Brushes.Black, 11, 597);

                nodo = CreateGraphics();
                nodo.DrawString("15", fuente, Brushes.Black, 139, 588);
                nodo.DrawEllipse(bordeNodo, 130, 575, 50, 50);

                nodo = CreateGraphics();
                nodo.DrawString("6", fuente, Brushes.Black, 205, 588);
                nodo.DrawEllipse(bordeNodo, 190, 575, 50, 50);

                nodo = CreateGraphics();
                nodo.DrawString("3", fuente, Brushes.Black, 265, 588);
                nodo.DrawEllipse(bordeNodo, 250, 575, 50, 50);

                nodo = CreateGraphics();
                nodo.DrawString("1", fuente, Brushes.Black, 325, 588);
                nodo.DrawEllipse(bordeNodo, 310, 575, 50, 50);

                nodo = CreateGraphics();
                nodo.DrawString("4", fuente, Brushes.Black, 385, 588);
                nodo.DrawEllipse(bordeNodo, 370, 575, 50, 50);

                nodo = CreateGraphics();
                nodo.DrawString("9", fuente, Brushes.Black, 445, 588);
                nodo.DrawEllipse(bordeNodo, 430, 575, 50, 50);

                nodo = CreateGraphics();
                nodo.DrawString("7", fuente, Brushes.Black, 505, 588);
                nodo.DrawEllipse(bordeNodo, 490, 575, 50, 50);

                nodo = CreateGraphics();
                nodo.DrawString("12", fuente, Brushes.Black, 559, 588);
                nodo.DrawEllipse(bordeNodo, 550, 575, 50, 50);

                nodo = CreateGraphics();
                nodo.DrawString("20", fuente, Brushes.Black, 619, 588);
                nodo.DrawEllipse(bordeNodo, 610, 575, 50, 50);

                nodo = CreateGraphics();
                nodo.DrawString("18", fuente, Brushes.Black, 679, 588);
                nodo.DrawEllipse(bordeNodo, 670, 575, 50, 50);

                nodo = CreateGraphics();
                nodo.DrawString("17", fuente, Brushes.Black, 739, 588);
                nodo.DrawEllipse(bordeNodo, 730, 575, 50, 50);

                nodo = CreateGraphics();
                nodo.DrawString("24", fuente, Brushes.Black, 799, 588);
                nodo.DrawEllipse(bordeNodo, 790, 575, 50, 50);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            
        }

        //In-Orden
        private void inOrden()
        {
            try
            {
                Pen bordeNodo = new Pen(colorBorde, 3);

                Graphics nodo;
                nodo = CreateGraphics();
                nodo.DrawString("InOrden:", resultado, Brushes.Black, 11, 672);

                nodo = CreateGraphics();
                nodo.DrawString("1", fuente, Brushes.Black, 145, 663);
                nodo.DrawEllipse(bordeNodo, 130, 650, 50, 50);

                nodo = CreateGraphics();
                nodo.DrawString("3", fuente, Brushes.Black, 205, 663f);
                nodo.DrawEllipse(bordeNodo, 190, 650, 50, 50);

                nodo = CreateGraphics();
                nodo.DrawString("4", fuente, Brushes.Black, 265, 663);
                nodo.DrawEllipse(bordeNodo, 250, 650, 50, 50);

                nodo = CreateGraphics();
                nodo.DrawString("6", fuente, Brushes.Black, 325, 663);
                nodo.DrawEllipse(bordeNodo, 310, 650, 50, 50);

                nodo = CreateGraphics();
                nodo.DrawString("7", fuente, Brushes.Black, 385, 663);
                nodo.DrawEllipse(bordeNodo, 370, 650, 50, 50);

                nodo = CreateGraphics();
                nodo.DrawString("9", fuente, Brushes.Black, 445, 663);
                nodo.DrawEllipse(bordeNodo, 430, 650, 50, 50);

                nodo = CreateGraphics();
                nodo.DrawString("12", fuente, Brushes.Black, 499, 663);
                nodo.DrawEllipse(bordeNodo, 490, 650, 50, 50);

                nodo = CreateGraphics();
                nodo.DrawString("15", fuente, Brushes.Black, 559, 663);
                nodo.DrawEllipse(bordeNodo, 550, 650, 50, 50);

                nodo = CreateGraphics();
                nodo.DrawString("17", fuente, Brushes.Black, 619, 663);
                nodo.DrawEllipse(bordeNodo, 610, 650, 50, 50);

                nodo = CreateGraphics();
                nodo.DrawString("18", fuente, Brushes.Black, 679, 663);
                nodo.DrawEllipse(bordeNodo, 670, 650, 50, 50);

                nodo = CreateGraphics();
                nodo.DrawString("20", fuente, Brushes.Black, 739, 663);
                nodo.DrawEllipse(bordeNodo, 730, 650, 50, 50);

                nodo = CreateGraphics();
                nodo.DrawString("24", fuente, Brushes.Black, 799, 663);
                nodo.DrawEllipse(bordeNodo, 790, 650, 50, 50);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }           
        }

        //Post-Orden
        private void postOrden()
        {
            try
            {
                Pen bordeNodo = new Pen(colorBorde, 3);

                Graphics nodo;
                nodo = CreateGraphics();
                nodo.DrawString("PostOrden:", resultado, Brushes.Black, 10, 747);

                nodo = CreateGraphics();
                nodo.DrawString("1", fuente, Brushes.Black, 145, 738);
                nodo.DrawEllipse(bordeNodo, 130, 725, 50, 50);

                nodo = CreateGraphics();
                nodo.DrawString("4", fuente, Brushes.Black, 205, 738);
                nodo.DrawEllipse(bordeNodo, 190, 725, 50, 50);

                nodo = CreateGraphics();
                nodo.DrawString("3", fuente, Brushes.Black, 265, 738);
                nodo.DrawEllipse(bordeNodo, 250, 725, 50, 50);

                nodo = CreateGraphics();
                nodo.DrawString("7", fuente, Brushes.Black, 325, 738);
                nodo.DrawEllipse(bordeNodo, 310, 725, 50, 50);

                nodo = CreateGraphics();
                nodo.DrawString("12", fuente, Brushes.Black, 379, 738);
                nodo.DrawEllipse(bordeNodo, 370, 725, 50, 50);

                nodo = CreateGraphics();
                nodo.DrawString("9", fuente, Brushes.Black, 445, 738);
                nodo.DrawEllipse(bordeNodo, 430, 725, 50, 50);

                nodo = CreateGraphics();
                nodo.DrawString("6", fuente, Brushes.Black, 505, 738);
                nodo.DrawEllipse(bordeNodo, 490, 725, 50, 50);

                nodo = CreateGraphics();
                nodo.DrawString("17", fuente, Brushes.Black, 559, 738);
                nodo.DrawEllipse(bordeNodo, 550, 725, 50, 50);

                nodo = CreateGraphics();
                nodo.DrawString("18", fuente, Brushes.Black, 619, 738);
                nodo.DrawEllipse(bordeNodo, 610, 725, 50, 50);

                nodo = CreateGraphics();
                nodo.DrawString("24", fuente, Brushes.Black, 679, 738);
                nodo.DrawEllipse(bordeNodo, 670, 725, 50, 50);

                nodo = CreateGraphics();
                nodo.DrawString("20", fuente, Brushes.Black, 739, 738);
                nodo.DrawEllipse(bordeNodo, 730, 725, 50, 50);

                nodo = CreateGraphics();
                nodo.DrawString("15", fuente, Brushes.Black, 799, 738);
                nodo.DrawEllipse(bordeNodo, 790, 725, 50, 50);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }           
        }

        private void recorridosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            preOrden();
            inOrden();
            postOrden();
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
