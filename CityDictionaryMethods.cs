public class CityDictionaryMethods
{
    private Dictionary<string, City> cities;

    public CityDictionaryMethods()
    {
        cities = new Dictionary<string, City>();
    }

    public void AddCity(string name, City city)
    {
        cities.Add(name, city);
    }

    public void SortByArea()
    {
        List<string> keys = new List<string>(cities.Keys);

        for (int i = 0; i < keys.Count - 1; i++)
        {
            for (int j = i + 1; j < keys.Count; j++)
            {
                if (cities[keys[i]].Area > cities[keys[j]].Area)
                {
                    var temp = keys[i];
                    keys[i] = keys[j];
                    keys[j] = temp;
                }
            }
        }

        Console.WriteLine("Cities on Area asc):");
        foreach (var key in keys)
        {
            Console.WriteLine(key + " - " + cities[key]);
        }
    }

    public void BrowseByPopulationDescending()
    {
        List<string> keys = new List<string>(cities.Keys);

        for (int i = 0; i < keys.Count - 1; i++)
        {
            for (int j = i + 1; j < keys.Count; j++)
            {
                if (cities[keys[i]].Population < cities[keys[j]].Population)
                {
                    var temp = keys[i];
                    keys[i] = keys[j];
                    keys[j] = temp;
                }
            }
        }

        Console.WriteLine("Cities on population desc:");
        foreach (var key in keys)
        {
            Console.WriteLine(key + " - " + cities[key]);
        }
    }

    public void CountTotalPopulation()
    {
        var total = 0;
        foreach (var city in cities)
        {
            total += city.Value.Population;
        }

        Console.WriteLine("Totul count of population: " + total);
    }
}
