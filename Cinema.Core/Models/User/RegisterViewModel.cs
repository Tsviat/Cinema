﻿using Cinema.Infrastructure.Constants;
using System.ComponentModel.DataAnnotations;

namespace Cinema.Core.Models.User
{
    public class RegisterViewModel
    {
        [Required]
        [StringLength(20, MinimumLength = 5)]
        public string UserName { get; set; } = null!;

        [Required]
        [StringLength(DataValidation.UserFirstNameMaxLength, MinimumLength = DataValidation.UserFirstNameMinLength)]
        public string FirstName { get; set; } = null!;

        [Required]
        [StringLength(DataValidation.UserLastNameMaxLength, MinimumLength = DataValidation.UserLastNameMinLength)]
        public string LastName { get; set; } = null!;

        [Required]
        [StringLength(60, MinimumLength = 10)]
        [EmailAddress]
        public string Email { get; set; } = null!;

        [Required]
        [StringLength(20, MinimumLength = 5)]
        [DataType(DataType.Password)]
        public string Password { get; set; } = null!;

        [Required]
        [DataType(DataType.Password)]
        [Compare(nameof(Password))]
        public string ConfirmPassword { get; set; } = null!;
    }
}
