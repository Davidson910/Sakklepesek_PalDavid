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

namespace Sakklepesek_PalDavid
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int meret = 8;
        Button[,] mezok;
        public MainWindow()
        {
            InitializeComponent();
            Tablakialakitasa();
        }
        private void Tablakialakitasa()
        {
            mezok = new Button[meret, meret];
            for (int i = 0; i < meret; i++)
            {

                for (int j = 0; j < meret; j++)
                {
                    Button negyzet = new Button();
                    negyzet.Height = tabla.Height / meret;
                    negyzet.Width = tabla.Width / meret;
                    negyzet.Margin = new Thickness(tabla.Width / meret * j, tabla.Height / meret * i, 0, 0);
                    negyzet.Click += SzinCsere;
                    tabla.Children.Add(negyzet);

                    if (i % 2 == 1 && j % 2 == 1)
                        negyzet.Background = Brushes.Bisque;
                    else if (j % 2 == 0 && i % 2 == 0)
                        negyzet.Background = Brushes.Bisque;
                    else
                        negyzet.Background = Brushes.Chocolate;
                }

            }
        }
        private void SzinCsere(object sender, RoutedEventArgs e)
        {
            Button kijelolt = (Button)sender;
            if (SParaszt.IsChecked == true)
                kijelolt.Content = "\u265f";
            else if (VParaszt.IsChecked == true)
                kijelolt.Content = "\u2659";
            else if (Kiraly.IsChecked == true)
                kijelolt.Content = "\u265a";
            else if (Kiralyne.IsChecked == true)
                kijelolt.Content = "\u2655";
            else if (Lo.IsChecked == true)
                kijelolt.Content = "\u2658";
            else if (Futo.IsChecked == true)
                kijelolt.Content = "\u2657";
            else if (Bastya.IsChecked == true)
                kijelolt.Content = "\u2656";
        }
    }
}