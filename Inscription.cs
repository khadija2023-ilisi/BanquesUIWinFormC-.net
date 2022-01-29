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
   
    public partial class Inscription : KryptonForm
    {
        public string nom;
        public string prenom;
        public string cin;
        public string login;
        public string mdp;
        SqlConnection sqlConnection;
        public Inscription()
        {
            InitializeComponent();
        }

        private void Inscription_Load(object sender, EventArgs e)
        {

        }

        private void kryptonLabel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kryptonLabel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("CLient :  enregistrée");
            nom = this.Nom.Text.Trim();
            prenom = this.Prenom.Text.Trim();
            cin = this.CIN.Text.Trim();
            login = this.Login.Text.Trim();
            mdp = this.Password.Text.Trim();
           if (!this.checkInscription()) 
                MessageBox.Show("prb !");
           else { 
                
                String chaineconn = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=bankIlisi2;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                sqlConnection = new SqlConnection(chaineconn);
                sqlConnection.Open();
                SqlDataAdapter adap = new SqlDataAdapter();
                String ins = "insert into Client (nom,prenom,CIN, Login, motdepasse) VALUES " +
                             "('"+nom+"','"+prenom + "','" +cin + "','" +login + "','" +mdp+"')";
                //String ins = "update Compte set num=" + n1 + "where id=5";
                SqlCommand comm = new SqlCommand(ins, sqlConnection);
                adap.InsertCommand = comm;
                if(adap.InsertCommand.ExecuteNonQuery()>0)
                    MessageBox.Show("CLient : " + nom + " " + prenom +" enregistrée");
                comm.Dispose();
                sqlConnection.Close();
                this.Close();

            }
           
        }
        private bool checkInscription()
        {
        
        nom = this.Nom.Text.Trim();
        prenom = this.Prenom.Text.Trim();
        cin = this.CIN.Text.Trim();
        login = this.Login.Text.Trim();
        mdp = this.Password.Text.Trim();
        if (nom=="" || prenom=="" ||
                cin=="" || login.Trim() == "" ||
                mdp.Trim() == "")
            {
                MessageBox.Show("fill all the text boxs please !");
                return false;
            }
            if(mdp.Length<=4)
            {
                MessageBox.Show("mot de passe doit depasser 4 caractere!");
                return false;
            }
            return true;
        }
    }
}
