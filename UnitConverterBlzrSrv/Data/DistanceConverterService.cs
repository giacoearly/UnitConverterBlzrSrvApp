namespace UnitConverterBlzrSrv.Data;

public class DistanceConverterService : IDistanceConverter
{
    public double KilometersToMiles(double kilometers)
    {
        return kilometers / 1.6093;
    }

    public double MilesToKilometers(double miles)
    {
        return miles * 1.6093;
    }
}
