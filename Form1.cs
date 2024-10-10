using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Adunare_Click(object sender, EventArgs e)
        {
            try
            {
                Rezultat.Text = (Convert.ToDouble(nr1.Text) + Convert.ToDouble(nr2.Text)).ToString();
            }catch(Exception ex)
            {
                MessageBox.Show("Error!" + ex);
            }
        }

        private void Scadere_Click(object sender, EventArgs e)
        {
            try
            {
                Rezultat.Text = (Convert.ToDouble(nr1.Text) - Convert.ToDouble(nr2.Text)).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!" + ex);
            }
        }

        private void Inmultire_Click(object sender, EventArgs e)
        {
            try
            {
                Rezultat.Text = (Convert.ToDouble(nr1.Text) * Convert.ToDouble(nr2.Text)).ToString();
            }
            catch (Exception ex)        
            {
                MessageBox.Show("Error!" + ex);
            }
        }

        private void Impartire_Click(object sender, EventArgs e)
        {
            try
            {
                Rezultat.Text = (Convert.ToDouble(nr1.Text) / Convert.ToDouble(nr2.Text)).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!" + ex);
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Rezultat.Text = "";
            nr1.Text = "";
            nr2.Text = "";
        }
    }
}
