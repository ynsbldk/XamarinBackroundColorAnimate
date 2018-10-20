using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BackroundColorAnimate
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var whitetoblack = false;

            boxView.Animate(
                "colorchange",
                x =>
                {
                    if (whitetoblack)
                    {
                        x = 1 - x;
                    }
                    var test = (int)(254 * x);
                    boxView.BackgroundColor = Color.FromRgb(test, test, test);
                },
                length: 3000,
                finished: delegate (double d, bool b)
                 {
                     if (!whitetoblack)
                     {
                         boxView.BackgroundColor = Color.FromRgb(0, 0, 0);
                     }
                     else
                     {
                         boxView.BackgroundColor = Color.FromRgb(255, 255, 255);
                     }
                 },
                repeat: () =>
                {
                    whitetoblack = !whitetoblack;
                    return true;
                }


                );

            // loading............................. Açılıyor ....................
        }
    }
}
