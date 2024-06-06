namespace Interfaces;

public partial class AbsoluteLayout : ContentPage
{
	public AbsoluteLayout()
	{
		InitializeComponent();
	}

    private void btnMain(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MainPage());
    }
}