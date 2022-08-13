using AutoMapper;
using FemTechVolunteerWebApplication.Data;
using FemTechVolunteerWebApplication.Models;

///
/// The purpose of this class is because I have a data model (VolunteersModel) but I want to send back my view model (VolunteersModel)
///

namespace FemTechVolunteerWebApplication.Configurations
{
    public class MapperConfig : Profile 
    {
        public MapperConfig()
        {
            CreateMap<Volunteer, VolunteersModel>().ReverseMap();
        }
    }
}
