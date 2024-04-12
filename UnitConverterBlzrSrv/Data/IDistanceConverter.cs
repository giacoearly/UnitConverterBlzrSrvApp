namespace UnitConverterBlzrSrv.Data
{
    public interface IDistanceConverter
    {
        double MilesToKilometers(double miles);
        double KilometersToMiles(double kilometers);
    }
}
