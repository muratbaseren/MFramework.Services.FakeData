namespace MFramework.Services.FakeData
{
    public static class ArrayData
    {
        public static T GetElement<T>(params T[] array)
        {
            int index = NumberData.GetNumber(0, (int)array.Length);
            return (T)array.GetValue(index);
        }

        public static T[] GetElement<T>(int count, params T[] array)
        {
            T[] returnArray = new T[count];
            while (count > 0)
            {
                returnArray[count - 1] = ArrayData.GetElement<T>(array);
                count--;
            }
            return returnArray;
        }
    }
}