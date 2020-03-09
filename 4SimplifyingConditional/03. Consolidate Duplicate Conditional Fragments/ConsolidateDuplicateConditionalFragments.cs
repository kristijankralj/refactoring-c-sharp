using System.Collections.Generic;
using System.Linq;

namespace SimplifyingConditional
{
    #region Other classes
    public class Food
    {
        public string Name { get; set; }
    }

    public class Eating
    {
        public Dictionary<Food, double> Foods { get; }

        public void Add(Food food, double weight)
        {
            var product = Foods.Keys.FirstOrDefault(f => f.Name.Equals(food.Name));
            if (product == null)
            {
                Foods.Add(food, weight);
            }
            else
            {
                Foods[product] += weight;
            }
        }

    }

    public class DatabaseManager
    {
        public static void SaveFoods(IEnumerable<Food> foods)
        {
            //Perform save to database
        }

        public static void SaveEating(Eating eating)
        {
            //Perform save to database
        }
    }
    #endregion

    public class EatingController
    {
        public List<Food> Foods { get; }
        public Eating Eating { get; }

        public void Add(Food food, double weight)
        {
            var product = Foods.SingleOrDefault(p => p.Name == food.Name);
            if (product == null)
            {
                Foods.Add(food);
                Eating.Add(food, weight);
                Save();
            }
            else
            {
                Eating.Add(product, weight);
                Save();
            }
        }

        private void Save()
        {
            DatabaseManager.SaveFoods(Foods);
            DatabaseManager.SaveEating(Eating);
        }
    }
}
