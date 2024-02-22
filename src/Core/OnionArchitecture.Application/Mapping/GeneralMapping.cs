using AutoMapper;
using OnionArchitecture.Application.Dto;
using OnionArchitecture.Application.Features.Commands.CreateProduct;
using OnionArchitecture.Application.Features.Queries.GetProductById;
using OnionArchitecture.Domain.Entities;

namespace OnionArchitecture.Application.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<Product, ProductViewDto>().ReverseMap();
            CreateMap<Product, CreateProductCommand>().ReverseMap();
            CreateMap<Product, GetProductByIdViewModel>().ReverseMap();
        }
    }
}
