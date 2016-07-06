using FluentValidation.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BoooooJu.Web.Core.ViewModels.Base
{
    public class MobilePhoneValidator : PropertyValidator, IRegularExpressionValidator
    {
        private readonly Regex Regex;
        private const string expression = @"^(0|86|17951)?(13[0-9]|15[012356789]|17[678]|18[0-9]|14[57])[0-9]{8}$";
        public MobilePhoneValidator() : base(() => "手机号码格式不正确")
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
