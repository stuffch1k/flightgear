using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Media;

namespace FlightSimulatorApp
{
    class Control 
    {
        private IModel model;
        public Control(IModel model)
        {
            this.model = model;
            
        }
        
        public void Connect(string ip, int port)
        {
            model.Connect(ip, port);
        }

        public void Disconnect()
        {
            model.Disconnect();
        }

        public bool IsConnected()
        {
            return model.IsConnected();
        }
    }
}

