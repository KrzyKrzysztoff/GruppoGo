using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GruppoGo.Features.Users.Queries.GetUsers
{
    public class GetUsersValidator : AbstractValidator<GetUsersRequest>
    {
        public GetUsersValidator()
        {
            RuleFor(x => x.Size)
                .GreaterThan(0)
                .WithMessage("Size should be greater than 0.");

            RuleFor(x => x.Page)
                .GreaterThan(0)
                .WithMessage("Page should be greater than 0.");

        }
    }
}
