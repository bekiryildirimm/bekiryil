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

namespace EzanVakti
{
    /// <summary>
    /// Interaction logic for Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menubutton_Click(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            window1.Show();
            this.Close();
        }
        private void Menubutton_MouseEnter(object sender, MouseEventArgs e)
        {
           // locationSolid.Opacity = 0.5;
        }

        private void SehirDegistir_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main=new MainWindow();
            main.Show();
            this.Close();
        }

        private void UygulamayıKapat_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
