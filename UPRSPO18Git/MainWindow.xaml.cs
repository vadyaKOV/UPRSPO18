using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
using Newtonsoft.Json;

namespace UPRSPO18Git
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Hotel> CurrentHotel {  get; set; }
        public MainWindow()
        {
            InitializeComponent();
            var client = new WebClient();
            var responce = client.DownloadString("http://127.0.0.1:63450/api/hotels");
            CurrentHotel = JsonConvert.DeserializeObject<List<Hotel>>(responce);
            DataContext = this;
        }
    }
}
