using FlightSimulatorApp;
using System;
using System.Windows;
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
            }
            catch
            {
                Console.WriteLine("Ошибка подключения");
            }
        }

        private void Disconnect_onClick(object sender, RoutedEventArgs e)
        {
                panelControl.Disconnect();
                MessageBox.Show("Отключено");
        
        }

        internal void Connect(string ip, int port)
        {
            var messageError = "Не удалось подключиться. Проверьте ip и port";
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
                    MessageBox.Show(messageError);
                }
            }
            catch
            {
                MessageBox.Show(messageError);
            }
        }
        private void TestDrive(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Something");
        }
        private void Start_onClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Something");
        }
        private void Slider_ValueChanged(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Something");
        }
    }
}
