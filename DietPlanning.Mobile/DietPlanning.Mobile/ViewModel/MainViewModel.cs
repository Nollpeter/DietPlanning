using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DietPlanning.Mobile.Model;
using DietPlanning.Mobile.Persistence;
using DietPlanning.Portable.DTO;
using Xamarin.Forms;

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

        public Command GetFoodCommand
        {
            get { return _getFoodCommand; }
            set
            {
                if (Equals(value, _getFoodCommand)) return;
                _getFoodCommand = value;
                OnPropertyChanged();
            }
        }

        public String NameToQueryString
        {
            get { return _nameToQueryString; }
            set
            {
                if (value == _nameToQueryString) return;
                _nameToQueryString = value;
                OnPropertyChanged();
            }
        }

        private FoodPersistence foodPersistence;
        private Command _getFoodCommand;

        public FoodDTO CurrentFood
        {
            get { return _currentFood; }
            set
            {
                if (Equals(value, _currentFood)) return;
                _currentFood = value;
                OnPropertyChanged();
            }
        }

        private string _nameToQueryString;
        private FoodDTO _currentFood;
        protected FoodFetchModel FoodFetchModel { get; set; }
        public MainViewModel()
        {
            FoodFetchModel = new FoodFetchModel();
            foodPersistence = new FoodPersistence();
            //ProteinDTO dto = foodPersistence.GetTestDTO();
            //Texti = dto.ProteinContent.ToString();
            GetFoodCommand = new Command(async p =>
            {
                CurrentFood = await FoodFetchModel.FetchFoodByNameAsync(NameToQueryString);
            });
        }
        
    }
}
