using AutoMapper;
using DomainModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Mappings
{
    public class Mappings : Profile
    {
        public Mappings()
        {
            CreateMap<Post, PostDTO>();
        }
    }
}
