using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcDemo.Helper
{
    public class Class2 : Profile
    {
        public Class2()
        {
            CreateMap<Models.Class1, Models.Class2>();
        }
    }
}