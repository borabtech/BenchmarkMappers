using AutoMapper;

namespace BenchmarkMappers.Mappers.AutoMapper;

public static class AutoMapper
{
    public static VehicleViewModel Map(Vehicle data)
    {
        var mapperConfiguration = new MapperConfiguration(config =>
        {
            config.CreateMap<Vehicle, VehicleViewModel>();
        });

        var mapper = mapperConfiguration.CreateMapper();
        return mapper.Map<VehicleViewModel>(data);
    }
}