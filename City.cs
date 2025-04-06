public class City
{
    public int Population { get; set; }
    public double Area { get; set; }

    public City(int population, double area)
    {
        Population = population;
        Area = area;
    }

    public override string ToString()
    {
        return $"Population: {Population}, Area: {Area}";
    }
}

