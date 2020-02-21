using System.Diagnostics.CodeAnalysis;

namespace System
{
    [ExcludeFromCodeCoverage()]
    internal static class UInt32Ext
    {
        [Obsolete("Use System.Linq.Enumerable.Range(int, int) to achieve the same. This method is no longer subject to testing.", true)]
        public static void For(this uint uint32, Action<uint> action)
        {
            if (null == action || uint32 < 1) { return; }

            for (uint i = 0; i < uint32; i++)
            {
                action(i);
            }
        }
    }
}