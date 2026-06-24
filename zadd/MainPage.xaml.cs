using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace zadd
{
    public partial class MainPage : CarouselPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.CurrentPage = this.Children[0];
        }
    }
}
