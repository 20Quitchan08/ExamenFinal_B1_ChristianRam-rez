using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenFinal_B1_ChristianRamírez
{
    public partial class ExamenB1 : Form
    {
        public ExamenB1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtNumero1_TextChanged(object sender, EventArgs e)
        {
            
                

                
            

        }

        private void txtNumero2_TextChanged(object sender, EventArgs e)
        {

    
        }
        private void txtNumero3_TextChanged(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (((int.TryParse(txtNumero1.Text, out int txtNum1)) && ((int.TryParse(txtNumero2.Text, out int txtNum2)))) && ((int.TryParse(txtNumero3.Text, out int txtNum3))))
            {
                if ((txtNum1 > txtNum2) && (txtNum2 > txtNum3))
                {
                    MessageBox.Show(txtNum1 + ">" + txtNum2 + ">" + txtNum3);
                }
                else if ((((txtNum1 == txtNum2) && (txtNum2 > txtNum3))))
                {
                    MessageBox.Show(txtNum1 + "=" + txtNum2 + ">" + txtNum3);
                }
                else if ((txtNum1 > txtNum2) && (txtNum2 == txtNum3))
                {
                    MessageBox.Show(txtNum1 + ">" + txtNum2 + "=" + txtNum3);
                }
                else if ((txtNum1 < txtNum2) && (txtNum2 == txtNum3))
                {
                    MessageBox.Show(txtNum1 + "<" + txtNum2 + "=" + txtNum3);
                }
                else if ((txtNum1 == txtNum2) && (txtNum2 < txtNum3))
                {
                    MessageBox.Show(txtNum1 + "=" + txtNum2 + "<" + txtNum3);
                }
                else if ((txtNum1 < txtNum2) && (txtNum2 > txtNum3))
                {
                    MessageBox.Show(txtNum1 + "<" + txtNum2 + ">" + txtNum3);
                }
                else if ((txtNum1 > txtNum2) && (txtNum2 < txtNum3))
                {
                    MessageBox.Show(txtNum1 + ">" + txtNum2 + "<" + txtNum3);
                }
                else if ((txtNum1 == txtNum2) && ( txtNum2 == txtNum3))
                {
                    MessageBox.Show(txtNum1 + "=" + txtNum2 + "=" + txtNum3);
                }
                else
                {
                    MessageBox.Show(txtNum1 + "<" + txtNum2 + "<" + txtNum3); 
                }
                
            }
            else
            {
                MessageBox.Show("Ingrese un número valido :) ");
            }


        }
    }
}


