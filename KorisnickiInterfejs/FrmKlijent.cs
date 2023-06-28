using Common;
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
    public partial class FrmKlijent : Form
    {
        private string user;
        public FrmKlijent(string ip, int port, string user)
        {
            InitializeComponent();
            this.user = user;
            try
            {
                Communication.Instance.Connect(ip, port);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnIzbaci_Click(object sender, EventArgs e)
        {
            if (Validacija())
            {
                Poruka poruka = new Poruka
                {
                    Operations = Operations.Igra,
                    PorukaObject = new Info
                    {
                        Pozicija = int.Parse(txtPozicija.Text)
                    }
                };
                Communication.Instance.SendMessage(poruka);
                poruka = Communication.Instance.ReadMessage<Poruka>();
                txtPoruka.Text = user + " je izbacio element sa pozicije " + ((Info)poruka.PorukaObject).Pozicija.ToString() + " (" + ((Info)poruka.PorukaObject).BrojPrije.ToString() + ") sada je na poziciji " + ((Info)poruka.PorukaObject).Pozicija.ToString() + " broj " + ((Info)poruka.PorukaObject).BrojPoslije.ToString();
                txtPozicija.Text = "";
            }
            else
            {
                txtPozicija.Text = "";
                txtPoruka.Text = "";
            }
        }

        private bool Validacija()
        {
            int pozicija;
            if (int.TryParse(txtPozicija.Text, out pozicija))
                if (pozicija >= 1 && pozicija <= 10)
                    return true;
            return false;
        }
    }
}
