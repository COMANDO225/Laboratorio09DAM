using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Laboratorio09
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            /*hablapecausa1.Clicked += OnButtonClicked;
            hablapecausa2.Clicked += OnButtonClicked;
            hablapecausa3.Clicked += OnButtonClicked;
            hablapecausa4.Clicked += OnButtonClicked;*/
            /*hablapecausa1.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new PanDemo());
            };*/
        }
        private async void OnButtonClicked(object sender, EventArgs e)
        {
            var btn = (Button)sender;

            switch (btn.Text)
            {
                case "Tap demo":
                    await Navigation.PushAsync(new TapDemo());
                    break;
                case "Pinch demo":
                    await Navigation.PushAsync(new PinchDemo());
                    break;
                case "Pan demo":
                    await Navigation.PushAsync(new PanDemo());
                    break;
                case "Swipe demo":
                    await Navigation.PushAsync(new SwipeDemo());
                    break;
            }
        }
        private async void OnLabelTapped(object sender, EventArgs e)
        {
            await DisplayAlert("Aviso", "Todo perdedor puede mejorar y volverse bueno si persevera", "Aea");
        }
    }
}
