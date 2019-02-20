using System.Collections.Generic;
using System.Linq;

namespace MFramework.Services.FakeData
{
    public static class CollectionData
    {
        public static T GetElement<T>(ICollection<T> collection)
        {
            int index = NumberData.GetNumber(0, collection.Count);
            return collection.ElementAt<T>(index);
        }

        public static ICollection<T> GetElement<T>(int count, ICollection<T> collection)
        {
            IList<T> returnCollection = new List<T>();
            while (count > 0)
            {
                returnCollection.Add(CollectionData.GetElement<T>(collection));
                count--;
            }
            return returnCollection;
        }
    }
}