using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraSCRUM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        double memoria = 0;
        double memoria2 = 0;
        String operacion = "";

//---------------------------------------------------------Numeros-----------------------------------------------------------
        private void button1_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "1";   
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "2";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "3";
        }
        private void button4_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            pantalla.Text = pantalla.Text + "0";
        }
//-------------------------------------------Punto------------------------------------------------
        private void button11_Click(object sender, EventArgs e)
        {
            if (pantalla.Text == "")
            {
                pantalla.Text = pantalla.Text + "0,";
            }

            else if (pantalla.Text.IndexOf(",") == -1)
            {
                pantalla.Text = pantalla.Text + ",";
            }
            else
            {
                MessageBox.Show("Solo un punto");
            }
        }
//---------------------------------------Borrar----------------------------------------------------------
        private void button19_Click(object sender, EventArgs e)
        {
            pantalla.Clear();
        }
//----------------------------------------Eliminar-------------------------------------------------
        private void button20_Click(object sender, EventArgs e)
        {
            String texto = "";
            for (int i = 0; i < pantalla.Text.Length - 1; i++)
            {
                texto = texto + pantalla.Text[i];
            }
            pantalla.Text = texto;
        }
//----------------------------------------------------------------------------------------------------------Operaciones--------------------------------------------------------

//------------------------------------Suma--------------------------------------------------------------
        private void button13_Click(object sender, EventArgs e)
        {
            if (pantalla.Text == "")
            {
                MessageBox.Show("Ingrese un número");
            }
            else
            {
                memoria = Convert.ToDouble(pantalla.Text);
                pantalla.Clear();
                operacion = "suma";
            }


        }
//-----------------------------------Resta----------------------------------------------------------------
        private void Resta_Click(object sender, EventArgs e)
        {
            if (pantalla.Text == "")
            {
                MessageBox.Show("Ingrese un número");
            }
            else
            {
                memoria = Convert.ToDouble(pantalla.Text);
                pantalla.Clear();
                operacion = "resta";
            }

        }
//--------------------------------------Multiplicacion----------------------------------------
        private void Mult_Click(object sender, EventArgs e)
        {
            if (pantalla.Text == "")
            {
                MessageBox.Show("Ingrese un número");
            }
            else
            {
                memoria = Convert.ToDouble(pantalla.Text);
                pantalla.Clear();
                operacion = "mult";
            }
        }
//-----------------------------------------Division---------------------------------------------
        private void Div_Click(object sender, EventArgs e)
        {
            if (pantalla.Text == "")
            {
                MessageBox.Show("Ingrese un número");
            }
            else
            {
                memoria = Convert.ToDouble(pantalla.Text);
                pantalla.Clear();
                operacion = "div";
            }
        }
//-------------------------------------Raiz-------------------------------------
        private void Raiz_Click(object sender, EventArgs e)
        {
            if (pantalla.Text == "")
            {
                MessageBox.Show("Ingrese un número");
            }
            else
            {
                memoria = Convert.ToDouble(pantalla.Text);
                pantalla.Clear();
                pantalla.Text = Convert.ToString(Math.Sqrt(memoria));
            }
        }
//------------------------------Potencia--------------------------------
        private void Potencia_Click(object sender, EventArgs e)
        {
            if (pantalla.Text == "")
            {
                MessageBox.Show("Ingrese un número");
            }
            else
            {
                memoria = Convert.ToDouble(pantalla.Text);
                pantalla.Clear();
                operacion = "potencia";
                
            }

        }
//--------------------------Igual-----------------------------------------------
        private void Igual_Click(object sender, EventArgs e)
        {
            if (pantalla.Text == "")
            {
                MessageBox.Show("Ingrese un numero");
            }
            else if (operacion == "")
            {
                MessageBox.Show("Eliga una operacion");
            }
            else
            {
                memoria2 = Convert.ToDouble(pantalla.Text);

                switch (operacion)
                {
                    case "suma":
                        pantalla.Text = Convert.ToString(memoria+memoria2);
                        break;

                    case "resta":
                        pantalla.Text = Convert.ToString(memoria - memoria2);
                        break;

                    case "mult":
                        pantalla.Text = Convert.ToString(memoria * memoria2);
                        break;

                    case "div":
                        pantalla.Text = Convert.ToString(memoria / memoria2);
                        break;

                    case "potencia":
                        pantalla.Text = Convert.ToString(Math.Pow(memoria, memoria2));
                        break;
                        
                }
                operacion = "";

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("¡¡¡¡¡Bienvenido!!!!!");
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Muchas gracias por usar esta Calculadora");
            this.Close();
        }
    }
}
