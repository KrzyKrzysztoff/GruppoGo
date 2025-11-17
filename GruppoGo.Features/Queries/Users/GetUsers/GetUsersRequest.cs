using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GruppoGo.Features.Queries.Users.GetUsers
{
    public class GetUsersRequest(int Size, int Page)
    {
        public int Size { get; set; } = Size;
        public int Page { get; set; } = Page;
    }
}
