using System;
using System.Collections.Generic;
using System.Linq;
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

namespace Week14WPFDataGrid
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public class Gundam
        {
            // prop 탭 2번
            public string Name { get; set; }
            public string Model { get; set; }
            public string Party { get; set; }

            public Gundam(string name, string model, string party)
            {
                Name = name;
                Model = model;
                Party = party;
            }
        }

        protected List<Gundam> GundamList = new List<Gundam>();
        public MainWindow()
        {
            InitializeComponent();
            GundamList.Add(new Gundam("건담", "RX-78-2", "연방군"));
            Grid.ItemsSource = GundamList;
            GundamList.Add(new Gundam("자쿠II", "MS-06", "지온군"));
        }

        private void OnAdd(object sender, RoutedEventArgs e)
        {
            GundamList.Add(new Gundam("건탱크", "RX-75-4", "연방군"));
            Grid.Items.Refresh();
        }
    }
}
