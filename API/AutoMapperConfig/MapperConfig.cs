using API.Models;

namespace API.AutoMapperConfig
{
    public static class MapperConfig
    {
        public static void Initialize()
        {
            AutoMapper.Mapper.Initialize(config =>
            {
                config.CreateMap<Item, ItemDTO>();
                config.CreateMap<ItemDTO, Item>();
            });
        }
    }
}
