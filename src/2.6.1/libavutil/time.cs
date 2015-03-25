//----------------------------------------------------------------------------
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
//----------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;
using System.Security;

namespace FFmpeg
{
    public unsafe static partial class libavutil
    {
        /// <summary>
        /// Get the current time in microseconds.
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_gettime")]
        public static extern long av_gettime();

        /// <summary>
        /// Get the current time in microseconds since some unspecified starting
        /// point.
        /// On platforms that support it, the time comes from a monotonic clock
        /// This property makes this time source ideal for measuring relative time.
        /// The returned values may not be monotonic on platforms where a monotonic
        /// clock is not available.
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_gettime_relative")]
        public static extern long av_gettime_relative();

        /// <summary>
        /// Indicates with a boolean result if the av_gettime_relative() time
        /// source
        /// is monotonic.
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_gettime_relative_is_monotonic")]
        public static extern int av_gettime_relative_is_monotonic();

        /// <summary>
        /// Sleep for a period of time.  Although the duration is expressed in
        /// microseconds, the actual delay may be rounded to the precision of the
        /// system timer.
        /// </summary>
        /// <param name="usec">
        /// Number of microseconds to sleep.
        /// </param>
        /// <returns>
        /// zero on success or (negative) error code.
        /// </returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_usleep")]
        public static extern int av_usleep(uint usec);
    }
}