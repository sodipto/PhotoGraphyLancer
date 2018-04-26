using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolCat.PhotoGrapherLancer.Core.Entities.PublicProfilePhotoGrapher
{
   public class ClientContact
    {
        [Key]
        public int ContactId { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Name is required")]
        public string Name { get; set; }


        [Required(AllowEmptyStrings = false, ErrorMessage = "Email is required")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [MinLength(11,ErrorMessage = "At Least 11"),MaxLength(14, ErrorMessage = "Maximum")]
        public int? Phone { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Message is required")]
        [MinLength(20,ErrorMessage = "Mimimum Type 20 character"),MaxLength(120, ErrorMessage = "Not Gretter Then 120 Character")]
        public String Message { get; set; }






    }
}
