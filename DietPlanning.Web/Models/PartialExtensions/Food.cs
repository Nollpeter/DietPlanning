using System;
using DietPlanning.Mobile.DTO;
using DietPlanning.Web.Models.InterFaces;

namespace DietPlanning.Web.Models
{
    public partial class Food 
    {
        public FoodDTO ToDTO()
        {
           
            FoodDTO dto = new FoodDTO
            {
                Protein = this.Protein.ToDTO<ProteinDTO>(),
                Carbohydrate = Carbohydrate.ToDTO<CarbDTO>(),
                Energy = Energy.ToDTO<EnergyDTO>(),
                Fat = Fat.ToDTO<FatDTO>(),
                Minerals = Minerals.ToDTO<MineralsDTO>(),
                Other = Other.ToDTO<OtherDTO>(),
                Vitamine = Vitamine.ToDTO<VitaminDTO>()
            };
            return dto;

        }
    }
}