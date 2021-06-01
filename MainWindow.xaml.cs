using ksmirnov.AppDataFile;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace ksmirnov

{

    public partial class MainWindow : Window, INotifyPropertyChanged
    {


        public event PropertyChangedEventHandler PropertyChanged;
        private List<ingridientsProduct> _ServiceList;
        public List<ingridientsProduct> ServiceList
        {
            get { return _ServiceList; }
            set { _ServiceList = value; }
        }

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            ServiceList = Core.DB.ingridientsProduct.ToList();


        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

    }
}



    