using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.DtoLayer.AppUserDtos
{
    public class AppUserRegisterDto
    {
        //[Required(ErrorMessage ="Ad teleb olunur")]
        //[Display(Name ="Ad")]
        //[MaxLength(16,ErrorMessage ="Maximum 16 char yazila biler!")]
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
