namespace DietPlanning.Portable.DTO
{
    public class FoodDTO:IDTO
    {
        public virtual CarbDTO Carbohydrate { get; set; }
        public virtual EnergyDTO Energy { get; set; }
        public virtual FatDTO Fat { get; set; }
        public virtual MineralsDTO Minerals { get; set; }
        public virtual OtherDTO Other { get; set; }
        public virtual ProteinDTO Protein { get; set; }
        public virtual VitaminDTO Vitamine { get; set; }
    }
}
