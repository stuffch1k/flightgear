using FlightSimulatorApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Control = FlightSimulatorApp.Control;

namespace flightgear
{
    
    public partial class MainWindow : Window
    {
        Control panelControl;
        public MainWindow()
        {
            InitializeComponent();
            panelControl = new Control(new Model());
            //Button myButton = new Button();
            //myButton.Width = 100;
            //myButton.Height = 30;
            //myButton.Content = "Кнопка";
            //panel.Children.Add(myButton);
        }
        
        private void Receive_Data(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Something");
        }
        private void Connect_onClick(object sender, RoutedEventArgs e)
        {
            string ip = "127.0.0.1"; //настроить в приложении
            string port = "45003"; //в идеале сделать окно с ручным вводом
            try
            {
                ((MainWindow)Application.Current.MainWindow).Connect(ip, Int32.Parse(port));
                this.Close();
            }
            catch
            {
                Console.WriteLine("Ошибка подключения");
            }
        }

        internal void Connect(string ip, int port)
        {
            try
            {
                panelControl.Connect(ip, port);
                var f = panelControl.IsConnected();
                if (panelControl.IsConnected())
                {
                    MessageBox.Show("Подключено");
                    
                }
                else
                {
                    MessageBox.Show("МММ кайф ничего не работает");
                }
            }
            catch
            {
                MessageBox.Show("Не удалось подключиться. Проверьте ip и port");
            }
        }
        private void Disconnect(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Something");
        }
        private void TestDrive(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Something");
        }
        private void TakeOff(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Something");
        }
        private void Slider_ValueChanged(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Something");
        }
    }
}
