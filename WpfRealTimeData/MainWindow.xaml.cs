using System.Collections.Generic;
using System.Windows;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System;
using System.Windows.Threading;
using System.Threading;
using System.Threading.Tasks;

namespace WpfRealTimeData
{
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged = delegate { };
        private ObservableCollection<KeyValuePair<int, int>> _value;
        public ObservableCollection<KeyValuePair<int, int>> MyValues
        {
            get
            {
                if (_value == null)
                {
                    _value = new ObservableCollection<KeyValuePair<int, int>>();
                }
                return _value;
            }
            set
            {
                _value = value;
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(MyValues)));
            }
        }

        public MainWindow()
        {
            InitializeComponent();
            lineChart.DataContext = MyValues;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Dispatcher.BeginInvoke(DispatcherPriority.Normal, 
                    (ThreadStart) delegate
                    {
                        getValues();
                    }
                );
        }

        private void getValues()
        {
            Random r = new Random();
            
            for(int i=0; i<10; i++)
            {
                MyValues.Add(new KeyValuePair<int, int>(i, r.Next(25, 55)));
            }
        }
    }
}
