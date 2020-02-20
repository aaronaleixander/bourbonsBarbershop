using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace bourbonsBarbershop.Models
{
    public class Talent
    {
        [Key]
        public int TalentId { get; set; }

        public string LicenceNumber { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }

        public string PhoneNumber { get; set; }


        // https://stackoverflow.com/questions/33012853/how-to-add-image-property-in-my-model
        public string Image { get; set; } 
    }
}
