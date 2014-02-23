using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Core.DTOs;
using NinjectSimpleSample.Models;

namespace NinjectSimpleSample.App_Start
{
    public class AutoMapperConfig
    {
        public static void RegisterMaps()
        {
            Mapper.CreateMap<PersonDTO, PersonModel>();
        }
    }
}