using FluentValidation.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BoooooJu.Web.Core.ViewModels.Base
{
    public class PasswordValidator : PropertyValidator, IRegularExpressionValidator
    {
        //以字母开头，长度在6~18之间，只能包含字符、数字和下划线。 
        private readonly Regex Regex;
        private const string expression = @"^[a-zA-Z]\w{5,17}$";
        public PasswordValidator() : base(() => "密码须以字母开头，长度在6至18位")
        {
            Regex = new Regex(expression, RegexOptions.IgnoreCase);
        }

        public string Expression
        {
            get { return expression; }
        }

        protected override bool IsValid(PropertyValidatorContext context)
        {
            if (context.PropertyValue == null) return true;

            if (!Regex.IsMatch((string)context.PropertyValue))
            {
                return false;
            }

            return true;
        }
    }
}
