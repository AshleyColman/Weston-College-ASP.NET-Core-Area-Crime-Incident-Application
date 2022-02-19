using System.ComponentModel.DataAnnotations;

namespace UI.Models
{
    public sealed class QueryModel
    {
        [Required(ErrorMessage = "Latitude is required", AllowEmptyStrings = false)]
        [Display(Name = "Latitude:")]
        public double Latitude { get; set; }

        [Required(ErrorMessage = "Latitude is required", AllowEmptyStrings = false)]
        [Display(Name = "Longitude:")]
        public double Longitude { get; set; }

        [Required(ErrorMessage = "Date is required")]
        [Display(Name = "Date:")]
        public DateTime Date { get; set; }
    }
}
