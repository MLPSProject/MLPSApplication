using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MLPSApplication.Models
{
    public class Authorizer
    {
        [Key]
        public int Id { get; set; }
        public string vName { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string vMobile { get; set; }
        [DataType(DataType.EmailAddress)]
        public string vEmailID { get; set; }
        public int iApprovedLoanAmount { get; set; }

        //References

        //public LoanDetail LoanDetail { get; set; }
        //public int LoanDetailId { get; set; }

        //public PropertyDetail PropertyDetail { get; set; }
        //public int PropertyDetailId { get; set; }


    }
}