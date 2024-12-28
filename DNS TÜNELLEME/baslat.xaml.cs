using Microsoft.Maui.Controls;

namespace DNS_TÜNELLEME
{
    public partial class baslat : ContentPage
    {
        public baslat()
        {
            InitializeComponent();
        }

        private async void OnStopClicked(object sender, EventArgs e)
        {
            // Stop butonuna tıklandığında tarama durdurulacak ve ana sayfaya geri dönülecek
            await DisplayAlert("Durdur", "Tarama durdurulmuştur.", "OK");

            // Ana sayfaya geri dönme
            await Navigation.PopAsync();
        }
    }
}
