using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlarmaForm
{
    public partial class UserControl1 : UserControl
    {


        private string entradaUsuari = "";
        private bool isContrasenyaVisible = false;
        private string codiCorrecte = "0000";
        private bool isActivada = false;
        private int contador = 0;

        public UserControl1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        //buttons del 0-9
        private void button_Number_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button; //dona el boto que sha picat
            if (clickedButton != null)
            {
                if (entradaUsuari.Length < 4)//va per indice no per length com java
                {
                    entradaUsuari += clickedButton.Text;
                    UpdateTextBoxContrasenyaView();
                }
            }
        }

        private void btn_O_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 4)
            {
                MessageBox.Show("El codi ha de tenir mínim 4 dígits", "Error");
            }
            else
            {
                if (entradaUsuari.Equals(codiCorrecte))
                {
                    isActivada = !isActivada;
                    contador = 0;
                }
                else
                {
                    contador++;
                }
                modifica_Label_Image_State_Alarma(isActivada, contador);
            }
        }

        private void modifica_Label_Image_State_Alarma(bool isActivada, int contador)
        {
           if(isActivada){
                if (contador == 3)
                {
                    MessageBox.Show("l'alarma ha sigut bloquejada, has arribat al màxim número d'errors: 3." +
                                    " Contacta amb el teu número de contacte", "Alarma Bloquejada");

                    label_Alarma_State.Text = "Bloquejada";
                    pictureBox2.Image = Properties.Resources.bloquear;

                    //desactivar els controls
                    foreach (Control control in this.Controls)
                    {
                       control.Enabled = false;         
                    }

                }else{
                    label_Alarma_State.Text = "Connectada";
                    label_Alarma_State.ForeColor = Color.FromArgb(2, 198, 132);
                    pictureBox2.Image = Properties.Resources.seguridad_de_casa_verd;
                }
            }
            else{
                label_Alarma_State.Text = "Desconnectada";
                label_Alarma_State.ForeColor = Color.FromArgb(0, 126, 249);
                pictureBox2.Image = Properties.Resources.candado_abierto;
            }
            
        }

        /*
         * només permet l'entrada de digits, no lletres
         */
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btn_X_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            entradaUsuari = "";
        }

        private void btn_visibility_Click(object sender, EventArgs e)
        {
            isContrasenyaVisible = !isContrasenyaVisible;

            UpdateTextBoxContrasenyaView();
        }

        private void UpdateTextBoxContrasenyaView()
        {
            textBox1.Text = isContrasenyaVisible ? entradaUsuari : new string('*', entradaUsuari.Length);
        }

    }
}
