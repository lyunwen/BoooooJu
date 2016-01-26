using BoooooJu.Web.Core.ViewModels.Base;
using FluentValidation;
using FluentValidation.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoooooJu.Web.Core.ViewModels.Account
{
    [Validator(typeof(RegisterModelValidator))]
    public class RegisterModel
    {
        //昵称
        public string NickName { get; set; }
        public int Sex { get; set; }
        public string Signature { get; set; }
        public string EmailAddress { get; set; }
        public string CellPhone { get; set; }
        public string Pswd { get; set; }

    }
    public class RegisterModelValidator : AbstractValidator<RegisterModel>
    {
        public RegisterModelValidator()
        {
            RuleFor(model => model.NickName).NotEmpty().Length(6, 16);
            RuleFor(model => model.CellPhone).NotEmpty().MobilePhone();
            RuleFor(model => model.Pswd).NotEmpty().PasswordFormat();
        }
    }
}
