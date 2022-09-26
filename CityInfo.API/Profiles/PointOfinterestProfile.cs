using AutoMapper;
using CityInfo.API.Models;

namespace CityInfo.API.Profiles
{
    public class PointOfinterestProfile : Profile
    {
        public PointOfinterestProfile()
        {
            CreateMap<Entities.PointOfInterest, Models.PointOfInterestDto>();
            CreateMap<Models.PointOfInterestForCreationDto, Entities.PointOfInterest>();
        }
    }
}
