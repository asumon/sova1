using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DomainModels
{
    
    public class Post
    {
        public int Id { get; set; }
        
        public Posttype posttype { get; set; }
        public int posttypeId { get; set; }

        
        public int ParentId { get; set; }
        
        public int acceptedanswerid { get; set; }






    }
}
