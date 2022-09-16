namespace mauiAppearEventProblem;

public partial class MainPage : ContentPage
{
	int count = 0;
    int appearCount = 0;
    int disappearCount = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}

	protected override void OnAppearing() 
	{
		base.OnAppearing();
        appearCount++;
        lblAppearing.Text = $"Appearing count = {appearCount}";
    }

    protected override void OnDisappearing()
    {
        base.OnDisappearing();
        disappearCount++;
        lblDisappearing.Text = $"Disappearing count = {disappearCount}";
    }
}

