using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace WaterIntakeTracker
{
    public partial class UserProfilePage : ContentPage
    {
        public UserProfilePage()
        {
            InitializeComponent();
        }

        private void saveBTN(object sender, EventArgs e)
        {
            //Navigation.PushAsync(new WaterTrackPage());
            Navigation.PopAsync();
        }
    }
}
