using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;

namespace MyAspNetCoreApp.Web.ViewModels
{
    public class ProductViewModel
    {
        public int Id { get; set; }

        [StringLength(50,ErrorMessage ="İsim alanına en fazla 50 karakter girilebilir.")]
        [Required(ErrorMessage ="İsim alanı boş olamaz")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Fiyat alanı boş olamaz.")]
        [Range(1, 1000, ErrorMessage = "Fiyat alanı 1 ile 1000 arasında bir değer olmalıdır.")]
        public decimal? Price { get; set; }

        [Required(ErrorMessage = "Stok alanı boş olamaz.")]
        [Range(1,200,ErrorMessage = "Stok alanı 1 ile 200 arasında bir değer olmalıdır.")]
        public int? Stock { get; set; }

        [StringLength(300,MinimumLength=50,ErrorMessage = "Açıklama alanı 50 ile 300 karakter arasında olabilir.")]
        [Required(ErrorMessage = "Açıklama alanı boş olamaz.")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Renk seçimi boş olamaz.")]
        public string? Color { get; set; }

        [Required(ErrorMessage = "Yayınlanma tarihi boş olamaz.")]
        public DateTime? PublishDate { get; set; }
        public bool IsPublish { get; set; }

        [Required(ErrorMessage = "Yayınlanma süresi boş olamaz.")]
        public int? Expire { get; set; }

        [EmailAddress(ErrorMessage ="Email adresi uygun formatta değil")]
        public string EmailAddress { get; set; }
    }
}
