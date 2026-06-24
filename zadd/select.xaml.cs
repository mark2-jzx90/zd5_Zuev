using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.XPath;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace zadd
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class select : ContentPage
    {
        public select()
        {
            InitializeComponent();
            sliderValue.ValueChanged += OnSliderValueChanged;
            pickerOptions.SelectedIndex = 0;
        }


        //описания для выбранного варианта
        private string GetDescription(string option)
        {
            switch (option)
            {
                case "Вариант 1 - Стандартный":
                    return "Стандартный режим работы с базовыми функциями";
                case "Вариант 2 - Расширенный":
                    return "Расширенный режим с дополнительными возможностями";
                case "Вариант 3 - ПРО":
                    return "ПРО-режим со всеми доступными функциями";
                default:
                    return "Описание недоступно";
            }
        }


        //обновление отображения значения слайдера
        private void SliderChanged(object sender, ValueChangedEventArgs e)
        {
            lblSliderValue.Text = Math.Round(e.NewValue).ToString();
        }

        //отображение выбранного варианта
        private void ShowResult(object sender, EventArgs e)
        {
            string selectedOption = pickerOptions.Items[pickerOptions.SelectedIndex];
            double maxValue = sliderValue.Value;

            lblSelectedOption.Text = $"Выбранный вариант: {selectedOption}";
            lblSliderMax.Text = $"Макс. значение слайдера: {maxValue:F0}";
            lblDescription.Text = GetDescription(selectedOption);
            resultFrame.IsVisible = true;
        }
    }
}