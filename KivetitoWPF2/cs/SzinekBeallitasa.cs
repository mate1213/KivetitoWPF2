using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace KivetitoWPF2
{
    class SzinekBeallitasa
    {

        public void HatterBeallitasa(ref Grid menu, ref Grid kezeloFelulet, ref Grid eszkozok, Brush szin)
        {
            menu.Background = kezeloFelulet.Background = eszkozok.Background = szin;
        }

        public void KeretAllitas(ref Button btn_Keretes, ref Button btn2, ref Button btn3, ref Button btn4, ref Button btn5, int szelesseg, Brush szin)
        {
            BorderSetter(ref btn_Keretes, szelesseg, szin);
            BorderSetterDefault(ref btn2);
            BorderSetterDefault(ref btn3);
            BorderSetterDefault(ref btn4);
            BorderSetterDefault(ref btn5);
        }

        private void BorderSetterDefault(ref Button btn)
        {
            try
            {
                var bc = new BrushConverter();
                btn.BorderBrush = (Brush)bc.ConvertFrom("#FF707070");
                btn.BorderThickness = new Thickness(1);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Hiba");
            }
        }

        private void BorderSetter(ref Button btn, int bordertickness, Brush brushes)
        {
            try
            {
                btn.BorderBrush = (dynamic)brushes;
                btn.BorderThickness = new Thickness(bordertickness);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Hiba");
            }
        }
    }
}
