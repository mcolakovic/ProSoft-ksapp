using Domain;
using Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KorisnickiInterfejs
{
    public partial class FrmLogin : Form
    {
        public string ip;
        public int port;
        public string user;
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ip = txtIP.Text;
            port = int.Parse(txtPort.Text);
            user = txtUser.Text;
            if (txtIP.Text == "127.0.0.1" && txtPort.Text == "9999")
            {
                User user = new User
                {
                    Username = txtUser.Text
                };
                user = UserRepository.Instance.VratiUsera(user);
                if (user != null)
                {
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Korisnik ne postoji");
                }
            }
            else
            {
                MessageBox.Show("Unijeti su pogresni parametri za server.");
            }
        }
    }
}
