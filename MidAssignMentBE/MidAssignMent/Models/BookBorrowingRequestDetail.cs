using System;
using System.Collections.Generic;

namespace MidAssignMentBE.Models
{
    public partial class BookBorrowingRequestDetail
    {
        public int BookBorrowingRequestId { get; set; }
        public int BookId { get; set; }

        public virtual Book Book { get; set; } = null!;
        public virtual BookBorrowingRequest BookBorrowingRequest { get; set; } = null!;
    }
}
