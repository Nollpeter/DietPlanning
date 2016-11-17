using DietPlanning.Mobile.View;
using DietPlanning.Mobile.ViewModel.FieldTypes;

namespace DietPlanning.Mobile.ViewModel
{
    public class MasterDetailViewModel : ViewModelBase
    {
        public MasterPageViewModel MasterPageViewModel { get; set; }
        public MasterPageField SelectedPage { get; set; }

        public MasterDetailViewModel()
        {
            SelectedPage = new MasterPageField() {Instance = new SearchPage()};
            MasterPageViewModel = new MasterPageViewModel();
            MasterPageViewModel.SelectedMasterPageFieldChanged += (sender, args) =>
            {
                this.SelectedPage = MasterPageViewModel.SelectedPage;
            };
        }
    }
}