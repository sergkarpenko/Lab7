using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab7_1
{
    public class Animal
    {
        [Key]
        public int AnimalId { get; set; }
        public string Name { get; set; }
        public int LimbCount { get; set; }

        public  List<AnimalEat> AnimalEats { get; set; }
        public  Biomes AnimalBiomes { get; set; }


        public  AnimalClass AnimalClass { get; set; }
    }

    

    public class Eat
    {
        [Key]
        public int EatId { get; set; }

        public string EatName { get; set; }

        public int Calories { get; set; }

        public List<Animal> Animals { get; set; }
    }


    public class AnimalEat
    {
        [Key]
        public int AnimalEatId { get; set; }
        public int AnimalId { get; set; }

        public Animal Animal { get; set; }
        
        public int EatId { get; set; }

        public Eat Eat { get; set; }
    }

    public class AnimalClass
    {
        [Key]
        public int ClassId { get; set; }

        public string ClassName { get; set; }

        public List<Animal> Animals { get; set; }
    }


    public class Biomes
    {
        [Key]
        public int BiomesId { get; set; }

        public string AnimalBiomes { get; set; }

        public List<AnimalClass> Animals { get; set; }
    }
}
