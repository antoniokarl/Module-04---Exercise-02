using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Module04Navigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TabbedPage1 : TabbedPage
    {
        public ObservableCollection<string> Items { get; set; }
        public string SelectedItem { get; set; }
        public TabbedPage1()
        {
            InitializeComponent();

            Items = new ObservableCollection<string>
            {
                "Item no. 1",
                "Item no. 2",
                "Item no. 3",
                "Item no. 4",
                "Item no. 5",
                "Item no. 6",
                "Item no. 7"
            };

            BindingContext = this;
        }
        void OnSubmitEntry(object sender, EventArgs e)
        {
            string entry1Text = fname.Text;
            string entry2Text = lname.Text;
            string entry3Text = myEmail.Text;

            DisplayAlert("Entered Values", $"Entry 1: {entry1Text}\nEntry 2: {entry2Text}\nEntry 3: {entry3Text}", "OK");
        }
    }
}