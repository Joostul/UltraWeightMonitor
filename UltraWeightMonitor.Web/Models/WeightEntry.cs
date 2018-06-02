using System;

namespace UltraWeightMonitor.Web.Models
{
    public class WeightEntry
    {
        private double _bmi { get; set; }

        public WeightEntry(DateTime date, double weight)
        {
            Date = date;
            Weight = weight;
        }

        public DateTime Date { get; set; }
        public double Weight { get; set; }
        public double BMI {
            get {
                if(_bmi >= 0)
                {
                    // Calculate BMI
                    // Save to _bmi
                }
                return _bmi;
            }
        }
        public string Notes { get; set; }
    }
}
