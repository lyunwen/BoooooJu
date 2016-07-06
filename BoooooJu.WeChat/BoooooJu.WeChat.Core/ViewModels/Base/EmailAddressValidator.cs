using FluentValidation.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BoooooJu.Web.Core.ViewModels.Base
{
    public  class EmailAddressValidator : PropertyValidator, IRegularExpressionValidator
    { 
        private readonly Regex Regex;
        private const string expression = @"^\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$";
        public EmailAddressValidator() : base(() => "请输入正确邮箱地址")
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
