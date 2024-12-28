using Microsoft.Maui.Controls;

namespace DNS_TÜNELLEME
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        // Başlat butonuna tıklandığında çalışacak metot
        private async void OnStartClicked(object sender, EventArgs e)
        {
            // LinkEntry'deki değeri al
            string link = LinkEntry.Text;

            if (string.IsNullOrWhiteSpace(link)) // Eğer boşsa veya sadece boşluk içeriyorsa
            {
                // Kullanıcıya link girmesi gerektiğini belirten bir uyarı mesajı göster
                await DisplayAlert("Hata", "Link girilmesi zorunludur.", "Tamam");
            }
            else
            {
                // Başlat sayfasına yönlendirme
                await Navigation.PushAsync(new baslat());
            }
        }

        // Hakkımızda butonuna tıklandığında çalışacak metot
        private async void OnHakkimizdaClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Hakkımızda());
        }

        // Sıkça Sorulan Sorular butonuna tıklandığında çalışacak metot
        private async void OnSSSClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SSS());
        }
    }
}
