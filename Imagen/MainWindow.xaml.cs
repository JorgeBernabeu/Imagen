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

namespace Imagen
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MaximaRadio_Checked(object sender, RoutedEventArgs e)
        {
            PosterImage.Opacity = 1;
        }

        private void MedioRadio_Checked(object sender, RoutedEventArgs e)
        {
            PosterImage.Opacity = 0.6;
        }

        private void BajoRadio_Checked(object sender, RoutedEventArgs e)
        {
            PosterImage.Opacity = 0.3;
        }

        private void RellenoRadio_Checked(object sender, RoutedEventArgs e)
        {
            PosterImage.Stretch = Stretch.Fill;
        }

        private void UniformeRadio_Checked(object sender, RoutedEventArgs e)
        {
            PosterImage.Stretch = Stretch.Uniform;
        }

        private void RellenoUniformeRadio_Checked(object sender, RoutedEventArgs e)
        {
            PosterImage.Stretch = Stretch.UniformToFill;
        }

        private void Sin_AjusteRadio_Checked(object sender, RoutedEventArgs e)
        {
            PosterImage.Stretch = Stretch.None;
        }
    }
}
