using FF6EE.Utils;
using System;

namespace FF6EE.Enums
{
    public static class EnumHelper
    {
        public static T FromString<T>(string value) where T : struct
        {
            if (Enum.TryParse<T>(value, true, out T result))
            {
                return (T)result;
            }
            throw new ProgramException($"Invalid value '{value}' for enum '{typeof(T).Name}'");
        }
    }
}
