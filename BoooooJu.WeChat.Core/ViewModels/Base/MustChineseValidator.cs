using FluentValidation.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BoooooJu.Web.Core.ViewModels.Base
{
    class MustChineseValidator : PropertyValidator, IRegularExpressionValidator
    {
        private readonly Regex Regex;
        private const string expression = @"^[\u4e00-\u9fa5]{0,}$";
        public MustChineseValidator() : base(() => "请输入中文")
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
