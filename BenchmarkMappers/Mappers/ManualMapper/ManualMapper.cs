namespace BenchmarkMappers.Mappers.ManualMapper;

public class ManualMapper
{
    public static VehicleViewModel Map(Vehicle data)
    {
        return new VehicleViewModel
        {
            Id = data.Id,
            BrandName = data.BrandName,
            Price = data.Price,
            Quantity = data.Quantity,
            VehicleType = data.VehicleType
        };
    }
}