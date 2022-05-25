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
using System.Windows.Shapes;

namespace Area
{
    /// <summary>
    /// Interaction logic for Elipse.xaml
    /// </summary>
    public partial class Elipse : Window
    {
        public Elipse()
        {
            InitializeComponent();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double rad = Convert.ToDouble(Radius.Text);
            double S = Math.Round((Math.PI * (rad * rad)), 3);
            MessageBox.Show($"{S} сантиметров квадратных");
        }
    }
}
