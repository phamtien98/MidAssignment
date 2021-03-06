using System;
using System.Collections.Generic;

namespace MidAssignMentBE.Models
{
    public partial class User
    {
        public User()
        {
            BookBorrowingRequests = new HashSet<BookBorrowingRequest>();
        }

        public int UserId { get; set; }
        public string FullName { get; set; } = null!;
        public string UserName { get; set; } = null!;
        public string Password { get; set; } = null!;

        public virtual ICollection<BookBorrowingRequest> BookBorrowingRequests { get; set; }
    }
}
