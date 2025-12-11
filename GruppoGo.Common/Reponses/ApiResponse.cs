using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GruppoGo.Common.Reponses
{
    public class ApiResponse<T>
    {
        public ApiResponse()
        {

        }

        public ApiResponse(ICollection<T>? Items,
            string Status = "Success",
            string Message = "Success message")
        {
            this.Status = Status;
            ItemsCount = Items != null ? Items.Count() : 0;
            this.Items = Items;
            this.Message = Message;
        }

        public string Status { get; set; }
        public string Message { get; set; }
        public int ItemsCount { get; set; }
        public ICollection<T>? Items { get; set; }
    }
}
