using MySqlConnector;
using TheGymApplication.Entities;

namespace TheGymApplication;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
        this.BindingContext = new BindingLabel();
        //for each (Booking in bookings_list)

    }
    public class BindingLabel


    {

        public string BookingInfo { get; set; }


        public int VisitCount { get; set; }  

        public BindingLabel() //Prints out visitcount for the current logged in user
        {
            
            VisitCount = App.currentUser.numberOfVisits;

        }
        

    }
}

