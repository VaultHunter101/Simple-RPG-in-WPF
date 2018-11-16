using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public static class RandomNumberGenerator
    {
        private static Random _generator = new Random();

        public static int NumberBetween(int minimumValue, int maximumValue)
        {
            return _generator.Next(minimumValue, maximumValue + 1);
        }
        //In this version, we use an instance of an encryption class RNGCryptoServiceProvider. This
        //class is better at not following a pattern when it creates random numbers. But we need to
        //do some more math to get a value between the passed in parameters.

    }
}
