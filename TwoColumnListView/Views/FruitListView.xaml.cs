using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TwoColumnListView.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FruitListView : ContentPage
    {
        public ObservableCollection<string> Items { get; set; }

        public FruitListView()
        {
            InitializeComponent();
        }
    }
}
