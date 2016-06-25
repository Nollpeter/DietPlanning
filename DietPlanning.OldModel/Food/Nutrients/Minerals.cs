namespace DietPlanning.Model.Food.Nutrients
{
    public class Minerals : Nutrient
    {
        public Property Calcium { get; set; }
        public Property Iron { get; set; }
        public Property Magnesium { get; set; }
        public Property Phosphorus { get; set; }
        public Property Potassium { get; set; }
        public Property Sodium { get; set; }
        public Property Zinc { get; set; }
        public Property Copper { get; set; }
        public Property Manganese { get; set; }
        public Property Selenium { get; set; }
        public Property Fluoride { get; set; }

        public Minerals()
        {
            this.OriginalName = "Minerals";
           // this.Value = null;
            this.Unit = string.Empty;
        

        }
    }
}
