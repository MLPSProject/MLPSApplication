using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MLPSApplication.Models
{
    public class Inspector
    {
        [Key]
        public int Id { get; set; }
        public string vName { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string vMobile { get; set; }
        [DataType(DataType.EmailAddress)]
        public string vEmail { get; set; }

        //References

        public MortgageOfficer MortgageOfficer { get; set; }
        public int MortgageOfficerId { get; set; }

        //public RegisteredUser RegisteredUser { get; set; }
        //public int RegisteredUserId { get; set; }

        //public UnRegisteredUser UnRegisteredUser { get; set; }
        //public int UnRegisteredUserId { get; set; }

        //public PropertyDetail PropertyDetail { get; set; }
        //public int PropertyDetailId { get; set; }



    }
}