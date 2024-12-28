namespace DNS_TÜNELLEME
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());  // Başlangıçta MainPage'i yükle
        }
    }
}
