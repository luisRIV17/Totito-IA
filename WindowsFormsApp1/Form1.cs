using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //tablero
        char[,] matriz = new char[3, 3]; 
        public void iniciomatriz()
        {
            for (int i = 0; i <= 2; i++)
            {
                for (int j = 0; j <= 2; j++)
                {
                    matriz[i, j] = '-';
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btn01.Click += btna1_Click;
            btn02.Click += btna1_Click;
            btn10.Click += btna1_Click;
            btn11.Click += btna1_Click;
            btn12.Click += btna1_Click;
            btn20.Click += btna1_Click;
            btn21.Click += btna1_Click;
            btn22.Click += btna1_Click;
            iniciomatriz();
          //  MovimientoComputadora();
        }
        public void juego(int f, int c,Button boton)
        {
            if (matriz[f, c] == '-')
            {
                
                boton.Text = "X";
                boton.ForeColor = Color.Red;
                matriz[f, c] = 'X';

                if (verifica('X',true))
                {
                    MessageBox.Show("¡Felicidades! Haz ganado");
                    reiniciar();
                    
                }
                else if (Empate())
                {
                    MessageBox.Show("¡Empate!");
                    reiniciar();
                   
                }
               
                lbturno.Text = "Computadora";
              
                
                MovimientoComputadora();
                if (verifica('O', true))
                {
                    MessageBox.Show("¡La computadora ha ganado!");
                    reiniciar();
                }
                else if (Empate())
                {
                    MessageBox.Show("¡Empate!");
                    reiniciar();
                }
                lbturno.Text = "Jugador";
            }
        }
      public void puntos(bool bandera, char pieza)
        {
            if (bandera == true && pieza == 'O')
                lbcp.Text = (Convert.ToInt16(lbcp.Text) + 1).ToString();
            if (bandera == true && pieza == 'X')
                lbpj.Text = (Convert.ToInt16(lbpj.Text) + 1).ToString();
        }
        private bool verifica(char pieza,bool ver)
        {
            for (int i = 0; i <= 2; i++)
            {
                if (matriz[i, 0] == pieza && matriz[i, 1] == pieza && matriz[i, 2] == pieza)
                {
                    if( ver ==true)
                        puntos(true, pieza);
                    return true;
                }
            }
            for (int j = 0; j <= 2; j++)
            {
                if (matriz[0, j] == pieza && matriz[1, j] == pieza && matriz[2, j] == pieza)
                {
                    if (ver == true)
                        puntos(true, pieza);
                    return true;
                }
            }
            if (matriz[0, 0] == pieza && matriz[1, 1] == pieza && matriz[2, 2] == pieza)
            {
                if (ver  == true)
                    puntos(true, pieza);
                return true;
            }

            if (matriz[0, 2] == pieza && matriz[1, 1] == pieza && matriz[2, 0] == pieza)
            {
                if (ver == true)
                    puntos(true, pieza);
                return true;
            }
            return false;
        }
      

        private bool Empate()
        {
            for (int i = 0; i <= 2; i++)
            {
                for (int j = 0; j <= 2; j++)
                {
                    if (matriz[i, j] == '-')
                        return false;
                }
            }
            return true;
        }

        private void btna1_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            int f = Convert.ToInt16(boton.Name[3].ToString());
            int c = Convert.ToInt16(boton.Name[4].ToString());
            juego(f, c, boton);
        }

        public void cambiasigno(string fila, string columna)
        {
            string boton = "btn" + fila + columna;
            Controls[boton].Text = "O";
            Controls[boton].ForeColor = Color.Yellow;
        }
      
        private void MovimientoComputadora()
        {
            Random rand = new Random();
            int fran, cran;
            // Thread.Sleep(1000);
            if ((matriz[0, 0] == 'X' || matriz[0, 2] == 'X' || matriz[2, 0] == 'X' || matriz[2, 2] == 'X') && matriz[1, 1] == '-')
            { 
                matriz[1, 1] = 'O';
                cambiasigno("1", "1");
                return;
            }
               
            for (int f = 0; f <= 2; f++)
            {
                for (int c = 0; c <= 2; c++)
                {
                    if (matriz[f, c] == '-')
                    {
                        matriz[f, c] = 'O';
                        if (verifica('O', false))
                        {
                            cambiasigno(f.ToString(), c.ToString());
                            return;
                        }
                        matriz[f, c] = '-';
                    }
                }
            }
            for (int f = 0; f <= 2; f++)
            {
                for (int c = 0; c <= 2; c++)
                {
                    if (matriz[f, c] == '-')
                    {
                        matriz[f, c] = 'X';
                        if (verifica('X', false))
                        {
                            matriz[f, c] = 'O';
                            cambiasigno(f.ToString(), c.ToString());
                            return;
                        }
                        matriz[f, c] = '-';
                    }
                }
            }
            do
            {
                fran = rand.Next(3);
                cran = rand.Next(3);
            } while (matriz[fran, cran] != '-');

            matriz[fran, cran] = 'O';
            cambiasigno(fran.ToString(), cran.ToString());
        }
        private void reiniciar()
        {
            matriz = new char[3, 3];
            foreach (Button boton in Controls.OfType<Button>())
            {
                if(boton.Name.StartsWith("btn"))
                    boton.Text = "";
            }
            iniciomatriz();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            reiniciar();
            lbpj.Text=lbcp.Text="0";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(5000);
        }
    }

}
