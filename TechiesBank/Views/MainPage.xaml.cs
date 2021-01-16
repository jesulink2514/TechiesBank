
using System;
using Xamarin.Forms;

namespace TechiesBank.Views
{
    public partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void TapGestureRecognizer_OnTapped(object sender, EventArgs e)
        {
            var master = App.Current.MainPage as MasterDetailPage;
            if(master == null) return;
            master.IsPresented = true;
        }
    }
}
