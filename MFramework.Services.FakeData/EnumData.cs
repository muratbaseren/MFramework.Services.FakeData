
using System;

namespace MFramework.Services.FakeData
{
    public static class EnumData
    {
        public static T GetElement<T>()
        {
            Array values = Enum.GetValues(typeof(T));
            T value = (T)values.GetValue(NumberData.GetNumber(values.Length));
            return value;
        }
    }
}