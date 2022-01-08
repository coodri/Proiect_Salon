using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proiect_Salon.SalonModels;
using SQLite;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Proiect_Salon
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListEntryPage : ContentPage
    {
        public ListEntryPage()
        {
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            recenziiView.ItemsSource = await App.Database.GetRecenziisAsync();
        }
        async void OnRecenziiAddedClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ListPage
            {
                BindingContext = new Recenzii()
            });
        }
        async void OnRecenziiItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new ListPage
                {
                    BindingContext = e.SelectedItem as Recenzii
                });
            }
        }
    }
}