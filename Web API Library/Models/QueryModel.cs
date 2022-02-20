using System.ComponentModel.DataAnnotations;
using Web_API_Library.Validation;

namespace Web_API_Library.Models
{
    public sealed class QueryModel : IQueryModel
    {
        [Required(ErrorMessage = "Latitude is required", AllowEmptyStrings = false)]
        [Display(Name = "Latitude")]
        [Range(double.MinValue, double.MaxValue, ErrorMessage = "Please enter a valid double number")]
        public double Latitude { get; set; }

        [Required(ErrorMessage = "Latitude is required", AllowEmptyStrings = false)]
        [Display(Name = "Longitude")]
        [Range(double.MinValue, double.MaxValue, ErrorMessage = "Please enter a valid double number")]
        public double Longitude { get; set; }

        [Required(ErrorMessage = "Date is required")]
        [Display(Name = "Date")]
        [ValidDate(ErrorMessage = "Please enter a valid date")]
        public DateTime Date { get; set; }
    }
}
