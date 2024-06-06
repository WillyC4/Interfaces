namespace Interfaces
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void btnStackLayout(object sender, EventArgs e)
        {
            Navigation.PushAsync(new StackLayout());
        }
    }

}
