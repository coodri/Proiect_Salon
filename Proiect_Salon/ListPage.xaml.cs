using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proiect_Salon.SalonModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Proiect_Salon
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListPage : ContentPage
    {
        public ListPage()
        {
            InitializeComponent();
        }
        async void OnSaveButtonClicked(object sender, EventArgs e)
        {
            var slist = (Recenzii)BindingContext;
            slist.Date = DateTime.UtcNow;
            await App.Database.SaveRecenziiAsync(slist);
            await Navigation.PopAsync();
        }

        async void OnDeleteButtonClicked(object sender, EventArgs e)
        {
            var slist = (Recenzii)BindingContext;
            await App.Database.DeleteRecenziiAsync(slist);
            await Navigation.PopAsync();
        }
    }
}