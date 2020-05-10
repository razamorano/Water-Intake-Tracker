using System;
using System.Collections.Generic;
using WaterIntakeTracker.Models;
using Xamarin.Forms;

namespace WaterIntakeTracker
{
    public partial class UserProfilePage : ContentPage
    {
        public string NameLBL { get; set; }

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
