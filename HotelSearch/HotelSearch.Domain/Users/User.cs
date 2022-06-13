using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HotelSearch.Domain.Users
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        #region Basic Info

        [Required]
        [StringLength(50, ErrorMessage = "Kullanıcı adınız 50 karakterden uzun olamaz")]
        [Display(Name = "Kullanıcı Adı")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Şifre gerekli")]
        [DataType(DataType.Password)]
        [Display(Name = "Şifre")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Email gerekli")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Kayıt Tarihi")]
        public DateTime RegistrationDate { get; set; }

        public User()
        {
            RegistrationDate = DateTime.Now;
        }

        #endregion

        public bool IsActive { get; set; }

        public bool IsDelete { get; set; }

       
    }
}
