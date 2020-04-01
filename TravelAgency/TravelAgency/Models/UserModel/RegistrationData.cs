﻿using System.ComponentModel.DataAnnotations;

namespace TravelAgency.Models.UserModel
{
    public class RegistrationData
    {
        [Required]
        public string Login { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [RegularExpression(".{6,}")]
        public string Password { get; set; }
        
        [Compare(nameof(Password))]
        public string RepeatPassword { get; set; }

        public string MobilePhone { get; set; }

        [RegularExpression("[А-Я]{1}[а-я]{2,10}",
            ErrorMessage = "Имя должно начинаться с заглавной буквы, длина-мин. 3 символа, длина-макс. 10 символов.")]
        public string Lastname { get; set; }

        [RegularExpression("[А-Я]{1}[а-я]{2,10}",
            ErrorMessage = "Фамилия должна начинаться с заглавной буквы, длина-мин. 3 символа, длина-макс. 10 символов.")]
        public string Firstname { get; set; }


    }
}