using Riok.Mapperly.Abstractions;

namespace BenchmarkMappers.Mappers.Mapperly;

[Mapper(EnumMappingStrategy = EnumMappingStrategy.ByName)]
public static partial class MapperlyMapper
{
    public static partial VehicleViewModel Map(Vehicle data);
}