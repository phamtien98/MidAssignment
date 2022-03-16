using System;
using System.Collections.Generic;

namespace MidAssignMentBE.Models
{
    public partial class Admin
    {
        public Admin()
        {
            BookBorrowingRequests = new HashSet<BookBorrowingRequest>();
        }

        public int AdminId { get; set; }
        public string FullName { get; set; } = null!;
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;

        public virtual ICollection<BookBorrowingRequest> BookBorrowingRequests { get; set; }
    }
}
