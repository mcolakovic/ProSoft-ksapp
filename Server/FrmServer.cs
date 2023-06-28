using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;
using Common;

namespace Server
{
    public partial class FrmServer : Form
    {
        Server server = new Server();
        public FrmServer()
        {
            InitializeComponent();
            server.ServerIzmijeniBroj += Server_ServerIzmijeniBroj;
        }

        private void Server_ServerIzmijeniBroj(object sender, EventArgs e)
        {
            int index = ((MyEventArgs)e).info.Pozicija-1;
            int brPrije = server.Brojevi[index];
            server.Brojevi[index] = 31;
            Random random = new Random();
            int min = 31;
            foreach (int i in server.Brojevi)
            {
                if (i % 3 == 0 && i < min && i != 0)
                    min = i;
            }
            if (min == 31)
                server.Brojevi[index] = random.Next(31);
            else
                server.Brojevi[index] = min;
            dgvBrojevi[index, 0].Value = server.Brojevi[index].ToString();
            Poruka poruka = new Poruka
            {
                IsSuccessful = true,
                Operations = Operations.Igra,
                PorukaObject = new Info
                {
                    Pozicija = ((MyEventArgs)e).info.Pozicija,
                    BrojPrije = brPrije,
                    BrojPoslije = server.Brojevi[index]
                }
            };
            server.Clients[0].Helper.Send(poruka);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            server.Start();
            Thread serverskaNit = new Thread(server.HandleClients);
            serverskaNit.IsBackground = true;
            serverskaNit.Start();
            lblServer.Text = "Server program je pokrenut";
            lblVrijeme.Visible = true;
            lblTimer.Visible = true;
            label4.Visible = true;
            dgvBrojevi.Visible = true;
            btnStart.Visible = false;
            InitializeDGV();
            lblVrijeme.Text = DateTime.Now.ToString("HH:mm");
            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void InitializeDGV()
        {
            dgvBrojevi.DataSource = null;
            dgvBrojevi.DefaultCellStyle.SelectionBackColor = Color.White;
            dgvBrojevi.ColumnCount = 10;
            dgvBrojevi.Columns[0].HeaderText = "1";
            dgvBrojevi.Columns[1].HeaderText = "2";
            dgvBrojevi.Columns[2].HeaderText = "3";
            dgvBrojevi.Columns[3].HeaderText = "4";
            dgvBrojevi.Columns[4].HeaderText = "5";
            dgvBrojevi.Columns[5].HeaderText = "6";
            dgvBrojevi.Columns[6].HeaderText = "7";
            dgvBrojevi.Columns[7].HeaderText = "8";
            dgvBrojevi.Columns[8].HeaderText = "9";
            dgvBrojevi.Columns[9].HeaderText = "10";
            for (int i = 0; i < 10; i++)
            {
                dgvBrojevi.Columns[i].Width = 50;
            }
            Random random = new Random();
            dgvBrojevi.Rows.Add();
            for (int i = 0; i < 10; i++)
            {
                int number = random.Next(31);
                dgvBrojevi[i,0].Value = number.ToString();
                server.Brojevi.Add(number);
            }
            dgvBrojevi.CurrentCell = dgvBrojevi[0, 0];
            dgvBrojevi.CurrentCell.Selected = false;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
