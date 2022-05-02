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
        Rectangle[,] mezok;
        public MainWindow()
        {
            InitializeComponent();
            Tablakialakitasa();
        }
        private void Tablakialakitasa()
        {
            mezok = new Rectangle[meret, meret];
            for (int i = 0; i < meret; i++)
            {

                for (int j = 0; j < meret; j++)
                {
                    Button negyzet = new Button();
                    negyzet.Height = tabla.Height / meret;
                    negyzet.Width = tabla.Width / meret;
                    negyzet.Margin = new Thickness(tabla.Width / meret * j, tabla.Height / meret * i, 0, 0);
                    //negyzet.Click += SzinCsere;
                    tabla.Children.Add(negyzet);

                    if (i % 2 == 1 && j % 2 == 1)
                        negyzet.Background = Brushes.White;
                    else if (j % 2 == 0 && i % 2 == 0)
                        negyzet.Background = Brushes.White;
                    else
                        negyzet.Background = Brushes.Black;
                }
            }
        }
    }
}
