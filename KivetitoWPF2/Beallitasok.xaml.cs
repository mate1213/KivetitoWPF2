using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using Microsoft.Samples.CustomControls;

namespace KivetitoWPF2
{
    /// <summary>
    /// Interaction logic for Beallitasok.xaml
    /// </summary>
    public partial class Beallitasok : Window
    {
        MainWindow mainWindow;

        public Beallitasok(Brush keretSzin, Brush gombSzin, Brush hatterSzinDalok, Brush hatterSzinIgek, Brush hatterSzinKepek, Brush hatterSzinVideok, MainWindow main)
        {
            InitializeComponent();
            Button_SzinGomb.Background = gombSzin;
            Button_SzinKeret.Background = keretSzin;
            Button_SzinHatterDalok.Background = hatterSzinDalok;
            Button_SzinHatterIgek.Background = hatterSzinIgek;
            Button_SzinHatterKepek.Background = hatterSzinKepek;
            Button_SzinHatterVideok.Background = hatterSzinVideok;
            mainWindow = main;
        }

        private void Button_Szin_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            
            string temp = btn.Background.ToString();
            Color color = (Color)ColorConverter.ConvertFromString(temp);

            ColorPickerDialog cPicker = new ColorPickerDialog();

            cPicker.StartingColor = color;
            cPicker.Owner = this;

            bool? dialogResult = cPicker.ShowDialog();
            if (dialogResult != null && (bool)dialogResult == true)
            {
                if (btn.Background != null)
                    btn.Background = new SolidColorBrush(cPicker.SelectedColor);
            }
        }

        private void Button_Mentes_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
