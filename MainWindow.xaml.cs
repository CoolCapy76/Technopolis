using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace TechStore
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private double _total;
        public double Total
        {
            get => _total;
            set
            {
                _total = value;
                OnPropertyChanged();
            }
        }

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            switch (checkBox.Name)
            {
                case "check1":
                    Total += 1099;
                    break;
                case "check2":
                    Total += 2500;
                    break;
                case "check3":
                    Total += 150;
                    break;
                case "check4":
                    Total += 599;
                    break;
                case "check5":
                    Total += 630;
                    break;
            }
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            switch (checkBox.Name)
            {
                case "check1":
                    Total -= 1099;
                    break;
                case "check2":
                    Total -= 2500;
                    break;
                case "check3":
                    Total -= 150;
                    break;
                case "check4":
                    Total -= 599;
                    break;
                case "check5":
                    Total -= 630;
                    break;
            }
        }

    }
}