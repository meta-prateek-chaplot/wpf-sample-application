using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WpfChart
{
    public class Country
    {
        public Country(string Name, long Population)    // Constructor
        {
            this.Name = Name;
            this.Population = Population;
        }
        public string Name                // Name Property
        {
            get;
            set;
        }
        public long Population                // Population Property
        {
            get;
            set;
        }
    }

    public class CountryCollection : Collection<Country> // Extending from System.Collections.ObjectModel.Collection class
    {
        public CountryCollection() // Constructor to add Country objects to the CountryCollection
        {
            Add(new Country("China", 1336718015));
            Add(new Country("India", 1189172906));
            Add(new Country("United States", 313232044));
            Add(new Country("Indonesia", 245613043));
            Add(new Country("Brazil", 203429773));
        }
    }

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
