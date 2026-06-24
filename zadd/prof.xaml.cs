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
    public partial class prof : ContentPage
    {
        public prof()
        {
            InitializeComponent();
        }

        //переход на третий экран
        private async void OnGoToSelectionClicked(object sender, EventArgs e)
        {
            var carouselPage = Application.Current.MainPage as CarouselPage;
            if (carouselPage != null)
                carouselPage.CurrentPage = carouselPage.Children[2];
        }

        // Получение, отображение пользователя
        public void UserInfo(string userName)
        {
            lblUserName.Text = userName;
        }

        
    }
}