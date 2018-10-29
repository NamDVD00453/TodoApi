using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApi.Entity
{
    public class Todo
    {
        public int Id { get; set; }
        public String Title { get; set; }
        public int Status { get; set; }
    }
}
