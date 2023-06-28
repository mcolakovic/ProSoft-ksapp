using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;
using Common;

namespace Server
{
    public class Server
    {
        private Socket serverSocket;
        private bool isRunning = false;
        private List<ClientHandler> clients = new List<ClientHandler>();
        public List<ClientHandler> Clients { get => clients; }
        private List<int> brojevi = new List<int>();
        public List<int> Brojevi { get => brojevi; set => brojevi = value; }
        public event EventHandler ServerIzmijeniBroj;
        private static Object zakljucaj = new Object();

        public void Start()
        {
            if (!isRunning)
            {
                serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                serverSocket.Bind(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9999));
                serverSocket.Listen(5);
                isRunning = true;
            }
        }

        public void Stop()
        {
            if (isRunning)
            {
                serverSocket.Dispose();
                serverSocket = null;
                isRunning = false;
            }
        }

        public void HandleClients()
        {
            try
            {
                while (true)
                {
                    Socket clientSocket = serverSocket.Accept();
                    ClientHandler handler = new ClientHandler(clientSocket, brojevi);
                    clients.Add(handler);
                    handler.OdjavljenKorisnik += Handler_OdjavljenKorisnik;
                    handler.IzmijeniBroj += Handler_IzmijeniBroj;
                    Thread klijentskaNit = new Thread(handler.HandleRequests);
                    klijentskaNit.IsBackground = true;
                    klijentskaNit.Start();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        private void Handler_IzmijeniBroj(object sender, EventArgs e)
        {
            ServerIzmijeniBroj?.Invoke(sender, e);
        }

        private void Handler_OdjavljenKorisnik(object sender, EventArgs e)
        {
            clients.Remove((ClientHandler)sender);
        }
    }
}
