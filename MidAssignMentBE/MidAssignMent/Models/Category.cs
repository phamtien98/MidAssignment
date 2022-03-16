using System;
using System.Collections.Generic;

namespace MidAssignMentBE.Models
{
    public partial class Category
    {
        public Category()
        {
            Books = new HashSet<Book>();
        }

        public int CategoryId { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;

        public virtual ICollection<Book> Books { get; set; }
    }
}
