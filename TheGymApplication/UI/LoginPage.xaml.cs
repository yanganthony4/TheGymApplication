using System;
using TheGymApplication.Entities;

namespace TheGymApplication;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}

    private async void OnLoginButtonClicked(object sender, EventArgs e)
    {
        User.PopulateUserList();
        await Shell.Current.GoToAsync("//Home");
    }
}