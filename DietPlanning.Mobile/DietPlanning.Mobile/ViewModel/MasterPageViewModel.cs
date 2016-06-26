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

        public MasterPageViewModel()
        {
            Fields = new ObservableCollection<MasterPageField>();
            Fields.Add(new MasterPageField
            {
                Title = "Contacts",
                IconSource = "contacts.png",
                TargetType = typeof(ContactsPage)
            });
            Fields.Add(new MasterPageField
            {
                Title = "Search",
                IconSource = "todo.png",
                TargetType = typeof(SearchPage)
            });
           
        }
    }
}
