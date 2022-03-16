using System;
using System.Collections.Generic;

namespace MidAssignMentBE.Models
{
    public partial class BookBorrowRequestDetail
    {
        public int BorrowId { get; set; }
        public int UserId { get; set; }
        public int BookId { get; set; }
        public DateTime? TakenDate { get; set; }
        public DateTime? ReturnDate { get; set; }
    }
}
