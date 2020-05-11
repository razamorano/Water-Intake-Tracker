using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Xamarin.Forms;
using WaterIntakeTracker.Models;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;

namespace WaterIntakeTracker
{
    public partial class WaterTrackPage : ContentPage
    {
        private string nameLBL;
        private float waterLtLBL;
        private float waterbottleLBL;
        private string bottlesLBL;
        //initializate the string and make it private

        public string NameLBL
        {
            get { return nameLBL; }
            set
            {
                nameLBL = value;
                OnPropertyChanged(nameof(NameLBL));
            }
        }

        public WaterTrackPage()
        {
            InitializeComponent();
            
            //initializate the banding context
            //this;
        }

        async void editprofileBTN(object sender, EventArgs e)
        {
            var user = new Profile
            {
                Name = nameLBL
            };

            var secondPage = new UserProfilePage();
            secondPage.BindingContext = user;
            await Navigation.PushAsync(secondPage);
        }
            
        //edit profile button
        //private void editprofileBTN(object sender, EventArgs e)
        //{
        //    Navigation.PushAsync(new UserProfilePage());
        //}

        

        ////initializate the string a make it private
        //public string BottlesLBL
        //{
        //    get { return bottlesLBL; }
        //    set
        //    {
        //        bottlesLBL = value;
        //        OnPropertyChanged(nameof(BottlesLBL));
        //    }
        //}

        //control of the stepper
        void OnStepperBottleValue(object sender, ValueChangedEventArgs e)
        {
            //BindingContext = this;
            //BottlesLBL = Convert.ToString(e.NewValue);
        }

        //protected override void OnStart()
        //protected override void OnSleep()
        //protected override void OnResume()
    }
}
