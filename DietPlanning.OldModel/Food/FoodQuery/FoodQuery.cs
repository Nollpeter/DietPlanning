using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DietPlanning.Model.Annotations;

namespace DietPlanning.Model.Food.FoodQuery
{
    public interface INotifyCollectionChanged
    {
        event EventHandler CollectionChanged;
    }
    public class FoodQuery : ICollection<QueryItem>, INotifyCollectionChanged
    {
        private List<QueryItem> _filters;

        public event EventHandler CollectionChanged;

        public List<Food> ItemsSource { get; set; }
        public IEnumerable<string> Result { get; private set; }

        public List<QueryItem> Filters
        {
            get { return _filters; }
            set { _filters = value; UpdateResult();}
        }

        public bool MatchAll { get; set; }

        

        public FoodQuery()
        {
            ItemsSource = new List<Food>();
            //Result = new List<string>();
            Filters = new List<QueryItem>();
            CollectionChanged += (sender, args) => { UpdateResult(); };
            MatchAll = true;
        }

        public void UpdateResult()
        {
            Result = from food in ItemsSource
                where MatchAll ? Filters.All(query=>query.Match(food)) : Filters.Any(query=>query.Match(food))
                select food.Name;
        }

        /*public void Add(object obj)
        {
            QueryItem query = obj as QueryItem;
            if (query != null)
            {
                Filters.Add(query);
                UpdateResult();
            }
        }*/

        public IEnumerator<QueryItem> GetEnumerator() => ((IEnumerable<QueryItem>) Filters).GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable<QueryItem>) Filters).GetEnumerator();

        public void Add(QueryItem item)
        {
            ((ICollection<QueryItem>) Filters).Add(item);
            CollectionChanged?.Invoke(this,new EventArgs());
            
        }

        public void Clear()
        {
            ((ICollection<QueryItem>) Filters).Clear();
            CollectionChanged?.Invoke(this,new EventArgs());
        }

        public bool Contains(QueryItem item) => ((ICollection<QueryItem>) Filters).Contains(item);

        public void CopyTo(QueryItem[] array, int arrayIndex)
            => ((ICollection<QueryItem>) Filters).CopyTo(array, arrayIndex);

        public bool Remove(QueryItem item)
        {
            bool b = ((ICollection<QueryItem>) Filters).Remove(item);
            CollectionChanged?.Invoke(this,new EventArgs());
            return b;
        }

        public int Count => ((ICollection<QueryItem>) Filters).Count;

        public bool IsReadOnly => ((ICollection<QueryItem>) Filters).IsReadOnly;
    }
}
