using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace satranc_815
{
    public partial class Form1 : Form
    {
        int sayacBeyaz = 10;
        int sayacSiyah = 10;

        public Form1()
        {
            InitializeComponent();
        }

        

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            tmrBeyaz.Start();
        }



        private void btnSiyah_Click(object sender, EventArgs e)
        {
            tmrSiyah.Stop();
            tmrBeyaz.Start();
        }

        private void tmrBeyaz_Tick(object sender, EventArgs e)
        {
            sayacBeyaz--;
            if (sayacBeyaz <= 0)
            {
                tmrBeyaz.Stop();
                this.BackColor = Color.White;
            }
            lblBeyaz.Text = sayacBeyaz.ToString();
            if (sayacBeyaz <= 0)
            {
                lblBeyaz.Text = "Siyah Kazandı";
            }

        }
        private void btnBeyaz_Click(object sender, EventArgs e)
        {
            tmrBeyaz.Stop();
            tmrSiyah.Start();

           
        }
        private void tmrSiyah_Tick(object sender, EventArgs e)
        {
            sayacSiyah--;
            if (sayacSiyah <= 0)
            {
                tmrBeyaz.Stop();
                this.BackColor = Color.Black;
            }
            lblSiyah.Text = sayacSiyah.ToString();

            if (sayacSiyah <= 0)
            {
                lblSiyah.Text = "Beyaz Kazandı";
            }    
            
            

        }

       
    }
}
