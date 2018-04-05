using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class PostTagDTO
    {
        public int post_id { get; set; }
        public ICollection<PostDTO> Post { get; set; }

        public int tag_id { get; set; }
        public ICollection<TagDTO> Tag { get; set; }
    }
}
