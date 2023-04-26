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

        public string BookingInfo { get; set; }
        public int VisitCount { get; set; }  

        public BindingLabel() 
        {
            
            VisitCount = App.currentUser.numberOfVisits;

        }
        

    }
}

