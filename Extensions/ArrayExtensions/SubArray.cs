using System;

namespace Extensions.ArrayExtensions
{

    public static class ArrayExtensions
    {

        public static T[] SubArray<T>(this T[] array, int index, int length)
        {
            var subArray = new T[length];
            Array.Copy(array, index, subArray, 0, length);
            return subArray;
        }

    }

}