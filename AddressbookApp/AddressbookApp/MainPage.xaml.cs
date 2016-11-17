using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AddressbookApp.Interface;
using Xamarin.Forms;

namespace AddressbookApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            var contacts = DependencyService.Get<IContacts>();
            //AddressBookListView.ItemsSource = contacts.Working();
            AddressBookListView.ItemsSource = contacts.Exception();
        }
    }
}
