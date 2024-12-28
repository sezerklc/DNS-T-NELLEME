using Microsoft.Maui.Controls;

namespace DNS_TÜNELLEME
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            AnimateWelcomeTextAndImage();
        }

        private async void AnimateWelcomeTextAndImage()
        {
            Device.BeginInvokeOnMainThread(async () =>
            {
                // Yazı ve fotoğrafı aynı anda küçültme ve kaybolma animasyonu
                var scaleTask1 = WelcomeLabel.ScaleTo(0.5, 3000, Easing.CubicInOut); // Yazı küçülüyor
                var fadeTask1 = WelcomeLabel.FadeTo(0, 2000); // Yazı kayboluyor

                var scaleTask2 = WelcomeImage.ScaleTo(0.5, 3000, Easing.CubicInOut); // Görsel küçülüyor
                var fadeTask2 = WelcomeImage.FadeTo(0, 2000); // Görsel kayboluyor

                // Hem yazı hem de fotoğrafın animasyonlarını aynı anda başlatıyoruz
                await Task.WhenAll(scaleTask1, fadeTask1, scaleTask2, fadeTask2);

                // Sayfa geçişi
                Application.Current.MainPage = new NavigationPage(new HomePage());
            });
        }
    }
}
