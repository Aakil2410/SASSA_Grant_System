using System.ComponentModel.DataAnnotations;

namespace SASSAGrantSystem.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}