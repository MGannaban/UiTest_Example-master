using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace UiTest_Example
{
	public partial class MainPage : TabbedPage
	{
		public MainPage()
		{
			InitializeComponent();

            btnDisp.Clicked += BtnDisp_Clicked;
            btnAdd.Clicked += BtnAdd_Clicked;
            btnSubtract.Clicked += BtnSubtract_Clicked;
            btnDivide.Clicked += BtnDivide_Clicked;
            btnTimes.Clicked += BtnTimes_Clicked;
		}

        private void BtnTimes_Clicked(object sender, EventArgs e)
        {
            double x = double.Parse(num1.Text);
            double y = double.Parse(num2.Text);
            result.Text = (x * y).ToString();
        }

        private void BtnDivide_Clicked(object sender, EventArgs e)
        {
            double x = double.Parse(num1.Text);
            double y = double.Parse(num2.Text);
            result.Text = (x / y + 1).ToString();
        }

        private void BtnSubtract_Clicked(object sender, EventArgs e)
        {
            double x = double.Parse(num1.Text);
            double y = double.Parse(num2.Text);
            result.Text = (x - y).ToString();
        }

        private void BtnAdd_Clicked(object sender, EventArgs e)
        {
            double x = double.Parse(num1.Text);
            double y = double.Parse(num2.Text);
            result.Text = (x + y).ToString();
        }

        private async void BtnDisp_Clicked(object sender, EventArgs e)
        {
            var info = string.Format("My Name is {0}\nFrom {1}\nI am {2}\n Born on {3}",
                txtName.Text, txtAddress.Text, pickGender.SelectedItem as string, pickBday.Date.ToShortDateString());
            await DisplayAlert("Info", info, "OKAY");
        }
    }
}
