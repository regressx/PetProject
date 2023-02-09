using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Reflection.Metadata;
using System.Text;
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

namespace PetProject.Client.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            using var tcpClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            await tcpClient.ConnectAsync("127.0.0.1", 11111);

            using FileStream fs = new FileStream("D:\\путь к иконкам.txt", FileMode.Open);
            using MemoryStream ms = new MemoryStream();
            fs.CopyTo(ms);
            ms.Write(Encoding.ASCII.GetBytes("\0"));

            await tcpClient.SendAsync(ms.ToArray());

            var response = new List<byte>();

            // буфер для считывания одного байта
            var bytesRead = new byte[1];
                
            // считываем данные до конечного символа
            while (true)
            {
                var count = await tcpClient.ReceiveAsync(bytesRead);
                // смотрим, если считанный байт представляет конечный символ, выходим
                if (count == 0 || bytesRead[0] == '\n') break;
                // иначе добавляем в буфер
                response.Add(bytesRead[0]);
            }

            var translation = Encoding.UTF8.GetString(response.ToArray());
            Debug.WriteLine($"Слово: {translation}");
            response.Clear();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
        }
    }
}