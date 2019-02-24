using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Converter
{
    public class Converters
    {
        public static string BinaryStringToHexString(string binary)
        {
            binary = binary.Replace(" ", String.Empty);
            if (Regex.IsMatch(binary, "[^01]"))
            {
                throw new FormatException("Non-Binary Character");
            }
            try
            {
                StringBuilder result = new StringBuilder(binary.Length / 8 + 1);

                int mod4Len = binary.Length % 8;
                if (mod4Len != 0)
                    binary = binary.PadLeft(((binary.Length / 8) + 1) * 8, '0');

                for (int i = 0; i < binary.Length; i += 8)
                {
                    string eightBits = binary.Substring(i, 8);
                    result.AppendFormat("{0:X2}", Convert.ToByte(eightBits, 2));
                }

                return result.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private static readonly Dictionary<char, string> hexCharacterToBinary = new Dictionary<char, string> {
            { '0', "0000" }, { '1', "0001" }, { '2', "0010" }, { '3', "0011" }, { '4', "0100" },
            { '5', "0101" }, { '6', "0110" }, { '7', "0111" }, { '8', "1000" }, { '9', "1001" },
            { 'a', "1010" }, { 'b', "1011" }, { 'c', "1100" }, { 'd', "1101" }, { 'e', "1110" },
            { 'f', "1111" }
        };

        public static string HexStringToBinaryString(string hexString)
        {
            hexString = hexString.Replace("0x", String.Empty);
            hexString = hexString.Replace(",", String.Empty);
            hexString = hexString.Replace(" ", String.Empty);

            if (Regex.IsMatch(hexString, "[^A-Fa-f0-9]"))
            {
                throw new FormatException("Non-Hex Character");
            }
            StringBuilder result = new StringBuilder();
            foreach (char c in hexString)
            {
                // This will crash for non-hex characters. You might want to handle that differently.
                result.Append(hexCharacterToBinary[char.ToLower(c)]);
            }
            return result.ToString();
        }

        public static string HexStringToArrayStyle(string hexString)
        {
            if (Regex.IsMatch(hexString, "[^A-Fa-f0-9]"))
            {
                throw new FormatException("Non-Hex Character");
            }

            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < hexString.Length; i += 2)
            {
                stringBuilder.Append("0x" + hexString[i] + hexString[i + 1]);
                if (i != hexString.Length - 2)
                    stringBuilder.Append(",");
            }
            return stringBuilder.ToString();
        }
    }
}