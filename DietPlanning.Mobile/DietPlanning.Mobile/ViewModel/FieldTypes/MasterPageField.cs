using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DietPlanning.Mobile.ViewModel.FieldTypes
{
    public class MasterPageField
    {

        



        public string Title { get; set; }

        public string IconSource { get; set; }

        public Type TargetType { get; set; }

        public Int32 Id { get; set; }

        public ContentPage Instance { get; set; }
    }
}
