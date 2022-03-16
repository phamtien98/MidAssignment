using System;
using System.Collections.Generic;

namespace MidAssignMentBE.Models
{
    public partial class Book
    {
        public int BookId { get; set; }
        public string Name { get; set; } = null!;
        public string Author { get; set; } = null!;
        public string Summary { get; set; } = null!;
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; } = null!;
    }
}
