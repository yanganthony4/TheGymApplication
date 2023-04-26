using MySqlConnector;
using TheGymApplication.Entities;

namespace TheGymApplication;

public partial class MainPage : ContentPage
{
    Color black = Color.FromRgb(0, 0, 0);
    List<Bookings> booking_list = Bookings.PopulateBookingList();
    List<Bookings> stored_bookings = new List<Bookings>();
    public void updateBookingsList(object sender, EventArgs e)
    {
        List<Bookings> booking_list = Bookings.PopulateBookingList();
        foreach (Bookings booking in booking_list)
        {
            if (stored_bookings.Contains(booking))
            {
                continue;
            }
            else if (!stored_bookings.Contains(booking))
            {
                Label bookingLabel = new Label();
                bookingLabel.Text = $"Trainer: {booking.bookingDescription}, Time: {booking.bookingTime}";
                bookingLabel.HorizontalOptions = LayoutOptions.Center;
                bookingLabel.VerticalOptions = LayoutOptions.Center;
                bookingLabel.TextColor = black;
                stored_bookings.Add(booking);
                stackLayout.Children.Add(bookingLabel);
            }
        }
    }

    public MainPage()
    {
        InitializeComponent();
        this.BindingContext = new BindingLabel();
        //for each (Booking in bookings_list)
        Label upcomingSchedLabel = new Label();

        upcomingSchedLabel.Text = "Upcoming Schedule:";

        upcomingSchedLabel.HorizontalOptions = LayoutOptions.Center;

        upcomingSchedLabel.VerticalOptions = LayoutOptions.Center;

        upcomingSchedLabel.FontSize = 30;
        upcomingSchedLabel.TextColor = black;

        stackLayout.Children.Add(upcomingSchedLabel);
    }
    public class BindingLabel
    {
        public string TrainerName { get; set; }
        public string BookingTime { get; set; }
        public int VisitCount { get; set; }
        public BindingLabel() //Prints out visitcount for the current logged in user
        {
            VisitCount = App.currentUser.numberOfVisits;
        }
    }
}
