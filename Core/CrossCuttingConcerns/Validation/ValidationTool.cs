using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;
using FluentValidation;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace Core.CrossCuttingConcerns.Validation
{
    public static class ValidationTool
    {
        public static void Validate(IValidator validator,object entityorDto)
        {
            var context = new ValidationContext<object>(entityorDto);
            var result = validator.Validate(context);
            if (!result.IsValid)
            {
            throw new ValidationException(result.Errors);
            }

    
        }




    }
           
           
}

