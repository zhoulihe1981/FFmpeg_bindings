//----------------------------------------------------------------------------
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
//----------------------------------------------------------------------------
// ReSharper disable RedundantUsingDirective
// ReSharper disable CheckNamespace
#pragma warning disable 1584,1711,1572,1581,1580,1573
using System;
using System.Runtime.InteropServices;
using System.Security;

namespace FFmpeg
{
    [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("ReSharper", "UnusedMember.Global")]
    [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("ReSharper", "InconsistentNaming")]
    [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("ReSharper", "RedundantUnsafeContext")]
    [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("ReSharper", "MemberCanBePrivate.Global")]
    [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("ReSharper", "MemberCanBePrivate.Global")]
    [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("ReSharper", "FieldCanBeMadeReadOnly.Global")]
    [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("ReSharper", "PartialTypeWithSinglePart")]
    [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("ReSharper", "RedundantNameQualifier")]
    [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("ReSharper", "ArrangeModifiersOrder")]
    public unsafe static partial class libavutil
    {
        [StructLayout(LayoutKind.Sequential)]
        public unsafe partial struct AVCAST5
        {
        }

        /// <summary>
        /// Allocate an AVCAST5 context
        /// To free the struct: av_free(ptr)
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_cast5_alloc")]
        public static extern libavutil.AVCAST5* av_cast5_alloc();

        /// <summary>
        /// Initialize an AVCAST5 context.
        /// </summary>
        /// <param name="ctx">
        /// an AVCAST5 context
        /// </param>
        /// <param name="key">
        /// a key of 5,6,...16 bytes used for encryption/decryption
        /// </param>
        /// <param name="key_bits">
        /// number of keybits: possible are 40,48,...,128
        /// </param>
        /// <returns>
        /// 0 on success, less than 0 on failure
        /// </returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_cast5_init")]
        public static extern int av_cast5_init(libavutil.AVCAST5* ctx, byte* key, int key_bits);

        /// <summary>
        /// Encrypt or decrypt a buffer using a previously initialized context, ECB
        /// mode only
        /// </summary>
        /// <param name="ctx">
        /// an AVCAST5 context
        /// </param>
        /// <param name="dst">
        /// destination array, can be equal to src
        /// </param>
        /// <param name="src">
        /// source array, can be equal to dst
        /// </param>
        /// <param name="count">
        /// number of 8 byte blocks
        /// </param>
        /// <param name="decrypt">
        /// 0 for encryption, 1 for decryption
        /// </param>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_cast5_crypt")]
        public static extern void av_cast5_crypt(libavutil.AVCAST5* ctx, byte* dst, byte* src, int count, int decrypt);

        /// <summary>
        /// Encrypt or decrypt a buffer using a previously initialized context
        /// </summary>
        /// <param name="ctx">
        /// an AVCAST5 context
        /// </param>
        /// <param name="dst">
        /// destination array, can be equal to src
        /// </param>
        /// <param name="src">
        /// source array, can be equal to dst
        /// </param>
        /// <param name="count">
        /// number of 8 byte blocks
        /// </param>
        /// <param name="iv">
        /// initialization vector for CBC mode, NULL for ECB mode
        /// </param>
        /// <param name="decrypt">
        /// 0 for encryption, 1 for decryption
        /// </param>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_cast5_crypt2")]
        public static extern void av_cast5_crypt2(libavutil.AVCAST5* ctx, byte* dst, byte* src, int count, byte* iv, int decrypt);
    }
}
