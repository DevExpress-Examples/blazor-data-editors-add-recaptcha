using System.ComponentModel.DataAnnotations;

namespace ReCaptcha.Models
{
    public class Model
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
    }
}
