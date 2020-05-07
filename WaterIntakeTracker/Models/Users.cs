using System;
namespace WaterIntakeTracker.Models
{
    public class Users
    {
        public string Name { get; set; }
        public float Weight { get; set; }
        public int Bottlesize { get; set; }
        public float Waterrequired { get; set; }
        public float Bottlesrequired { get; set; }
        public int Bottles { get; set; }
        public DateTime Date { get; set; }
    }
}
