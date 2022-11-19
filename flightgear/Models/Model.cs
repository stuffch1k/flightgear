using System;
using System.ComponentModel;
using System.Net.Sockets;

namespace FlightSimulatorApp
{
    class Model : IModel
    {

        TcpClient tcpClient;
   

        //для будущих контроллов
        public event PropertyChangedEventHandler PropertyChanged;
        //для консольки если что
        private string Status;

        
        public Model() {  }

        public void Connect(string ip, int port)
        {
            try
            {
                tcpClient = new TcpClient();
                tcpClient.Connect(ip, port);
                Status = "connected";
                
            }
            catch 
            {
                Console.WriteLine("Невозможно подключиться");
            }
        }

        public void Disconnect()
        {
            if (tcpClient != null)
            {
                tcpClient.Close();
                
            }
            Status = "disconnected";
        }
        public bool IsConnected() { return tcpClient.Connected; }
       
    }
}
