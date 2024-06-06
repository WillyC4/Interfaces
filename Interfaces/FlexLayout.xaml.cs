namespace Interfaces;

public partial class FlexLayout : ContentPage
{
	public FlexLayout()
	{
		InitializeComponent();
	}

    private void imgFlex(object sender, EventArgs e)
    {
        Navigation.PushAsync(new AbsoluteLayout());
    }

}