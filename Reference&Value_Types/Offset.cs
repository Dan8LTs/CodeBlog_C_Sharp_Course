using System.Runtime.InteropServices;

namespace Reference_Value_Types
{
    [StructLayout(LayoutKind.Explicit)]
    internal struct Offset
    {
        [FieldOffset(0)]
        public int x;
        [FieldOffset(0)]
        public int y;
    }
}
