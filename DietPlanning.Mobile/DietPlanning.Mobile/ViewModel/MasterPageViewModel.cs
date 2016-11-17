using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DietPlanning.Mobile.View;
using DietPlanning.Mobile.ViewModel.FieldTypes;

namespace DietPlanning.Mobile.ViewModel
{
    public class MasterPageViewModel: ViewModelBase
    {
        private ObservableCollection<MasterPageField> _fields;
        private MasterPageField _selectedPage;

        public ObservableCollection<MasterPageField> Fields
        {
            get { return _fields; }
            set
            {
                if (Equals(value, _fields)) return;
                _fields = value;
                OnPropertyChanged();
            }
        }

        public MasterPageField SelectedPage
        {
            get { return _selectedPage; }
            set
            {
                if (Equals(value, _selectedPage)) return;
                _selectedPage = value;
                OnPropertyChanged();
                OnSelectedMasterPageFieldChanged(new MasterPageFieldChangedEventArgs() {Field = SelectedPage});
            }
        }

        public event EventHandler<MasterPageFieldChangedEventArgs> SelectedMasterPageFieldChanged; 

        public MasterPageViewModel()
        {
            Fields = new ObservableCollection<MasterPageField>();
            Fields.Add(new MasterPageField
            {
                Title = "Contacts",
                IconSource = "contacts.png",
                TargetType = typeof(ContactsPage),
                Instance = new ContactsPage()

            });
            Fields.Add(new MasterPageField
            {
                Title = "Search",
                IconSource = "todo.png",
                TargetType = typeof(SearchPage)
                ,Instance = new SearchPage()
            });
           
        }

        protected virtual void OnSelectedMasterPageFieldChanged(MasterPageFieldChangedEventArgs e)
        {
            SelectedMasterPageFieldChanged?.Invoke(this, e);
        }
    }

    public class MasterPageFieldChangedEventArgs : EventArgs
    {
        public MasterPageField Field { get; set; }
    }
}
