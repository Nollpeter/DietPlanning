using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DietPlanning.Model.Food.FoodQuery
{
    public class QueryItem
    {
        public string TargetProperty { get; set; }
        public string Operator { get; set; }
        public double ComparisonValue { get; set; }
        public delegate bool QueryItemDelegate (Food param1, double param2);

        private QueryItemDelegate Matcher;
        public QueryItem(string targetProperty, string Operator, double comparisonValue)
        {
            this.TargetProperty = targetProperty;
            this.Operator = Operator;
            this.ComparisonValue = comparisonValue;
            switch (Operator)
            {
                case ">=":
                    Matcher += (param1, param2) => param1[targetProperty].Value >= param2;
                    break;
                case "<=":
                    Matcher += (param1, param2) => param1[targetProperty].Value <= param2;
                    break;
                case "<":
                    Matcher += (param1, param2) => param1[targetProperty].Value < param2;
                    break;
                case ">":
                    Matcher += (param1, param2) => param1[targetProperty].Value > param2;
                    break;
                default:
                    Matcher += (param1, param2) => param1[targetProperty].Value == param2;
                    break;

            }
        }
        internal bool Match(Food food)
        {
            return Matcher(food, ComparisonValue);
        }
    }
}
