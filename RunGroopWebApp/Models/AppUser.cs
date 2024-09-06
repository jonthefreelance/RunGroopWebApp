using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RunGroopWebApp.Models
{
    //public class AppUser
    public class AppUser : IdentityUser
    {
        //[Key]
        //public string Id { get; set; }
        public int? Pace { get; set; }
        public int? Mileage { get; set; }
        [ForeignKey("Address")]
        public int AddressId { get; set; }
        public Address? Address { get; set; }
        public int MyProperty { get; set; }
        public ICollection<Club> Clubs { get; set; }
        public ICollection<Race> Races { get; set; }

    }
}
