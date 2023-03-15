using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uwusenpai
{
    public partial class Form1 : Form
    {
        bool zmiana = false;
        double wartA1 = 1;
        double wartB1 = 1;
        double wyn = 1.41;
        
        public Form1()
        {
            InitializeComponent();
        }
        
        private void label4_Click(object sender, EventArgs e)
        {
           
        }

        private void txtWynC_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void nUPDNa_ValueChanged(object sender, EventArgs e)
        {
            zmiana = true;
            decimal wartA = nUPDNa.Value;
            wartA1 = decimal.ToDouble(wartA) ;
            wyn = Math.Sqrt((wartA1*wartA1) + (wartB1*wartB1));
           // txtWynC.Text = wyn + "";
            txtWynC.Text = Convert.ToString(string.Format("{0:0.000}", wyn));
        }

        private void nUPDNb_ValueChanged(object sender, EventArgs e)
        {
            zmiana = true;
            decimal wartB = nUPDNb.Value;
            wartB1 = decimal.ToDouble(wartB);
            wyn = Math.Sqrt((wartA1*wartA1) +( wartB1*wartB1));
            txtWynC.Text = Convert.ToString(string.Format("{0:0.000}", wyn)) ;
            

        }
    //    int kwadrat = Math.Sqrt(wartA1 + wartB1);
        private void cmbFunkcja_SelectedIndexChanged(object sender, EventArgs e)
        {
            zmiana = true;
            if (cmbkat.SelectedItem == "alfa")
            {
                if (cmbFunkcja.SelectedItem == "sin")
                {
                    double wyn1 = 0;
                    wyn1 = wartA1 / wyn;
                    txtWynFunkcje.Text = wyn1 + "";
                }
               else if (cmbFunkcja.SelectedItem == "cos")
                {
                    double wyn1 = 0;
                    wyn1 = wartB1 / wyn;
                    txtWynFunkcje.Text = wyn1 + "";
                }
               else if (cmbFunkcja.SelectedItem == "tg")
                {
                    double wyn1 = 0;
                    wyn1 = wartA1 / wartB1;
                    txtWynFunkcje.Text = wyn1 + "";
                }
               else if (cmbFunkcja.SelectedItem == "ctg")
                {
                    double wyn1 = 0;
                    wyn1 = wartB1 / wartA1;
                    txtWynFunkcje.Text = wyn1 + "";
                }
            }
           else if(cmbkat.SelectedItem == "beta")
            {
                if (cmbFunkcja.SelectedItem == "sin")
                {
                    double wyn1 = 0;
                    wyn1 = wartB1 / wyn;
                    txtWynFunkcje.Text = wyn1 + "";
                }
                else if (cmbFunkcja.SelectedItem == "cos")
                {
                    double wyn1 = 0;
                    wyn1 = wartA1 / wyn;
                    txtWynFunkcje.Text = wyn1 + "";
                }
                else if (cmbFunkcja.SelectedItem == "ctg")
                {
                    double wyn1 = 0;
                    wyn1 = wartA1 / wartB1;
                    txtWynFunkcje.Text = wyn1 + "";
                }
                else if (cmbFunkcja.SelectedItem == "tg")
                {
                    double wyn1 = 0;
                    wyn1 = wartB1 / wartA1;
                    txtWynFunkcje.Text = wyn1 + "";
                }
            }
           
        }

        private void cmbkat_SelectedIndexChanged(object sender, EventArgs e)
        {
            zmiana = true;
            if (cmbkat.SelectedItem == "alfa")
            {
                if (cmbFunkcja.SelectedItem == "sin")
                {
                    double wyn1 = 0;
                    wyn1 = wartA1 / wyn;
                    txtWynFunkcje.Text = wyn1 + "";
                }
                else if (cmbFunkcja.SelectedItem == "cos")
                {
                    double wyn1 = 0;
                    wyn1 = wartB1 / wyn;
                    txtWynFunkcje.Text = wyn1 + "";
                }
                else if (cmbFunkcja.SelectedItem == "tg")
                {
                    double wyn1 = 0;
                    wyn1 = wartA1 / wartB1;
                    txtWynFunkcje.Text = wyn1 + "";
                }
                else if (cmbFunkcja.SelectedItem == "ctg")
                {
                    double wyn1 = 0;
                    wyn1 = wartB1 / wartA1;
                    txtWynFunkcje.Text = wyn1 + "";
                }
            }
            else if (cmbkat.SelectedItem == "beta")
            {
                if (cmbFunkcja.SelectedItem == "sin")
                {
                    double wyn1 = 0;
                    wyn1 = wartB1 / wyn;
                    txtWynFunkcje.Text = wyn1 + "";
                }
                else if (cmbFunkcja.SelectedItem == "cos")
                {
                    double wyn1 = 0;
                    wyn1 = wartA1 / wyn;
                    txtWynFunkcje.Text = wyn1 + "";
                }
                else if (cmbFunkcja.SelectedItem == "ctg")
                {
                    double wyn1 = 0;
                    wyn1 = wartA1 / wartB1;
                    txtWynFunkcje.Text = wyn1 + "";
                }
                else if (cmbFunkcja.SelectedItem == "tg")
                {
                    double wyn1 = 0;
                    wyn1 = wartB1 / wartA1;
                    txtWynFunkcje.Text = wyn1 + "";
                }
            }
        }

        private void txtWynFunkcje_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
        /*
public static void FunkcjaliczC()
{
wyn = Math.Sqrt((wartA1 * wartA1) + (wartB1 * wartB1));
}
public static void FunkcjaliczAlf()
{

}
public static void FunkcjaliczBet()
{

}*/

    }


}
