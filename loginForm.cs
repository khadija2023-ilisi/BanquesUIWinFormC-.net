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
    public partial class loginForm : KryptonForm
    {
        SqlConnection sqlConnection;
        public loginForm()
        {
            InitializeComponent();
        }

        private void loginForm_Load(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton4_Click(object sender, EventArgs e)
        {
            String login = this.textBox1.Text, motdepasse = this.textBox2.Text;
            bool estClient = false;
            String chaineconn = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=bankIlisi2;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            sqlConnection = new SqlConnection(chaineconn);
            sqlConnection.Open();

            SqlCommand comm;
            SqlDataReader read;
            String requete = "select * from Client";
            Client c=null;
            comm = new SqlCommand(requete, sqlConnection);
            read = comm.ExecuteReader();
            while (read.Read())
            {
               
                c = new Client((int)read["id"], (String)read["nom"], (String)read["prenom"], (String)read["CIN"], (String)read["Login"], (String)read["motdepasse"]);
                if(c.login==login && c.motDePasse == motdepasse)
                {
                    estClient = true;
                    break;
                }
            }
            if (estClient)
            {
                UserSpace user = new UserSpace(c);
                user.Show();
                this.Close();
            }


            comm.Dispose();
            sqlConnection.Close();


        }
    }
}
