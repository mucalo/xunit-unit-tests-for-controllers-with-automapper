using API.Models;

namespace API.AutoMapperConfig
{
    public static class MapperConfig
    {
        public static void Initialize()
        {
            AutoMapper.Mapper.Initialize(config =>
            {
                config.CreateMap<Item, ItemViewModel>();
                config.CreateMap<ItemViewModel, Item>();
            });
        }
    }
}
