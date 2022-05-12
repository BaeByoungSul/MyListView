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
    public partial class UnevenRow : ContentPage
    {
        public UnevenRow()
        {
            InitializeComponent();
            lstv1.ItemsSource = new[] {
            "To be, or not to be,",
                "that is the question— Whether 'tis Nobler in the mind to suffer",
                @"The Slings and Arrows of outrageous Fortune,
Or to take Arms against a Sea of troubles,",
                @"And by opposing end them? To die, to sleep—
No more; and by a sleep, to say we end
The Heart-ache, and the thousand Natural shocks",
                @"That Flesh is heir to? 'Tis a consummation
Devoutly to be wished. To die, to sleep,
To sleep, perchance to Dream; Aye, there's the rub,
For in that sleep of death, what dreams may come,",
                @"When we have shuffled off this mortal coil,
Must give us pause. "

            };

            lstv1.ItemSelected += Lstv1_ItemSelected;
        }

        private void Lstv1_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e == null) return;
            DisplayAlert("Tapped", e.SelectedItem + " row was tapped" , "Ok");
            ((ListView)sender).SelectedItem = null;

        }
    }
}