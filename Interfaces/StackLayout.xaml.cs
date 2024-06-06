namespace Interfaces;

public partial class StackLayout : ContentPage
{
	public StackLayout()
	{
		InitializeComponent();
	}


    private void btnFlexLayout(object sender, EventArgs e)
    {
        Navigation.PushAsync(new FlexLayout());
    }

}