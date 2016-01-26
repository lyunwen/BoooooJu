using BoooooJu.Web.Core.ViewModels.Base;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoooooJu.Web.Core.ViewModels
{
    public static class FluentValidatorExtensions
    {
        public static IRuleBuilderOptions<T, string> MobilePhone<T>(this IRuleBuilder<T, string> ruleBuilder)
        {
            return ruleBuilder.SetValidator(new MobilePhoneValidator());
        }

        public static IRuleBuilderOptions<T, string> PasswordFormat<T>(this IRuleBuilder<T, string> ruleBuilder)
        {
            return ruleBuilder.SetValidator(new PasswordValidator());
        }
    }
}
