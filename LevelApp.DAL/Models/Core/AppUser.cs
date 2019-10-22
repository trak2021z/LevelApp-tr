﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using LevelApp.DAL.Models.Base;

namespace LevelApp.DAL.Models.Core
{
    [Table("CoreAppUser")]
    public class AppUser : Entity<int>
    {
        [Required]
        [MaxLength(30)]
        public string Email { get; set; }
        
        [MaxLength(30)]
        public string FirstName { get; set; }
        
        [MaxLength(30)]
        public string LastName { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string PasswordHash { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string PasswordSalt { get; set; }
    }
}