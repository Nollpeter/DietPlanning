namespace DietPlanning.Portable.DTO
{
    public class EnergyDTO : NutrientDTO
    {
        public double? Kj { get; set; }
        public double? Calories { get; set; }
    }
}