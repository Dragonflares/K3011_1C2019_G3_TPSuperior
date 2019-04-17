﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace K3011_1C2019_G3_TPSuperior
{
    public partial class OperacionesBasicas : Form
    {
        public OperacionesBasicas()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonOperar_Click(object sender, EventArgs e)
        {
            if(textBoxComplejo1.Text == "" || textBoxComplejo2.Text == "")
            {
                MessageBox.Show("Debe Ingresar los 2 números complejos para operar!");
            }
            else
            {
                if (!this.esComplejoValido(textBoxComplejo1.Text) || !this.esComplejoValido(textBoxComplejo2.Text))
                {
                    MessageBox.Show("Debe Ingresar los números complejos de la siguiente manera: (a,b) o [a;b]");
                }
                else
                {
                    //aca se sacarian los numeros de cada textbox, de su expresion regular, se crean los complejos y se ejecuta la operacion correspondiente
                    //valorAComplejo1 = textBoxComplejo1.Text.obtenervalor1
                    //valorBComplejo1 = textBoxComplejo1.Text.obtenervalor2
                    //formaComplejo1 = textBoxComplejo1.Text.obtenerforma
                    //NumeroComplejo num1 = new NumeroComplejo(valorAComplejo1, valorAComplejo2, formaComplejo1);
                    //hago lo mismo para el otro complejo
                    //luego opero
                    if(comboBoxOperaciones.SelectedIndex == -1)
                    {
                        MessageBox.Show("Debe seleccionar una operación!");
                    } else
                    {
                        //armo un case con todas las posibles operaciones seleccionadas
                        //por cada operacion, opero con los complejos
                    }
                }
            }
        }

        private bool esComplejoValido(string complejo)
        {
            //aca se validaria la expresion regular y se devolveria el resultado de la validacion
            return true;
        }
    }
}