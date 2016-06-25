namespace DietPlanning.Model.Food.Nutrients
{
    public class Energy : Nutrient
    {
        public Property Kj { get; set; }
        public Property Calories { get; set; }

        public Energy()
        {
            /*this.OriginalName = "Energy";
            this.Unit = Calories.Unit;
            this.Value = Calories.Value;*/
            BaseProperty = Calories;
            InitBaseProperty();
        }
    }
}
