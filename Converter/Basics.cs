namespace Converter
{
    internal class Basics
    {
        public static readonly string HEX_TO_BIN = "Hexadecimal to Binary";
        public static readonly string BIN_TO_HEX = "Binary to Hexadecimal";
        public static readonly string BIN_TO_HEX_ARR = "Binary to Hexadecimal C Array";
        public static readonly string HEX_TO_HEX_ARR = "Hexadecimal to Hexadecimal C Array";
        public static readonly string OUTPUT_FILE = "Output to file";
        public static readonly string OUTPUT_WINDOW = "Show in new window";

        static public string[] outputOperations = new string[] { OUTPUT_FILE, OUTPUT_WINDOW };

        static public string[] fileOperations = new string[] { BIN_TO_HEX, HEX_TO_BIN, BIN_TO_HEX_ARR, HEX_TO_HEX_ARR };
    }
}