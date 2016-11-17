namespace DietPlanning.Portable.DTO
{
    public class CarbDTO : NutrientDTO
    {
        public double? BaseCarboHydrate { get; set; }
        public double? BaseDietaryFiber { get; set; }
        public double? BaseStarch { get; set; }
        public double? BaseSugars { get; set; }
        public double? Sucrose { get; set; }
        public double? Glucose { get; set; }
        public double? Fructose { get; set; }
        public double? Lactose { get; set; }
        public double? Maltose { get; set; }
        public double? Galactose { get; set; }
    }
}
