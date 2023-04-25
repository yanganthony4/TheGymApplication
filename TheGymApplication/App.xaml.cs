namespace TheGymApplication;

using System.Security.Cryptography.X509Certificates;
using TheGymApplication.Entities;
public partial class App : Application
{
    public static User currentUser { get; set; }
    public App()
	{
		InitializeComponent();
		MainPage = new AppShell();
		
	}
}
