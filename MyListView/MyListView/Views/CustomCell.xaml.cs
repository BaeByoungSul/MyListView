using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyListView.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CustomCell : ContentPage
    {
        public CustomCell()
        {
            InitializeComponent();
            lstv1.ItemsSource = new[] { "a", "b", "c" };

            lstv1.ItemSelected += Lstv1_ItemSelected;

        }

        private void Lstv1_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null) return; // has been set to null, do not 'process' tapped event
            DisplayAlert("Tapped", e.SelectedItem + " row was tapped", "OK");
            ((ListView)sender).SelectedItem = null; // de-select the row

        }

        private async void OnCellClicked(object sender, EventArgs e)
        {
            var b = (Button)sender;
            var t = b.CommandParameter;

            await((ContentPage)((ListView)((ViewCell)((StackLayout)b.Parent).Parent).Parent).Parent).DisplayAlert("Clicked", t + " button was clicked", "OK");
            Debug.WriteLine("clicked " + t);
        }


    }
}