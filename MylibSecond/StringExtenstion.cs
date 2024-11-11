using System;
namespace MylibSecond
{
    public static class StringExtenstion
    {
        public static int WordCount(this string str)
        {
            return str.split(new char[] { ' ', '.', '?' }, StringSplitOption.RemoveEmptyEntrires).length;

        }
    }
}