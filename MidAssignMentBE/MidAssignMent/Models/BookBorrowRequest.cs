using System;
using System.Collections.Generic;

namespace MidAssignMentBE.Models
{
    public partial class BookBorrowRequest
    {
        public int RequestId { get; set; }
        public int? BorrowId { get; set; }
        public bool? BorrowStatus { get; set; }
        public int? UserId { get; set; }
    }
}
