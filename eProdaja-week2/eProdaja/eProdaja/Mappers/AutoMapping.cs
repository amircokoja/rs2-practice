using AutoMapper;
using eProdaja.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja
{
        public class AutoMapping : Profile
        {
            public AutoMapping()
            {
                CreateMap<Korisnici, Model.Request.Korisnici>(); // means you want to map from User to UserDTO
            }
        }
}
