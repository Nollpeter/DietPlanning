using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Resources;
using System.Text;

namespace DietPlanning.Model.Localization
{
    public enum Currencies
    {
        HUF,GBP,USD,EUR,CHF
    }
    public static class LocalizationManager
    {
        public static void LoadDefaultResource()
        {
            ResourceManager res = new ResourceManager("DietPlanning.Model.Localization.Hungarian",
                typeof (LocalizationManager).Assembly);
        }

        public static Currencies SelectedCurrency { get; set; }
    }
}
