using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginUI : ContentPage
    {
        public LoginUI()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            bool isUsernameEmpty = string.IsNullOrEmpty(txtUsername.Text);
            bool isPasswordEmpty = string.IsNullOrEmpty(txtPassword.Text);
            if(isUsernameEmpty || isPasswordEmpty)
            {
                DisplayAlert("Oops..", "Username or Password is incorrect","Ok");
            }
            else
            {
                Navigation.PushAsync(new MainPage());
            }
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RegisterPage());
        }
    }
}