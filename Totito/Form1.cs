using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Totito
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text = "TOTITO";

            
            radioButton1.Text = "X";
            radioButton2.Text = "0";

            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";

            radioButton1.Checked = true;

            MessageBox.Show("Esto es TOTITO, y se juega asi" +
                "\nCada jugador tendra 4 turnos" +
                "\nSi alguno de los jugadores logra poner su variable correspondiente en 3 en linea" +
                "\nGana, de lo contrario perdera" +
                "\nY si ambos llegan a ocupar sus 4 turnos, y no hay 3 en linea, se considera empate, y se empieza de nuevo" +
                "\nEmpecemos ☺☺☺");
  
        }

        int contx = 0;
        int conto = 0;

        public void funcion()
        {

            #region contador
            //contador de turnos
            while (contx == 4)
                {
                    contx = 4;
                    if (contx == 4 && conto != 4)
                    {
                    radioButton1.Enabled = false;
                    radioButton2.Checked = true;
                    
                    }
                break;
                }

            while (conto == 4)
            {
                conto = 4;
                if (conto == 4 && contx !=4)
                {
                    radioButton2.Enabled = false;
                    radioButton1.Checked = true;
                }
                break;
            }

            //contador de turnos
            #endregion contador

            #region ganax
            //if de X
            if (   button1.Text == "x" && button2.Text == "x" && button3.Text == "x"
                || button1.Text == "x" && button4.Text == "x" && button7.Text == "x" 
                || button1.Text == "x" && button5.Text == "x" && button9.Text == "x" 
                || button3.Text == "x" && button5.Text == "x" && button7.Text == "x"
                || button2.Text == "x" && button5.Text == "x" && button8.Text == "x"
                || button3.Text == "x" && button6.Text == "x" && button9.Text == "x"
                || button4.Text == "x" && button5.Text == "x" && button6.Text == "x"
                || button7.Text == "x" && button8.Text == "x" && button9.Text == "x")
            {
                contx = 0;
                conto = 0;
                MessageBox.Show("Gano X");
                button1.Enabled = true;
                button1.Text = "";

                button2.Enabled = true;
                button2.Text = "";

                button3.Enabled = true;
                button3.Text = "";

                button4.Enabled = true;
                button4.Text = "";

                button5.Enabled = true;
                button5.Text = "";

                button6.Enabled = true;
                button6.Text = "";

                button7.Enabled = true;
                button7.Text = "";

                button8.Enabled = true;
                button8.Text = "";

                button9.Enabled = true;
                button9.Text = "";

                radioButton2.Enabled = true;
                radioButton1.Enabled = true;
            }
            #endregion ganax

            #region ganao
            //if de O
            if (button1.Text == "o" && button2.Text == "o" && button3.Text == "o"
                || button1.Text == "o" && button4.Text == "o" && button7.Text == "o"
                || button1.Text == "o" && button5.Text == "o" && button9.Text == "o"
                || button3.Text == "o" && button5.Text == "o" && button7.Text == "o"
                || button2.Text == "o" && button5.Text == "o" && button8.Text == "o"
                || button3.Text == "o" && button6.Text == "o" && button9.Text == "o"
                || button4.Text == "o" && button5.Text == "o" && button6.Text == "o"
                || button7.Text == "o" && button8.Text == "o" && button9.Text == "o")
            {
                contx = 0;
                conto = 0;
                MessageBox.Show("Gano O");
                button1.Enabled = true;
                button1.Text = "";

                button2.Enabled = true;
                button2.Text = "";

                button3.Enabled = true;
                button3.Text = "";

                button4.Enabled = true;
                button4.Text = "";

                button5.Enabled = true;
                button5.Text = "";

                button6.Enabled = true;
                button6.Text = "";

                button7.Enabled = true;
                button7.Text = "";

                button8.Enabled = true;
                button8.Text = "";

                button9.Enabled = true;
                button9.Text = "";

                radioButton2.Enabled = true;
                radioButton1.Enabled = true;
            }
            #endregion ganao

            #region empate
            if (conto == 4 && contx == 4)
            {
                MessageBox.Show("Empate, empecemos de nuevo");
                contx = 0;
                conto = 0;
                button1.Enabled = true;
                button1.Text = "";

                button2.Enabled = true;
                button2.Text = "";

                button3.Enabled = true;
                button3.Text = "";

                button4.Enabled = true;
                button4.Text = "";

                button5.Enabled = true;
                button5.Text = "";

                button6.Enabled = true;
                button6.Text = "";

                button7.Enabled = true;
                button7.Text = "";

                button8.Enabled = true;
                button8.Text = "";

                button9.Enabled = true;
                button9.Text = "";

                radioButton2.Enabled = true;
                radioButton1.Enabled = true;
            }
            #endregion empate
        }


        private void button1_Click(object sender, EventArgs e)
        {

            if (radioButton1.Checked == true)
            {
                button1.Text = "x";
                contx++;
                
            }
            if (radioButton2.Checked == true)
            {
                button1.Text = "o";
                conto++; 
            }
            button1.Enabled = false;
            funcion();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                button2.Text = "x";
                contx++;
            }
            if (radioButton2.Checked == true)
            {
                button2.Text = "o";
                conto++;
            }
            button2.Enabled = false;
            funcion();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                button3.Text = "x";
                contx++;
            }
            if (radioButton2.Checked == true)
            {
                button3.Text = "o";
                conto++;
            }
            button3.Enabled = false;
            funcion();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                button4.Text = "x";
                contx++;
            }
            if (radioButton2.Checked == true)
            {
                button4.Text = "o";
                conto++;
            }
            button4.Enabled = false;
            funcion();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                button5.Text = "x";
                contx++;
            }
            if (radioButton2.Checked == true)
            {
                button5.Text = "o";
                conto++;
            }
            button5.Enabled = false;
            funcion();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                button6.Text = "x";
                contx++;
            }
            if (radioButton2.Checked == true)
            {
                button6.Text = "o";
                conto++;
            }
            button6.Enabled = false;
            funcion();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                button7.Text = "x";
                contx++;
            }
            if (radioButton2.Checked == true)
            {
                button7.Text = "o";
                conto++;
            }
            button7.Enabled = false;
            funcion();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                button8.Text = "x";
                contx++;
            }
            if (radioButton2.Checked == true)
            {
                button8.Text = "o";
                conto++;
            }
            button8.Enabled = false;
            funcion();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                button9.Text = "x";
                contx++;
            }
            if (radioButton2.Checked == true)
            {
                button9.Text = "o";
                conto++;
            }
            button9.Enabled = false;
            funcion();
        }
    }
}
