using System;
using System.ComponentModel.DataAnnotations;
using Welcome.Others; // Assuming UserRolesEnum is defined here

namespace Welcome.Model
{
    public class User
    {
        private int id;
        private DateTime expires;

        [Required]
        public required string Names { get; set; }

        [Required]
        public required string Password { get; set; }

        public UserRolesEnum.UserRole Role { get; set; }

        public virtual int Id
        {
            get { return id; }
            set { id = value; }
        }

        public DateTime Expires
        {
            get { return expires; }
            set { expires = value; }
        }
    }
}