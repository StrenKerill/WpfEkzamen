using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Data
{
    public class Taskkk
    {
        public int TaskId { get; set; }
        public string Title { get; set; }
        public bool Done { get; set; }
        public DateTime Due { get; set; }
        public int TaskListId { get; set; }
    }
}
