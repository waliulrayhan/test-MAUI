namespace MauiApp2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AdminHomePage());
        }

        private void DemoHomePageLinkButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new UserHomePage());
        }
    }
}