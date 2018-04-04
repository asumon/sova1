using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class CommentDTO
    {
        public int Id { get; set; }
        public int Commentscore { get; set; }
        public string CommentText { get; set; }
        public DateTime CommentDate { get; set; }


        public int PostId { get; set; }
        public PostDTO Posts { get; set; }

        
    }
}
