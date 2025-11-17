using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GruppoGo.Common.Reponses
{
    public class ApiResponse<T>(IEnumerable<T>? Items,
        string Status = "Success",
        string Message = "Success message")
    {
        public string Status { get; set; } = Status;
        public string Message { get; set; } = Message;
        public int ItemsCount { get; set; } = Items != null ? Items.Count() : 0;
        public IEnumerable<T>? Items { get; set; } = Items;
    }
}
