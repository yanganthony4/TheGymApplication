using MySqlConnector;
using TheGymApplication;

namespace TheGymApplication;

public partial class MainPage : ContentPage
{
	int count = 0;

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
            using(MySqlConnection connection = SingeltonConnection.Connection) // use the SingletonConnection class to get the MySqlConnection
                {
                MySqlCommand command = new MySqlCommand("SELECT FirstName FROM Trainers", connection);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        FirstName = reader.GetString(0); // assign the first name to the FirstName property
                    }
                }
            }
        }
    }
}

