using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Xml.XPath;
using System.Net.Http;
using System.Xml.Linq;

namespace zadd
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
            myDatePicker.Date = DateTime.Today; // Ставим текущую дату при старте
            LoadRates();
        }
        // Вызывается автоматически при выборе даты в DatePicker
        private void OnDateSelected(object sender, DateChangedEventArgs e)
        {
            LoadRates();
        }

        private void LoadRates()
        {
            USD.Text = "USD: 80 руб.";
            EUR.Text = "EUR: 86 руб.";
        }
    }
}