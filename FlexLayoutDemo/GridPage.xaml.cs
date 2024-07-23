//using Android.Views;

namespace FlexLayoutDemo;

public partial class GridPage : ContentPage
{
	public GridPage()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		Button current = sender as Button;	
		switch (current.Text)
		{
			case "0":
                DisplayTouch("0");
				break;
            case "1":
                DisplayTouch("1");
                break;
            case "2":
                DisplayTouch("2");
                break;
            case "3":
                DisplayTouch("3");
                break;
            case "4":
                DisplayTouch("4");
                break;
            case "5":
                DisplayTouch("5");
                break;
            case "6":
                DisplayTouch("6");
                break;
            case "7":
                DisplayTouch("7");
                break;
            case "8":
                DisplayTouch("8");
                break;
            case "9":
                DisplayTouch("9");
                break;
            case "#":
                DisplayTouch("#");
                break;
            case "*":
                DisplayTouch("*");
                break;
        }
    }

    private void DisplayTouch(string touch)
    {
		DisplayAlert("Touch", touch.ToString(), "OK");
    }
}