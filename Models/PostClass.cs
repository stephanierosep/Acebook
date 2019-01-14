using System;
namespace Acebook.Models
{
    public class Post
    {
        public long Id { get; set;  }
        public int UserId { get; set; }
        public string Content { get; set; }
        //public DateTime DateCreated { get; set; }
    }
}
