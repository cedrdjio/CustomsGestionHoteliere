using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomsGestionHoteliere.newForm
{
    public partial class FrmGestionBoisson : Form
    {
        public FrmGestionBoisson()
        {
            InitializeComponent();
        }

        private void AjouterBoisson_Click(object sender, EventArgs e)
        {

        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {

        }

        private void txtIdBoisson_TextChanged(object sender, EventArgs e)
        {
            if(txtIdBoisson.Text !="")
            {
                txtIdBoisson.Enabled=false;
            }
        }
    }
}
