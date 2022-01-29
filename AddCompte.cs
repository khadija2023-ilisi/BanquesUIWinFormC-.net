using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Banques;
using System.Data.SqlClient;
using ComponentFactory.Krypton.Toolkit;

namespace BanquesUI24
{
    public partial class AddCompte : KryptonForm
    {
        SqlConnection sqlConnection;
        private int numcmpt;
        double soldecmpt;
        Client client;
        public AddCompte(Client c)
        {
            InitializeComponent();
            this.client = c;
        }

        private void AddCompte_Load(object sender, EventArgs e)
        {
            
        }

        private void Prenom_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CIN_TextChanged(object sender, EventArgs e)
        {

        }

        private void solde_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            
        }

        private void num_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void ajouter_Click(object sender, EventArgs e)
        {
            numcmpt =int.Parse( this.num.Text);
            soldecmpt =int.Parse( this.solde.Text);
            if (soldecmpt < Compte.decouverte)
            {
                MessageBox.Show("solde est inferieur a la de couverte : " + Compte.decouverte + " !");
                return;
            }
            String chaineconn = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=bankIlisi2;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            sqlConnection = new SqlConnection(chaineconn);
            sqlConnection.Open();
            SqlCommand comm = new SqlCommand("insert into Compte (num,solde,idClient)values ("+numcmpt+","+soldecmpt+","+client.id+")", sqlConnection);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.InsertCommand = comm;
            if (adapter.InsertCommand.ExecuteNonQuery() > 0)
                MessageBox.Show("account sucessfully added");
            sqlConnection.Close();
            this.Close();
        }
    }
}
