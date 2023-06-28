using Common;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace KorisnickiInterfejs
{
    public class Communication
    {
        private Socket socket;
        private static Communication instance;
        private CommunicationHelper helper;
        private Communication()
        {
        }
        public static Communication Instance
        {
            get
            {
                if (instance == null)
                    instance = new Communication();
                return instance;
            }
        }

        public void Connect(string ip, int port)
        {
            try
            {
                if (socket == null || !socket.Connected)
                {
                    socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    socket.Connect(ip,port);
                    helper = new CommunicationHelper(socket);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        public void CloseConnection()
        {
            try
            {
                Poruka poruka = new Poruka
                {
                    Operations = Operations.EndCommunication
                };
                helper.Send(poruka);
                socket.Shutdown(SocketShutdown.Both);
                socket.Dispose();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        public void SendMessage<T>(T m) where T : class
        {
            try
            {
                helper.Send(m);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        public T ReadMessage<T>() where T : class
        {
            try
            {
                return helper.Recieve<T>();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
