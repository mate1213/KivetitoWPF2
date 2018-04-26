using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace KivetitoWPF2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DefaultBeallitasok defaultBeallitasok;
        Beallitasok beallitasok;
        SzinekBeallitasa szinekBeallitasa;

        public MainWindow()
        {
            InitializeComponent();
            //Default settings
            defaultBeallitasok = new DefaultBeallitasok();
            szinekBeallitasa = new SzinekBeallitasa();
            beallitasok = new Beallitasok(
                defaultBeallitasok.DefaulBorderColor,
                defaultBeallitasok.DefaultButtonColor,
                defaultBeallitasok.DefaultBackGround1,
                defaultBeallitasok.DefaultBackGround2,
                defaultBeallitasok.DefaultBackGround3,
                defaultBeallitasok.DefaultBackGround4,
                this);
            szinekBeallitasa.HatterBeallitasa(ref Grid_Menu, ref Grid_DalokKezeloFelulet, ref Grid_DalokEszkoz, defaultBeallitasok.DefaultBackGround1);
        }


        private void Btn_Dalok_Click(object sender, RoutedEventArgs e)
        {
            TabControl_KezeloFelulet.SelectedIndex = 0;
            TabControl_Eszkozok.SelectedIndex = 0;

            szinekBeallitasa.KeretAllitas(ref Btn_Dalok, ref Btn_Igek, ref Btn_Kepek, ref Btn_Videok, ref Btn_Beallitasok, 3, defaultBeallitasok.DefaulBorderColor);
            szinekBeallitasa.HatterBeallitasa(ref Grid_Menu, ref Grid_DalokKezeloFelulet, ref Grid_DalokEszkoz, defaultBeallitasok.DefaultBackGround1);
        }

        private void Btn_Igek_Click(object sender, RoutedEventArgs e)
        {
            TabControl_KezeloFelulet.SelectedIndex = 1;
            TabControl_Eszkozok.SelectedIndex = 1;
            
            szinekBeallitasa.KeretAllitas(ref Btn_Igek, ref Btn_Dalok, ref Btn_Kepek, ref Btn_Videok, ref Btn_Beallitasok, 3, defaultBeallitasok.DefaulBorderColor);
            szinekBeallitasa.HatterBeallitasa(ref Grid_Menu, ref Grid_IgekKezeloFelulet, ref Grid_IgekEszkoz, defaultBeallitasok.DefaultBackGround2);
        }

        private void Btn_Kepek_Click(object sender, RoutedEventArgs e)
        {
            TabControl_KezeloFelulet.SelectedIndex = 2;
            TabControl_Eszkozok.SelectedIndex = 2;
            
            szinekBeallitasa.KeretAllitas(ref Btn_Kepek, ref Btn_Dalok, ref Btn_Igek, ref Btn_Videok, ref Btn_Beallitasok, 3, defaultBeallitasok.DefaulBorderColor);
            szinekBeallitasa.HatterBeallitasa(ref Grid_Menu, ref Grid_KepekKezeloFelulet, ref Grid_KepekEszkoz, defaultBeallitasok.DefaultBackGround3);
        }

        private void Btn_Videok_Click(object sender, RoutedEventArgs e)
        {
            TabControl_KezeloFelulet.SelectedIndex = 3;
            TabControl_Eszkozok.SelectedIndex = 3;
            
            szinekBeallitasa.KeretAllitas(ref Btn_Videok, ref Btn_Dalok, ref Btn_Igek, ref Btn_Kepek, ref Btn_Beallitasok, 3, defaultBeallitasok.DefaulBorderColor);
            szinekBeallitasa.HatterBeallitasa(ref Grid_Menu, ref Grid_VideokKezeloFelulet, ref Grid_VideoEszkoz, defaultBeallitasok.DefaultBackGround4);
        }

        private void Btn_Beallitasok_Click(object sender, RoutedEventArgs e)
        {
            szinekBeallitasa.KeretAllitas(ref Btn_Beallitasok, ref Btn_Dalok, ref Btn_Igek, ref Btn_Kepek, ref Btn_Videok, 3, defaultBeallitasok.DefaulBorderColor);
            beallitasok.Show();
        }

        //TODO: Kiemelni külön Class-ba (BeviteliSzabalyok.cs)
        private void CsakSzam_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            TextBox tb = sender as TextBox;
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void MaxErtek_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox tb = sender as TextBox;
            int inttemp;
            bool booltemp = int.TryParse(tb.Text, out inttemp);
            if (inttemp > 250)
            {
                MessageBox.Show("Nagyobb szám nem elfogadott! Max:250", "Hiba!");
                tb.Text = "";
            }
        }

        private void TextBox_Keres_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (tb.Text == "")
            {
                tb.Text = "Itt kereshetsz a dalok között.";
                var bc = new BrushConverter();
                tb.Foreground = (Brush)bc.ConvertFrom("#FF7A7A7A");
            }
        }

        private void TextBox_Keres_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (tb.Text == "Itt kereshetsz a dalok között.")
            {
                tb.Text = string.Empty;
                tb.Foreground = Brushes.Black;
            }
        }
    }
}
