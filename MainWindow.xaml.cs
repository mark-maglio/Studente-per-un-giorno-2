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

namespace Studente_per_un_giorno_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            addendo1.Minimum = 0;
            addendo1.Maximum = 30;
            addendo2.Minimum = 0;
            addendo2.Maximum = 30;
        }

        private void addendo1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            int numero = (int)addendo1.Value;
            TxtAddendo1.Text = Convert.ToString(numero);
            int numero2 = (int)addendo2.Value;
            TxtAddendo2.Text = Convert.ToString(numero2);
            int Somma = numero + numero2;
            TxtSomma.Text = Convert.ToString(Somma);
        }

        private void addendo2_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            int numero = (int)addendo1.Value;
            TxtAddendo1.Text = Convert.ToString(numero);
            int numero2 = (int)addendo2.Value;
            TxtAddendo2.Text = Convert.ToString(numero2);
            int Somma = numero + numero2;
            TxtSomma.Text = Convert.ToString(Somma);
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
                addendo1.IsEnabled = true;
                addendo2.IsEnabled = true;
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
              addendo1.IsEnabled = false;
              addendo2.IsEnabled = false;
        
        }
    }
}
