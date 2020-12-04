using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomsGestionHoteliere.newForm
{
    public partial class frmGestionUtilisateur : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=easygestBd;Integrated Security=True");
        SqlCommand com = new SqlCommand();
        public frmGestionUtilisateur()
        {
            InitializeComponent();
        }

        private void frmGestionUtilisateur_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'easygestBdDataSet.UTILISATEURS'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.uTILISATEURSTableAdapter.Fill(this.easygestBdDataSet.UTILISATEURS);

        }

        private void guna2Button16_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlDataAdapter adp = new SqlDataAdapter(" insert_utilisateur", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("   @idUtilisateur INT,
  
    @adresse VARCHAR(255),
    @statutidStatut INT", txtadress.Text);
            adp.SelectCommand.Parameters.AddWithValue("@ @motDePasse ", txtadress.Text);
            adp.SelectCommand.Parameters.AddWithValue("@idStatut", txtadress.Text);
            adp.SelectCommand.Parameters.AddWithValue("@idStatut", txtadress.Text);

            DataTable Dat = new DataTable();
            adp.Fill(Dat);
            return Dat.Rows.;
            con.Close();
            uTILISATEURSBindingSource.EndEdit();
            //this.uTILISATEURSTableAdapter.Insert(int.Parse(txtid.Text.Trim()), txtusername.Text.Trim(), txtpsw.Text.Trim(), int.Parse(txttel.Text.Trim()), txtadress.Text.Trim(),check(cbsat);

        }
    }
}
