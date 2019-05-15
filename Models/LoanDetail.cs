using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MLPSApplication.Models
{
    public class LoanDetail
    {
        [Key]
        public int Id { get; set; }
        public string vName { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string vMobile { get; set; }
        [DataType(DataType.EmailAddress)]
        public string vEmail { get; set; }
        public string vCity { get; set; }
        public int iAge { get; set; }
        public string vOccupation { get; set; }
        public string vAddress { get; set; }
        public double dLoanAmount { get; set; }
        public int iRateOfInterest { get; set; }
        public DateTime dtLoanAppliedDate { get; set; }
        public DateTime dtLoanApprovedDate { get; set; }
        public int iDuration { get; set; }
        public string vStatus { get; set; }

        //References

        public RegisteredUser RegisteredUser { get; set; }
        public int RegisteredUserId { get; set; }

        public UnRegisteredUser UnRegisteredUser { get; set; }
        public int UnRegisteredUserId { get; set; }

        public PropertyDetail PropertyDetail { get; set; }
        public int PropertyDetailId { get; set; }



    }
}