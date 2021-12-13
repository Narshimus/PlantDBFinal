using System;
namespace Final_Project
{
    public class Plant
    {
        public string Id { get; set;}
        public string Genus { get; set;}
        public string Species { get; set;}
        public string ScientificName { get; set;}
        public string CommonName { get; set;}
        public string Family { get; set;}
        public string Order { get; set;}
        public string Class { get; set;}
        public string Duration { get; set;}
        public string GrowthHabit { get; set;}
        public string Invasive { get; set;}
        public string GrowthRate { get; set;}
        public string MatureHight { get; set;}
        public string Toxicity { get; set;}
        public string DroughtTolerance { get; set;}
        public string ShadeTolerance { get; set;}
        public string TemperatureMin { get; set;}

        public Plant(string id, string genus, string species, string scientific_name,
            string common_name, string family, string order, string @class, string duration,
            string growth_habit, string invasive, string growth_rate, string mature_hight,
            string toxicity, string drought_tolerance, string shade_tolerance, string temperature_min)
        {
            Id = id;
            Genus = genus;
            Species = species;
            ScientificName = scientific_name;
            CommonName = common_name;
            Family = family;
            Order = order;
            Class = @class;
            Duration = duration;
            GrowthHabit = growth_habit;
            Invasive = invasive;
            GrowthRate = growth_rate;
            MatureHight = mature_hight;
            Toxicity = toxicity;
            DroughtTolerance = drought_tolerance;
            ShadeTolerance = shade_tolerance;
            TemperatureMin = temperature_min;
        }

        public void Print()
        {
            Console.WriteLine($"Plant Id: {Id}, Common Name: {CommonName}, Scientific Name: { ScientificName}");
        }

        public void PrintVerbose()
        {
            Console.WriteLine($"Common Name: {CommonName}, Scientific Name: { ScientificName}\n" +
                $"Class: {Class}, Order: {Order}, Family: {Family},  Genus: {Genus}, Species: {Species} \n" +
                $"Duration: {Duration}, Growth Habit: {GrowthHabit}, Growth Rate {GrowthRate}, Mature Hight {MatureHight}\n" +
                $"Drought Tolerance: {DroughtTolerance}, Shade Tolerance{ShadeTolerance}, Min Temperature {TemperatureMin}\n" +
                $"Invasive: {Invasive.Length != 0}, Toxicity: {(Toxicity.Length != 0 ? Toxicity : "None" )}\n");
        }
    }
}
