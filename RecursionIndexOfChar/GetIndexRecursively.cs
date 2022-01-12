using System;

namespace RecursionIndexOfChar
{
    public static class GetIndexRecursively
    {
        public static int GetIndexOfChar(string str, char value)
        {
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            if (string.IsNullOrEmpty(str) || !str.Contains(value, StringComparison.OrdinalIgnoreCase))
            {
                return -1;
            }

            if (str[0] == value)
            {
                return 0;
            }

            return GetIndexOfChar(str[1..], value) + 1;
        }

        public static int GetIndexOfChar(string str, char value, int startIndex, int count)
        {
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str));
            }

            if (string.IsNullOrEmpty(str) || count == 0)
            {
                return -1;
            }

            if (startIndex < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex), "startIndex is less than zero");
            }

            if (startIndex >= str.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex), "startIndex is greater or equals str.Length");
            }

            if (count < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(count), "count is less than zero");
            }

            if (startIndex + count > str.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(count), "startIndex + count > str.Length + 1");
            }

            if (count == 0)
            {
                return -1;
            }

            if (str[startIndex] == value)
            {
                return startIndex;
            }

            return GetIndexOfChar(str, value, startIndex + 1, count - 1);
        }
    }
}
