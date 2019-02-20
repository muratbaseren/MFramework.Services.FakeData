namespace MFramework.Services.FakeData
{
    public static class BooleanData
    {
        public static bool GetBoolean()
        {
            return NumberData.GetNumber(2) == 1;
        }
    }
}