using System;
using System.Collections.Generic;

namespace Fininex.Models
{
    public partial class Entry
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Amount { get; set; }
        public string Currency { get; set; }
        public string Description { get; set; }
    }
}
