using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace KivetitoWPF2
{
    class DefaultBeallitasok
    {
        private Brush defaultBackGround1 = Brushes.LightBlue;

        public Brush DefaultBackGround1
        {
            get { return defaultBackGround1; }
        }

        private Brush defaultBackGround2 = Brushes.LightCoral;

        public Brush DefaultBackGround2
        {
            get { return defaultBackGround2; }
        }

        private Brush defaultBackGround3 = Brushes.LightCyan;

        public Brush DefaultBackGround3
        {
            get { return defaultBackGround3; }
        }

        private Brush defaultBackGround4 = Brushes.LightGoldenrodYellow;

        public Brush DefaultBackGround4
        {
            get { return defaultBackGround4; }
        }

        private Brush defaulBorderColor = Brushes.Red;

        public Brush DefaulBorderColor
        {
            get { return defaulBorderColor; }
        }
        //Brushes brushes = (Brushes)ColorConverter.ConvertFromString("#FFDDDDDD");
        private Brush defaultButtonColor = (Brush)(new BrushConverter().ConvertFrom("#FFDDDDDD"));

        public Brush DefaultButtonColor
        {
            get { return defaultButtonColor; }
        }
    }
}
