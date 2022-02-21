using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace HrPtoManagement.Web.Models
{
    public class PtoTypeViewModel
    {
        public int Id { get; set; }

        [Display(Name = "PTO Type Name")]
        [Required]
        public string Name { get; set; }

        [Display(Name = "Default Number of Days")]
        [Required]
        [Range(1, 25, ErrorMessage = "Please enter a number between 1 and 25")]
        public int DefaultDays { get; set; }
    }
}
