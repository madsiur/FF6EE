using System;
using System.Globalization;

namespace FF6EE.Utils
{
    public static class ParsingUtils
    {
        public static int ParseOffset(string offset)
        {
            int result = ParseInt(offset);
            return result > 0xC00000 ? result - 0xC00000 : result;
        }

        public static int ParseInt(string value)
        {
            int result = 0;
            try
            {
                if (value.StartsWith("0x"))
                {
                    value = value.Substring(2);
                    result = int.Parse(value, NumberStyles.HexNumber);
                }
                else
                {
                    result = int.Parse(value);
                }

                return result;
            }
            catch (FormatException e)
            {
                throw new ProgramException($"Error parsing value {value}", e);
            }
        }

        public static uint ParseUInt(string value)
        {
            uint result = 0;
            try
            {
                if (value.StartsWith("0x"))
                {
                    value = value.Substring(2);
                    result = uint.Parse(value, NumberStyles.HexNumber);
                }
                else
                {
                    result = uint.Parse(value);
                }

                return result;
            }
            catch (FormatException e)
            {
                throw new ProgramException($"Error parsing value {value}", e);
            }
        }

        public static bool TryParseUint(string value, out uint result)
        {
            if (value.StartsWith("0x"))
            {
                value = value.Substring(2);
                return uint.TryParse(value, NumberStyles.HexNumber, CultureInfo.InvariantCulture, out result);
            }
            else
            {
                return uint.TryParse(value, out result);
            }
        }

        public static ushort ParseUshort(string value, NumberStyles numberStyle)
        {
            try
            {
                ushort result = ushort.Parse(value, numberStyle);
                return result;
            }
            catch (FormatException e)
            {
                throw new ProgramException($"Error parsing ushort {value} with NumberStyle {numberStyle}", e);
            }
        }
    }
}
