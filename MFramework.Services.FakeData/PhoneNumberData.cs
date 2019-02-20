namespace MFramework.Services.FakeData
{
    public static class PhoneNumberData
    {
        public static string GetInternationalPhoneNumber()
        {
            return TextData.GetPatternString("00##-###-###-####");
        }

        public static string GetPhoneNumber()
        {
            return TextData.GetPatternString("01###-######");
        }

        public static string GetUsPhoneNumber()
        {
            return TextData.GetPatternString("###-###-####");
        }
    }
}