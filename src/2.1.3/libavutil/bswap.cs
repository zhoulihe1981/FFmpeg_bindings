//----------------------------------------------------------------------------
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
//----------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;
using System.Security;

namespace libavutil
{
    public unsafe partial class libavutil
    {
        [SuppressUnmanagedCodeSecurity]
        [DllImport("avutil-if-52.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="av_bswap16")]
        internal static extern ushort av_bswap16(ushort x);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("avutil-if-52.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="av_bswap32")]
        internal static extern uint av_bswap32(uint x);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("avutil-if-52.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="av_bswap64")]
        internal static extern ulong av_bswap64(ulong x);
    }
}
