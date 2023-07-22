using LiveCharts;
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


namespace Dashboard
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Values = new ChartValues<double> { 150, 375, 420, 500, 160, 140 };

            DataContext = this;
        }
        public ChartValues<double> Values { get; set; }

        private void UpdateOnclick(object sender, RoutedEventArgs e)
        {
            Chart.Update(true);
        }
    }
}
