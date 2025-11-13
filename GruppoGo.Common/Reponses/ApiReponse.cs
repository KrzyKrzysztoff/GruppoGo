using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GruppoGo.Common.Reponses
{
    public class ApiReponse<T>(IEnumerable<T> Items,
        string Status = "Success",
        string Message = "Success message")
    {
        public string Status { get; set; } = Status;
        public string Message { get; set; } = Message;
        public IEnumerable<T> Items { get; set; } = Items;
    }
}
