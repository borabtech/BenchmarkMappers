using BenchmarkDotNet.Attributes;
using BenchmarkMappers.Mappers.Mapperly;

namespace BenchmarkMappers.Mappers;

public class BenchmarkManager
{
    Vehicle vehicle;
    [GlobalSetup]
    public void Initialize()
    {
        vehicle = new Vehicle()
        {
            Id = 1,
            BrandName = "Mazda",
            Price = 27000,
            Quantity = 20,
            VehicleType = "SUV"
        };
    }

    [Benchmark]
    public void TestManualMapper()
    {
        var model = ManualMapper.ManualMapper.Map(vehicle);
    }
    
    [Benchmark]
    public void TestMapsterMapper()
    {
        var model = Mapster.MapsterMapper.Map(vehicle);
    }
    
    [Benchmark]
    public void TestMapperlyMapper()
    {
        var model = MapperlyMapper.Map(vehicle);
    }
    
    [Benchmark]
    public void TestAutomapper()
    {
        var model = AutoMapper.AutoMapper.Map(vehicle);
    }
}