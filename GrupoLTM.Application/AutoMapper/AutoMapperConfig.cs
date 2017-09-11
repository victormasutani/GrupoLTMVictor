using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoLTM.Application.AutoMapper
{
    public class AutoMapperConfig
    {
        public static void InitializeAutoMapper()
        {
            Mapper.Initialize(x =>
                x.AddProfile<DomainToDTOProfile>()
                );
            
        }
    }
}
