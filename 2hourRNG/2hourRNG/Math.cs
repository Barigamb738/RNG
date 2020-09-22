using System;
using System.Collections.Generic;
using System.Text;

namespace Math
{
    static class Random
    {
        static int numsGenerated = 0;
        public static int Int(int min = 0, int max = 10, int seed = 103248)
        {
            seed += numsGenerated;
            numsGenerated++;
            int RandomNumber = (((int)MathF.Round(MathF.Sin(seed) * seed) % ((max - min + 2) / 2)) + ((max - min) / 2 + min));
            return RandomNumber;
        }

        public static float Float(float min, float max, float seed = 103248f)
        {
            seed += numsGenerated;
            numsGenerated++;
            float RandomNumber = (((MathF.Sin(seed) * seed) % ((max - min + 2) / 2)) + ((max - min) / 2 + min));
            return RandomNumber;
        }
    }
}
