using MySqlConnector;
using TheGymApplication.Entities;

namespace TheGymApplication;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
        this.BindingContext = new BindingLabel();
    }
    public class BindingLabel
    {
        public string FirstName { get; set; }
        public int VisitCount { get; set; } = 42; // Example value

        public BindingLabel() 
        {
            FirstName = Trainers.GetFirstName();
        }
    }
}

