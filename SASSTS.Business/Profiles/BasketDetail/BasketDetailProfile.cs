using AutoMapper;

namespace SASSTS.Business.Profiles.BasketDetail
{
    public class BasketDetailProfile : Profile
    {
        public BasketDetailProfile()
        {
            CreateMap<SASSTS.Model.Entities.BasketDetail, SASSTS.Model.Dtos.BasketDetail.BasketDetailGetDto>()
                .ForMember(dest => dest.ProductName, opt => opt.MapFrom(src => src.Product.ProductName))
                .ForMember(dest => dest.CreatedTime, opt => opt.MapFrom(src => src.Basket.CreatedTime));
        }
    }
}
