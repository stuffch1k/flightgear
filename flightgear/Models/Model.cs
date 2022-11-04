using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Net.Sockets;
using System.Threading;
using System.Windows;
using System.Windows.Media;

namespace FlightSimulatorApp
{
    class Model : IModel
    {

        TcpClient tcpClient;
   

        //для будущих контроллов
        public event PropertyChangedEventHandler PropertyChanged;

        
        public Model() {  }

        public void Connect(string ip, int port)
        {
            try
            {
                tcpClient = new TcpClient();
                tcpClient.Connect(ip, port);
                
            }
            catch 
            {
                Console.WriteLine("Невозможно подключиться");
            }
        }
      
        public bool IsConnected() { return tcpClient.Connected; }
       
    }
}
