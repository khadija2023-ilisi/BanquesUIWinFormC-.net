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
    public partial class UserSpace : KryptonForm
    {
        Client client;
        List<Compte> mescmpt;
        public UserSpace(Client c)
        {
            this.client = c;
            mescmpt = new List<Compte>();
            InitializeComponent();
        }

        private void UserSpace_Load(object sender, EventArgs e)
        {
            this.NOM.Text = client.nom;
            this.PRENOM.Text = client.prenom;
            this.CIN.Text = client.CIN;
            this.LOGIN.Text = client.login;
            this.PASSWORD.Text = client.motDePasse;
            loadcomboBox1();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void kryptonLabel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kryptonLabel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconPictureBox3_Click(object sender, EventArgs e)
        {
            if (this.comboBox1.SelectedIndex == -1)
            {
                loadcomboBox1();
                return;
            }
            SqlConnection sqlConnection;
            String chaineconn = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=bankIlisi2;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            sqlConnection = new SqlConnection(chaineconn);
            sqlConnection.Open();
            int idcmpt=0;
            SqlCommand comm;
            SqlDataReader read;
            foreach(Compte c in this.mescmpt)
            {
                if (c.numcompte == int.Parse(this.comboBox1.SelectedItem.ToString()))
                    idcmpt = c.id;
            }
            if (idcmpt == 0) return;
            String requete = "select * from Compte where id="+idcmpt;
            Compte cmpt = null;
            comm = new SqlCommand(requete, sqlConnection);
            read = comm.ExecuteReader();
            if (read.Read())
            {
                cmpt = new Compte((int)read["id"], this.client, Double.Parse(read["solde"].ToString()),int.Parse(read["num"].ToString()));
                //MessageBox.Show("\n"+cmpt.printCompte());
                Transactions tr = new Transactions(cmpt,this.client);
                tr.Show();
                this.Close();
            }
            comm.Dispose();
            sqlConnection.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void loadcomboBox1()
        {            
            String requete = "select * from Compte where idClient=" + this.client.id;
            SqlConnection sqlConnection;
            String chaineconn = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=bankIlisi2;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            sqlConnection = new SqlConnection(chaineconn);
            sqlConnection.Open();
            SqlCommand comm=new SqlCommand(requete, sqlConnection); ;
            SqlDataReader read;
            read = comm.ExecuteReader();
            while (read.Read())
            {
                this.comboBox1.Items.Add(read["num"]);
                mescmpt.Add(new Compte(int.Parse(read["Id"].ToString()), this.client, double.Parse(read["solde"].ToString()), int.Parse(read["num"].ToString())));
            }

            comm.Dispose();
            sqlConnection.Close();
        }

        private void iconPictureBox4_Click(object sender, EventArgs e)
        {
            AddCompte adc = new AddCompte(this.client);
            adc.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
