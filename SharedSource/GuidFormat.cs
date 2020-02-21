using System.Diagnostics.CodeAnalysis;

namespace System
{
    [ExcludeFromCodeCoverage()]
    internal static class GuidFormat
    {
        /// <summary>
        /// 32 digits:
        /// 00000000000000000000000000000000
        /// </summary>
        public static readonly string N = "N";
        /// <summary>
        /// 32 digits
        /// separated by hyphens:
        /// 00000000-0000-0000-0000-000000000000
        /// </summary>
        public static readonly string D = "D";
        /// <summary>
        /// 32 digits
        /// separated by hyphens,
        /// enclosed in braces:
        /// {00000000-0000-0000-0000-000000000000}
        /// </summary>
        public static readonly string B = "B";
        /// <summary>
        /// 32 digits
        /// separated by hyphens,
        /// enclosed in parentheses:
        /// (00000000-0000-0000-0000-000000000000)
        /// </summary>
        public static readonly string P = "P";
        /// <summary>
        /// Four hexadecimal values
        /// enclosed in braces, 
        /// where the fourth value is a subset of eight hexadecimal values that is also enclosed in braces:
        /// {0x00000000,0x0000,0x0000,{0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00}}
        /// </summary>
        public static readonly string X = "X";
    }
}