namespace Lab7_1;

public class Animal
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int LimbCount { get; set; }

    public Biome Biome { get; set; } = null!;
    public Klass Klass { get; set; } = null!;

    public List<Eat> Eats { get; set; } = [];
}


public class Eat
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int Calories { get; set; }

    public List<Animal> Animals { get; set; } = [];
}

public class Klass
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;

    public List<Animal> Animals { get; set; } = [];
}


public class Biome
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public List<Klass> Klasses { get; set; } = [];
}
