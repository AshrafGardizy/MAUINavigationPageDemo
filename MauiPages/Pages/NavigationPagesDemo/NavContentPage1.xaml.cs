namespace MauiPages.Pages.NavigationPagesDemo;

public partial class NavContentPage1 : ContentPage
{
	public NavContentPage1()
	{
		InitializeComponent();
	}

    private void BtnNext_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new NavContentPage2());
    }
}