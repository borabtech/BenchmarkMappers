using Mapster;

namespace BenchmarkMappers.Mappers.Mapster;

public static class MapsterMapper
{
    public static VehicleViewModel Map(Vehicle data)
    {
        return TypeAdapter.Adapt<VehicleViewModel>(data);
    }
}