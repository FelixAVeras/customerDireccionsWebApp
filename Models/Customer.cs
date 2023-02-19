using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CustomerDirectionsWebApp.Models
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }

        [Required]
        [Display(Name = "Nombre")]
        [StringLength(20, ErrorMessage = "Este campo admite {1} caracteres como maximo.")]
        public string FirstName { get; set; }
        
        [Required]
        [Display(Name = "Apellido")]
        [StringLength(20, ErrorMessage = "Este campo admite {1} caracteres como maximo.")]
        public string LastName { get; set; }
        
        [Display(Name = "Nombre Completo")]
        public string FullName { get { return this.FirstName + " " + this.LastName; } }

        [Required]
        [Display(Name = "Correo Electronico")]
        [StringLength(100, ErrorMessage = "Este campo admite {1} caracteres como maximo.")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Telefono")]
        [StringLength(12, ErrorMessage = "Este campo admite {1} caracteres como maximo.")]
        public string Phone { get; set; }

        public virtual ICollection<Address> Addresses { get; set; }
    }
}