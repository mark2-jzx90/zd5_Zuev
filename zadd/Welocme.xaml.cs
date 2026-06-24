using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace zadd
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Welcome : ContentPage
    {
        public Welcome()
        {
            InitializeComponent();
        }



        // заполнения полей и Sign In
        private void OnEntry(object sender, TextChangedEventArgs e)
        {
            bool isNameFilled = !string.IsNullOrWhiteSpace(txtName.Text);
            bool isPasswordFilled = !string.IsNullOrWhiteSpace(txtPassword.Text);

            SignIn.IsEnabled = isNameFilled && isPasswordFilled;

            if (SignIn.IsEnabled)
                SignIn.StyleClass = new[] { "welcome-button" };
            else
                SignIn.StyleClass = new[] { "welcome-button-disabled" };
        }

        //второй экран с имени пользователя
        private async void OnSign(object sender, EventArgs e)
        {
            string userName = txtName.Text;

            var carouselPage = Application.Current.MainPage as CarouselPage;
            if (carouselPage != null)
            {
                var profilePage = carouselPage.Children[1] as Profile;
                if (profilePage != null)
                    profilePage.SetUserInfo(userName);

                carouselPage.CurrentPage = carouselPage.Children[1];
            }
        }
    }
}