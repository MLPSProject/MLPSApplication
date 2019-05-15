using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MLPSApplication.Models
{
    public class PropertyDetail
    {
        [Key]
        public int Id { get; set; }
        public string vPropertyHolderName { get; set; }
        public string vPropertyType { get; set; }
        public string PropertyAddress { get; set; }
        public int iMarketValue { get; set; }
        public string vRemarks { get; set; }

        public string IdProof { get; set; }

        public string AddressProof { get; set; }

        public string PropertyAgreement { get; set; }

        //References

        [ForeignKey("Officer")]
        public int? OfficerId { get; set; }
        public virtual Employee Officer { get; set; }

        [ForeignKey("Inspector")]
        public int? InspectorId { get; set; }
        public virtual Employee Inspector { get; set; }

        [ForeignKey("Authorizer")]
        public int? AuthorizerId { get; set; }
        public virtual Employee Authorizer { get; set; }






    }
}