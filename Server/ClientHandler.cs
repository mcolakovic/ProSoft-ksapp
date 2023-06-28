using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace Server
{
    public class ClientHandler
    {
        private Socket socket;
        private List<int> brojevi;
        private CommunicationHelper helper;
        public CommunicationHelper Helper { get => helper; }

        public ClientHandler(Socket socket, List<int> brojevi)
        {
            this.socket = socket;
            this.brojevi = brojevi;
            helper = new CommunicationHelper(socket);
        }

        public event EventHandler OdjavljenKorisnik;
        public event EventHandler IzmijeniBroj;

        internal void HandleRequests()
        {
            try
            {
                Poruka poruka;
                while ((poruka = helper.Recieve<Poruka>()).Operations != Operations.EndCommunication)
                {
                    try
                    {
                        CreatePoruka(poruka);
                    }
                    catch (Exception ex)
                    {
                        poruka = new Poruka
                        {
                            IsSuccessful = false,
                            MessageText = ex.Message
                        };
                        helper.Send(poruka);
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            finally
            {
                Stop();
            }
        }

        private void Stop()
        {
            if (socket != null)
            {
                socket.Shutdown(SocketShutdown.Both);
                socket.Dispose();
                socket = null;
            }
            OdjavljenKorisnik?.Invoke(this, EventArgs.Empty);
        }

        private void CreatePoruka(Poruka poruka)
        {
            switch (poruka.Operations)
            {
                case Operations.Igra:
                    IzmijeniBroj?.Invoke(this, new MyEventArgs((Info)poruka.PorukaObject));
                    break;
            }
        }
    }
}
