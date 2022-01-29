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
    public partial class Form1 : KryptonForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            /*UserSpace us = new UserSpace(new Client("Asasid", "Mamoune", "BJ12343", "Login", "Password"));
            us.Show();*/
            loginForm log = new loginForm();
            log.Show();
            
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Inscription insc = new Inscription();
            insc.Show();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            Information info = new Information();
            info.Show();
        }
    }
}
