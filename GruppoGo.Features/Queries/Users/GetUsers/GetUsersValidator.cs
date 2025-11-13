using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GruppoGo.Features.Queries.Users.GetUsers
{
    internal class GetUsersValidator : AbstractValidator<GetUsersRequest>
    {
        public GetUsersValidator()
        {
            RuleFor(x => x.Size)
                .GreaterThan(3)
                .WithMessage("xxxxx");

            RuleFor(x => x.Page)
                .GreaterThan(2)
                .WithMessage("eeeeee");
    
        }
    }
}
