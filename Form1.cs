using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{
    public partial class Form1 : Form
    {
        List<Utente> utenti = new List<Utente>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Registrati_Click(object sender, EventArgs e)
        {
            if (lbemail.Text != "" && lbusername.Text != "" && lbpassword.Text != "") 
            {
                string email = lbemail.Text;
                string username = lbusername.Text;
                string password = lbpassword.Text;
                Registrati_Query(email, username, password);
            }
            else
            {
                MessageBox.Show("inserisci dei dati");
            }
        }
        private void Registrati_Query(string email, string username, string password)
        {
            string sql_insert = $"INSERT INTO `utenti`(`email`, `username`, `password`) VALUES ('{email}','{username}','{password}')";
            Connessione.Connect(sql_insert);
        }
    }
}
