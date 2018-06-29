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
using System.Threading;


namespace WpfRealTimeData
{
    public partial class MainWindow : Window
    {
        List<KeyValuePair<int, int>> MyValue = new List<KeyValuePair<int, int>>();

        public MainWindow()
        {
            InitializeComponent();
            showChart();
        }

        private void showChart()
        {
            Random r = new Random();
            for(int i = 0; i < 20; i++)
            {
                MyValue.Add(new KeyValuePair<int, int>(i, r.Next(25, 51)));
            }

            lineChart.DataContext = MyValue;
        }
    }
}
