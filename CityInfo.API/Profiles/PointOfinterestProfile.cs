using AutoMapper;

namespace CityInfo.API.Profiles
{
    public class PointOfinterestProfile : Profile
    {
        public PointOfinterestProfile()
        {
            CreateMap<Entities.PointOfInterest, Models.PointOfInterestDto>();
        }
    }
}
