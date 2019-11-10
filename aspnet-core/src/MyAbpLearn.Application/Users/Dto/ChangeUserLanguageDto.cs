using System.ComponentModel.DataAnnotations;

namespace MyAbpLearn.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}