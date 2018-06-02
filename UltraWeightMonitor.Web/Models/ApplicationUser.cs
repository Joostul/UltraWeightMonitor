using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace UltraWeightMonitor.Web.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public Gender Gender { get; set; }
        public int Age { get; set; }
        public int Height { get; set; }
        public List<WeightEntry> WeightEntries { get; set; }
        public TargetWeight TargetWeight { get; set; }
    }
}
