using AutoMapper;
using HrPtoManagement.Web.Data;
using HrPtoManagement.Web.Models;

namespace HrPtoManagement.Web.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<PtoType, PtoTypeViewModel>().ReverseMap();
        }
    }
}
