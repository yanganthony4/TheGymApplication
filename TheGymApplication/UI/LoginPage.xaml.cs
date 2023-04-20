using System;
using TheGymApplication.Entities;

namespace TheGymApplication;

public partial class LoginPage : ContentPage
{
    public bool IncorrectPasswordUser { get; set; }
	public LoginPage()
	{
		InitializeComponent();
        IncorrectPasswordUser = false;
	}

    private async void OnLoginButtonClicked(object sender, EventArgs e)
    {
        List<User> users_list = User.PopulateUserList();
        foreach (User user in users_list)
        {
            if (UsernameEntry.Text == user.userEmail || PasswordEntry.Text == user.userPassword)
            {
                await Shell.Current.GoToAsync("//Home");
            } 
            else
            {
                IncorrectPasswordUser = true;
            }
        }
        
    }
}