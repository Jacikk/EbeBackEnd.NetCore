using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EbeBackEnd.NetCore.Models
{
    public class Register
    {
        private string email, password, confirmPassword;

        public Register() { }
        public Register(string email, string password, string confirmPassword)
        {
            this.email = email;
            this.password = password;
            this.confirmPassword = confirmPassword;

        }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [EmailAddress(ErrorMessage = "O campo {0} esta em formato inválido")]
        public string Email { get => email; set => email = value; }
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(45, ErrorMessage = "O campo {0} precisa ter entre 8 e 45 caracteres", MinimumLength = 8)]
        public string Password { get => password; set => password = value; }
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(45, ErrorMessage = "O campo {0} precisa ter entre 8 e 45 caracteres", MinimumLength = 8)]
        [Compare("Password", ErrorMessage = "As senhas não conferem")]
        public string ConfirmPassword { get => confirmPassword; set => confirmPassword = value; }
    }
    public class Login
    {
        private string email, password;
        public Login()
        {

        }

        public Login(string email, string password)
        {
            this.email = email;
            this.password = password;
        }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [EmailAddress(ErrorMessage = "O campo {0} esta em formato inválido")]
        public string Email { get => email; set => email = value; }
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(45, ErrorMessage = "O campo {0} precisa ter entre 8 e 45 caracteres", MinimumLength = 8)]
        public string Password { get => password; set => password = value; }
    }

}
