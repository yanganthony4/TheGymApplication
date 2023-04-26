namespace TheGymApplication;

using MySqlConnector;
using System.Security.Cryptography;
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
	public void TrainerClicked2(object sender, EventArgs e)
	{
		Book.AddToSchedule2();
	}
    public void TrainerClicked3(object sender, EventArgs e)
    {
        Book.AddToSchedule3();
    }
    public void TrainerClicked4(object sender, EventArgs e)
    {
        Book.AddToSchedule4();
    }


}