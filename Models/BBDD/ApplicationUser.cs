using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace defensoresTablada

{
    public class ApplicationUser : IdentityUser
    {
        [MaxLength(200)]
        public string Nombre { get; set; }

        [MaxLength(200)]
        public string Apellido { get; set; }
        public string FirstName { get; internal set; }
        public string LastName { get; internal set; }
    }
}