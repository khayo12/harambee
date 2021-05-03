using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Harambee.Models
{
    public class Bundle
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<int> ProductIds { get; set; }
    }
}