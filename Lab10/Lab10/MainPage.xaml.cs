using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Lab10
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        int ContAsyn = 1;
        int ContSync = 1;
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnView_Clicked(object sender, EventArgs e)
        {


            await Navigation.PushAsync(new ViewToViewDemo());

        }

        private async void btnBinding_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BindingModeDemo());

        }

        private async void btnListView_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ListViewDemo());

        }

        private async void btnPicker_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PickerDemo());
        }

        private async void btnTestAsync_Clicked(object sender, EventArgs e)
        {
            lblAsync.Text = await CalcularAsync();
            //   await  DisplayAlert("Alert", "You have been alerted", "OK");
        }

        private void btnTestSync_Clicked(object sender, EventArgs e)
        {
            lblSync.Text = CalcularSync();
            //   DisplayAlert("Alert", "You have been alerted", "OK");
        }



        private async Task<string> CalcularAsync()
        {
            await Task.Delay(5000);
            return await Task.FromResult<string>(Convert.ToString(ContAsyn++));
        }

        private string CalcularSync()
        {
            Thread.Sleep(5000);
            return Convert.ToString(ContSync++);
        }

        private async void btnShowAlert_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Alert", "You have been alerted", "OK");
        }
    }
}