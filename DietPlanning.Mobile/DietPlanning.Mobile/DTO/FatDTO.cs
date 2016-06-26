namespace DietPlanning.Mobile.DTO
{
    public class FatDTO : NutrientDTO
    {
        public double? BaseFat { get; set; }
        public double? BaseSaturatedFat { get; set; }
        public double? BaseMonounsaturatedFat { get; set; }
        public double? BasePolyunsaturatedFat { get; set; }
        public double? BaseTransFattyAcids { get; set; }
        public double? BaseTransMonoenoicFatyAcids { get; set; }
        public double? BaseTransPolyenoicFatyAcids { get; set; }
        public double? BaseOmega3FattyAcids { get; set; }
        public double? BaseOmega6FattyAcids { get; set; }
    }
}