namespace TheGymApplication;

using MySqlConnector;
using TheGymApplication.Entities;
public partial class TrainerBookingPage : ContentPage
{
	public TrainerBookingPage()
	{
 
		InitializeComponent();


	}
	public void TrainerClicked1(object sender, EventArgs e)
	{
		Book.AddToSchedule1();

    }
}