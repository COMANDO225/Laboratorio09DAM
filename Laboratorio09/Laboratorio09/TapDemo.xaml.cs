using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Laboratorio09
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TapDemo : ContentPage
    {
        int tapCount;
        readonly Label label;
        bool isSSJ;
        public TapDemo()
        {
            InitializeComponent();

            var image = new Image
            {
                Source = "gokubase.jpg",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HeightRequest = 300,
            };

            var tapGestureRecognizer = new TapGestureRecognizer();
            tapGestureRecognizer.NumberOfTapsRequired = 1;
            tapGestureRecognizer.Tapped += OntapsitoMasna;
            image.GestureRecognizers.Add(tapGestureRecognizer);

            label = new Label
            {
                Text = "Dame 2 taps para evolucionar",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            var tapsContadorLabelsitoMasna = new Label
            {
                Text = "Contador de taps: 0",
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            if (Content is StackLayout stackLayout)
            {
                stackLayout.Children.Add(image);
                stackLayout.Children.Add(label);
                stackLayout.Children.Add(tapsContadorLabelsitoMasna);
            }
        }
        private void OntapsitoMasna(object sender, EventArgs args)
        {
            tapCount++;
            label.Text = String.Format(isSSJ ? "Dame 2 taps para tranquilizarme" : "Dame 2 taps para azarme");
            var imageSender = (Image)sender;

            if (tapCount % 2 == 0)
            {
                isSSJ = !isSSJ;
                label.Text = isSSJ ? "Dame 2 taps para tranquilizarme" : "Dame 2 taps para azarme";
                imageSender.Source = isSSJ ? "gokussj.jpg" : "gokubase.jpg";
            }

            // Castear Content a StackLayout y obtener el último Label
            if (Content is StackLayout stackLayout)
            {
                var tapsCounterLabel = stackLayout.Children.LastOrDefault() as Label;
                if (tapsCounterLabel != null)
                {
                    tapsCounterLabel.Text = $"Contador de taps: {tapCount}";
                }
            }
        }
    }
}