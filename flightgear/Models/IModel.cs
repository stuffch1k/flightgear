using System.ComponentModel;
using System.Windows;
using System.Windows.Media;

namespace FlightSimulatorApp
{
    interface IModel : INotifyPropertyChanged
    {
        void Connect(string ip, int port);
        void Disconnect();
        //void Start();
        bool IsConnected();

    }
}
