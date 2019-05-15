using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MLPSApplication.Models
{
    public class MortgageOfficer
    {
        [Key]
        public int Id { get; set; }
        public string vName { get; set; }

        [DataType(DataType.EmailAddress)]
        public string vEmail { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }

        //References

        public Inspector Inspector { get; set; }
        public int InspectorId { get; set; }

        public LoanDetail LoanDetail { get; set; }
        public int LoanDetailId { get; set; }

        public PropertyDetail PropertyDetail { get; set; }
        public int PropertyDetailId { get; set; }

        public Authorizer Authorizer { get; set; }
        public int AuthorizerId { get; set; }



    }
}