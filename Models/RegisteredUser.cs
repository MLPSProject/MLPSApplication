using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MLPSApplication.Models
{
    public class RegisteredUser
    {
        [Key]
        public int Id { get; set; }

        [DataType(DataType.Date)]
        public DateTime dtDateOfRegistration { get; set; }
        public string vFirstName { get; set; }
        public string vLastName { get; set; }

        [DataType(DataType.Date)]
        public DateTime dtDOB { get; set; }

        public string vGender { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string vMobile { get; set; }

        [DataType(DataType.EmailAddress)]
        public string vEmailID { get; set; }
        public string vOccupation { get; set; }
        public string vCity { get; set; }
        public string vAddress { get; set; }
        

        [DataType(DataType.Password)]
        public string vPassword { get; set; }
        public string vConfirmPassword { get; set; }


    }
}