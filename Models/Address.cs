using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CustomerDirectionsWebApp.Models
{
    public class Address
    {
        [Key]
        public int AddressID { get; set; }

        [Required]
        [Display(Name = "Direccion")]
        [StringLength(180, ErrorMessage = "Este campo admite {1} caracteres como maximo.")]
        public string AddressName { get; set; }

        public int CustomerID { get; set; }
        public virtual Customer Customer { get; set; }
    }
}