using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestione_Pizzeria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            int nMargherite = 0;
            int nVerdure = 0; 
            int nStagioni=0;
            
            switch (cmbTipoPizze.Text) 
            {
                case "Margherita":                  
                    lstriepilogo.Items.Add("Margherita " + txtquantità.Text);
                    nMargherite= nMargherite + Convert.ToInt32( txtquantità.Text);
                    lblnMargherite.Text = Convert.ToString(nMargherite);
                    break;
                case "Verdure":
                    lstriepilogo.Items.Add("Verdure " + txtquantità.Text);
                    nVerdure= nVerdure + Convert.ToInt32(txtquantità.Text);
                    lblnVerdure.Text = Convert.ToString(nVerdure);
                    break;
                case "4 Stagioni":
                    lstriepilogo.Items.Add("4 Stagioni " + txtquantità.Text);
                    nStagioni = nStagioni + Convert.ToInt32(txtquantità.Text);
                    lblnStagioni.Text = Convert.ToString(nStagioni);
                    break;
                    
            }

        }
    }
}
