using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace DataAccess
{
    public class UserDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? CreationDate { get; set; }
        public string Location { get; set; }
        public int? Age { get; set; }

        public virtual ICollection<PostDTO> Posts { get; set; }

        public UserDTO()
        {
            Posts = new Collection<PostDTO>();
        }



    }
}
