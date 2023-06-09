using System;
using TheGymApplication.Entities;

namespace TheGymApplication;

public partial class LoginPage : ContentPage
{
    List<User> users_list = User.PopulateUserList();
    public LoginPage()
	{
		InitializeComponent();
        
	}

    private async void OnLoginButtonClicked(object sender, EventArgs e) //Checks if user input matches username and password in database
    {
        Book.ClearBookings();
        
        foreach (User user in users_list)
        {
            if (UsernameEntry.Text == user.userEmail && PasswordEntry.Text == user.userPassword)
            {
                App.currentUser = user;
                await Shell.Current.GoToAsync("//Home");
                //await Shell.Current.GoToAsync($"//Home?userEmail={user.userEmail}&userFirstName={user.userFName}&userLastName={user.userLName}&userId={user.userId}&userNumberOfVisits={user.numberOfVisits}");
            } 
            
        }
        
    }
}