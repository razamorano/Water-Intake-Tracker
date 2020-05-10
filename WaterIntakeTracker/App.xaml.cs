using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WaterIntakeTracker
{
    public partial class App : Application
    {
        //public static string FolderPath { get; set; }
        public App()
        {
            InitializeComponent();

            //FolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData));
            //MainPage = new WaterTrackPage();

            //New definition to open more than one page
            MainPage = new NavigationPage(new WaterTrackPage());
        }
    }
}
