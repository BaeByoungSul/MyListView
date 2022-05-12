using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyListView.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContextAction : ContentPage
    {
        ObservableCollection<string> items;
        public ContextAction()
        {
            InitializeComponent();

            items = new ObservableCollection<string>() { "alpha", "beta", "gamma", "delta", "epsilon" };
            
            lstv1.ItemsSource = items;
            
            //lstv1.SetBinding(ListView.ItemsSourceProperty, new Binding("."));
            //lstv1.BindingContext = items;

            lstv1.ItemSelected += Lstv1_ItemSelected;
            
        }

        private void Lstv1_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null) return; // has been set to null, do not 'process' tapped event
            DisplayAlert("Tapped", e.SelectedItem + " row was tapped", "OK");
            ((ListView)sender).SelectedItem = null; // de-select the row
        }

        private void mnuItemMore_Clicked(object sender, EventArgs e)
        {
            var mi = ((MenuItem)sender);
            DisplayAlert("More Context Action", mi.CommandParameter + " more context action", "OK");
            items.Add("Added Item");
        }

        private void mnuItemDelete_Clicked(object sender, EventArgs e)
        {
            var mi = ((MenuItem)sender);
            //DisplayAlert("Delete Context Action", mi.CommandParameter + " delete context action", "OK");

            Debug.WriteLine("delete " + mi.CommandParameter.ToString());
            items.Remove(mi.CommandParameter.ToString());
        }
    }
}