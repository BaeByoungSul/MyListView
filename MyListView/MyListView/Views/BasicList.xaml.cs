using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyListView.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BasicList : ContentPage
    {
        public BasicList()
        {
            InitializeComponent();
            this.BindingContext = new[] { "a", "b", "c" };

            lstv1.ItemTapped += Lstv1_ItemTapped;
        }

        private async void Lstv1_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e == null) return;
            await DisplayAlert("Tapped", e.Item.ToString(), "Ok");
            ((ListView)sender).SelectedItem = null;

        }
    }
}