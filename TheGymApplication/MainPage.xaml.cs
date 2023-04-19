using MySqlConnector;
namespace TheGymApplication;

public partial class MainPage : ContentPage
{
	int count = 0;

    
    public MainPage()
	{
		InitializeComponent();
        this.BindingContext = new VisitCountViewModel();
    }
    public class VisitCountViewModel
    {
    
    public int VisitCount { get; set; } = 42; // Example value
    }

    
}

