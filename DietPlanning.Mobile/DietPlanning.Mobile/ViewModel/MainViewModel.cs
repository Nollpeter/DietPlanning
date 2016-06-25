using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DietPlanning.Mobile.DTO;
using DietPlanning.Mobile.Persistence;

namespace DietPlanning.Mobile.ViewModel
{
    class MainViewModel:ViewModelBase
    {
        private string _texti;

        public String Texti
        {
            get { return _texti; }
            set
            {
                if (value == _texti) return;
                _texti = value;
                OnPropertyChanged();
            }
        }

        private FoodPersistence foodPersistence;
        public MainViewModel()
        {
            foodPersistence = new FoodPersistence();
            ProteinDTO dto = foodPersistence.GetTestDTO();
            Texti = dto.ProteinContent.ToString();
        }
    }
}
