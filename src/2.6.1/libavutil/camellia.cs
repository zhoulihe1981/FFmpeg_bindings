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
        [StructLayout(LayoutKind.Sequential)]
        public unsafe partial struct AVCAMELLIA
        {
        }

        /// <summary>
        /// Allocate an AVCAMELLIA context
        /// To free the struct: av_free(ptr)
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_camellia_alloc")]
        public static extern libavutil.AVCAMELLIA* av_camellia_alloc();

        /// <summary>
        /// Initialize an AVCAMELLIA context.
        /// </summary>
        /// <param name="ctx">
        /// an AVCAMELLIA context
        /// </param>
        /// <param name="key">
        /// a key of 16, 24, 32 bytes used for encryption/decryption
        /// </param>
        /// <param name="key_bits">
        /// number of keybits: possible are 128, 192, 256
        /// </param>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_camellia_init")]
        public static extern int av_camellia_init(libavutil.AVCAMELLIA* ctx, byte* key, int key_bits);

        /// <summary>
        /// Encrypt or decrypt a buffer using a previously initialized context
        /// </summary>
        /// <param name="ctx">
        /// an AVCAMELLIA context
        /// </param>
        /// <param name="dst">
        /// destination array, can be equal to src
        /// </param>
        /// <param name="src">
        /// source array, can be equal to dst
        /// </param>
        /// <param name="count">
        /// number of 16 byte blocks
        /// @paran iv initialization vector for CBC mode, NULL for ECB mode
        /// </param>
        /// <param name="decrypt">
        /// 0 for encryption, 1 for decryption
        /// </param>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_camellia_crypt")]
        public static extern void av_camellia_crypt(libavutil.AVCAMELLIA* ctx, byte* dst, byte* src, int count, byte* iv, int decrypt);
    }
}
