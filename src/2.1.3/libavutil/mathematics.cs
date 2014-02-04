//----------------------------------------------------------------------------
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
//----------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;
using System.Security;

namespace libavutil
{
    /// <summary>
    /// @addtogroup lavu_math
    /// @{
    /// </summary>
    public enum AVRounding
    {
        /// <summary>Round toward zero.</summary>
        AV_ROUND_ZERO = 0,
        /// <summary>Round away from zero.</summary>
        AV_ROUND_INF = 1,
        /// <summary>Round toward -infinity.</summary>
        AV_ROUND_DOWN = 2,
        /// <summary>Round toward +infinity.</summary>
        AV_ROUND_UP = 3,
        /// <summary>Round to nearest and halfway cases away from zero.</summary>
        AV_ROUND_NEAR_INF = 5,
        /// <summary>Flag to pass INT64_MIN/MAX through instead of rescaling, this avoids special cases for AV_NOPTS_VALUE</summary>
        AV_ROUND_PASS_MINMAX = 8192
    }

    public unsafe partial class libavutil
    {
        /// <summary>
        /// Return the greatest common divisor of a and b.
        /// If both a and b are 0 or either or both are <0 then behavior is
        /// undefined.
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport("avutil-if-52.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="av_gcd")]
        internal static extern long av_gcd(long a, long b);

        /// <summary>
        /// Rescale a 64-bit integer with rounding to nearest.
        /// A simple a*b/c isn't possible as it can overflow.
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport("avutil-if-52.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="av_rescale")]
        internal static extern long av_rescale(long a, long b, long c);

        /// <summary>
        /// Rescale a 64-bit integer with specified rounding.
        /// A simple a*b/c isn't possible as it can overflow.
        /// 
        /// @return rescaled value a, or if AV_ROUND_PASS_MINMAX is set and a is
        /// INT64_MIN or INT64_MAX then a is passed through unchanged.
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport("avutil-if-52.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="av_rescale_rnd")]
        internal static extern long av_rescale_rnd(long a, long b, long c, AVRounding _0);

        /// <summary>
        /// Rescale a 64-bit integer by 2 rational numbers.
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport("avutil-if-52.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="av_rescale_q")]
        internal static extern long av_rescale_q(long a, AVRational* bq, AVRational* cq);

        /// <summary>
        /// Rescale a 64-bit integer by 2 rational numbers with specified rounding.
        /// 
        /// @return rescaled value a, or if AV_ROUND_PASS_MINMAX is set and a is
        /// INT64_MIN or INT64_MAX then a is passed through unchanged.
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport("avutil-if-52.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="av_rescale_q_rnd")]
        internal static extern long av_rescale_q_rnd(long a, AVRational* bq, AVRational* cq, AVRounding _0);

        /// <summary>
        /// Compare 2 timestamps each in its own timebases.
        /// The result of the function is undefined if one of the timestamps
        /// is outside the int64_t range when represented in the others timebase.
        /// @return -1 if ts_a is before ts_b, 1 if ts_a is after ts_b or 0 if they
        /// represent the same position
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport("avutil-if-52.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="av_compare_ts")]
        internal static extern int av_compare_ts(long ts_a, AVRational* tb_a, long ts_b, AVRational* tb_b);

        /// <summary>
        /// Compare 2 integers modulo mod.
        /// That is we compare integers a and b for which only the least
        /// significant log2(mod) bits are known.
        /// 
        /// @param mod must be a power of 2
        /// @return a negative value if a is smaller than b
        /// a positive value if a is greater than b
        /// 0                if a equals          b
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport("avutil-if-52.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="av_compare_mod")]
        internal static extern long av_compare_mod(ulong a, ulong b, ulong mod);

        /// <summary>
        /// Rescale a timestamp while preserving known durations.
        /// 
        /// @param in_ts Input timestamp
        /// @param in_tb Input timesbase
        /// @param fs_tb Duration and *last timebase
        /// @param duration duration till the next call
        /// @param out_tb Output timesbase
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport("avutil-if-52.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="av_rescale_delta")]
        internal static extern long av_rescale_delta(AVRational* in_tb, long in_ts, AVRational* fs_tb, int duration, long* last, AVRational* out_tb);
    }
}
