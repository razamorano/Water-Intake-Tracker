using System;
using System.ComponentModel;

namespace WaterIntakeTracker.Models
{
    public class Profile //: INotifyPropertyChanged
    {
        //string name = "Grace";
        //public string Name
        //{
        //    get => name;
        //    set
        //    {
        //        if (name == value)
        //            return;

        //        name = value;
        //        OnPropertyChanged(nameof(Name));
        //    }
        //}

        //public event PropertyChangedEventHandler PropertyChanged;
        //void OnPropertyChanged(string name)
        //{
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        //}

        public string Name { get; set; }
        public float Weight { get; set; }
        public int Bottlesize { get; set; }
        public float Waterrequired { get; set; }
        public float Bottlesrequired { get; set; }
        public int Bottles { get; set; }
        public DateTime Date { get; set; }
    }
}

