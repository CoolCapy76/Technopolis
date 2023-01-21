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
    public partial class MainWindow : Window
    {
        double total;

        public MainWindow()
        {
            InitializeComponent();
            //DataContext = new MyViewModel();
        }

        /*class MyViewModel : INotifyPropertyChanged
        {
            private double _value;
            public double Value
            {
                get => _value;
                set
                {
                    _value = value;
                    OnPropertyChanged();
                }
            }

            public event PropertyChangedEventHandler PropertyChanged;

            protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }*/

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            if (check1.IsChecked == true)
            {
                total = total + 1099;
            }

            if (check2.IsChecked == true)
            {
                total = total + 2500;
            }

            if (check3.IsChecked == true)
            {
                total = total + 150;
            }

            if (check4.IsChecked == true)
            {
                total = total + 599;
            }

            if (check5.IsChecked == true)
            {
                total = total + 630;
            }

        }

        

    }
}
