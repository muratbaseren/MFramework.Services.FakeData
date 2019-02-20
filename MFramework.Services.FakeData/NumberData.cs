
using System;

namespace MFramework.Services.FakeData
{
    public static class NumberData
    {
        private readonly static Random _random;

        static NumberData()
        {
            NumberData._random = new Random();
        }

        public static byte[] GetBytes(byte[] buffer)
        {
            NumberData._random.NextBytes(buffer);
            return buffer;
        }

        public static double GetDouble()
        {
            return NumberData._random.NextDouble();
        }

        public static int GetNumber()
        {
            return NumberData._random.Next();
        }

        public static int GetNumber(int max)
        {
            return NumberData._random.Next(max);
        }

        public static int GetNumber(int min, int max)
        {
            return NumberData._random.Next(min, max);
        }
    }
}