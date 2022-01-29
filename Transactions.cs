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
    public partial class Transactions : KryptonForm
    {
        DateTime localDate = DateTime.Now;
        SqlConnection sqlConnection;
        Compte compte;
        Client client1;
        List<Transaction> trans;
        public Transactions(Compte c,Client client)
        {
            this.compte = c;
            this.client1 = client;
            trans = new List<Transaction>();
            InitializeComponent();
        }
        public void loading()
        {
            String chaineconn = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=bankIlisi2;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            sqlConnection = new SqlConnection(chaineconn);
            sqlConnection.Open();
            SqlCommand comm;
            SqlDataReader read;
            String requete = "select * from Transactions where idCompte="+this.compte.id;
            comm = new SqlCommand(requete, sqlConnection);
            read = comm.ExecuteReader();
            while (read.Read())
            {
                //MessageBox.Show((read["id"].ToString()));
                this.trans.Add(new Transaction(int.Parse(read["Id"].ToString()), read["type"].ToString(), double.Parse(read["montant"].ToString()), read["time"].ToString(),compte));
           
            }
            //foreach (Transaction T in trans)
                //MessageBox.Show(T.toString());
            List<Transaction> t=new List<Transaction>(trans);
            this.dataGridView1.DataSource = t;
            comm.Dispose();
            sqlConnection.Close();
        }

        private void Transactions_Load(object sender, EventArgs e)
        {
            infoCompte.Text = "Compte : \nNum : " + this.compte.numcompte + "\nSolde : " + this.compte.solde + "\n";
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            UserSpace user = new UserSpace(this.client1);
            user.Show();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2GradientCircleButton1_Click(object sender, EventArgs e)
        {
            if (this.comboBox1.SelectedIndex == -1 && this.textBox1.Text.Trim()!="")
                MessageBox.Show("Choisir un type de transaction");
            else if(this.textBox1.Text.Trim() == "" && this.comboBox1.SelectedIndex != -1)
                MessageBox.Show("Entrere un montant pour la transaction");
                else if(this.textBox1.Text.Trim() == "" && this.comboBox1.SelectedIndex == -1)
                    MessageBox.Show("Entrere un montant et selectionner un type de transaction");
            else
            {
                //MessageBox.Show("\n" + compte.printCompte());
                string montant = this.textBox1.Text;
                double mont = double.Parse(montant);
                
                String chaineconn = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=bankIlisi2;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                sqlConnection = new SqlConnection(chaineconn);
                sqlConnection.Open();
                String update1 = "update Compte set solde=solde+" + montant.Trim() + " where Id="+this.compte.id;
                String update2 = "update Compte set solde=solde-" + montant.Trim() + " where Id="+this.compte.id;
                SqlCommand comm;
                String type = "";String time = localDate.Date.ToString();
                SqlDataAdapter adap = new SqlDataAdapter();
                if (this.comboBox1.Text == "Crediter")
                {
                    comm = new SqlCommand(update1, sqlConnection);
                    type = "crediter";
                    this.compte.crediter(mont);
                }
                else
                {
                    if (mont > Compte.plafond)
                    {
                        MessageBox.Show("mantant a depase le plafont : " + Compte.plafond + " !");
                        return;
                    }
                    if (this.compte.solde - mont < Compte.decouverte)
                    {
                        MessageBox.Show("le solde est inferieur a la decoverte : " + Compte.decouverte + " !");
                        return;
                    }
                    comm = new SqlCommand(update2, sqlConnection);
                    type = "debiter";
                    this.compte.debiter(mont);
                }
                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlCommand comm2 = new SqlCommand("Insert into Transactions (type,montant,time,idCompte)values('"+type+"',"+montant+",'"+time+"',"+this.compte.id+")", sqlConnection);
                
                adap.UpdateCommand = comm;
                adap.UpdateCommand.ExecuteNonQuery();
                adapter.UpdateCommand = comm2;
                adapter.UpdateCommand.ExecuteNonQuery();
                comm2.Dispose();
                comm.Dispose();
                sqlConnection.Close();
                infoCompte.Text = "Compte : \nNum : " + this.compte.numcompte + "\nSolde : " + this.compte.solde + "\n";

            }



        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            trans.Clear();
            loading();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void infoCompte_Click(object sender, EventArgs e)
        {

        }
    }
}
