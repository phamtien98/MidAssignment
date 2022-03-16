using System;
using System.Collections.Generic;

namespace MidAssignMentBE.Models
{
    public partial class BookBorrowingRequest
    {
        public int Id { get; set; }
        public int RequestedByUserId { get; set; }
        public int ProcessByUserId { get; set; }
        public bool Status { get; set; }

        public virtual Admin ProcessByUser { get; set; } = null!;
        public virtual User RequestedByUser { get; set; } = null!;
    }
}
