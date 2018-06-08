using System.ComponentModel.DataAnnotations;

namespace Forwarder.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}