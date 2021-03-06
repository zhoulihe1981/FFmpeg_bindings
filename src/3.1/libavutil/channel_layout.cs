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
        public const sbyte AV_CH_FRONT_LEFT = 0x1;

        public const sbyte AV_CH_FRONT_RIGHT = 0x2;

        public const sbyte AV_CH_FRONT_CENTER = 0x4;

        public const sbyte AV_CH_LOW_FREQUENCY = 0x8;

        public const sbyte AV_CH_BACK_LEFT = 0x10;

        public const sbyte AV_CH_BACK_RIGHT = 0x20;

        public const sbyte AV_CH_FRONT_LEFT_OF_CENTER = 0x40;

        public const byte AV_CH_FRONT_RIGHT_OF_CENTER = 0x80;

        public const short AV_CH_BACK_CENTER = 0x100;

        public const short AV_CH_SIDE_LEFT = 0x200;

        public const short AV_CH_SIDE_RIGHT = 0x400;

        public const short AV_CH_TOP_CENTER = 0x800;

        public const short AV_CH_TOP_FRONT_LEFT = 0x1000;

        public const short AV_CH_TOP_FRONT_CENTER = 0x2000;

        public const short AV_CH_TOP_FRONT_RIGHT = 0x4000;

        public const ushort AV_CH_TOP_BACK_LEFT = 0x8000;

        public const int AV_CH_TOP_BACK_CENTER = 0x10000;

        public const int AV_CH_TOP_BACK_RIGHT = 0x20000;

        public const int AV_CH_STEREO_LEFT = 0x20000000;

        public const int AV_CH_STEREO_RIGHT = 0x40000000;

        public enum AVMatrixEncoding
        {
            AV_MATRIX_ENCODING_NONE = 0,
            AV_MATRIX_ENCODING_DOLBY = 1,
            AV_MATRIX_ENCODING_DPLII = 2,
            AV_MATRIX_ENCODING_DPLIIX = 3,
            AV_MATRIX_ENCODING_DPLIIZ = 4,
            AV_MATRIX_ENCODING_DOLBYEX = 5,
            AV_MATRIX_ENCODING_DOLBYHEADPHONE = 6,
            AV_MATRIX_ENCODING_NB = 7
        }

        /// <summary>
        /// Return a channel layout id that matches name, or 0 if no match is
        /// found.
        /// 
        /// name can be one or several of the following notations,
        /// separated by '+' or '|':
        /// - the name of an usual channel layout (mono, stereo, 4.0, quad, 5.0,
        /// 5.0(side), 5.1, 5.1(side), 7.1, 7.1(wide), downmix);
        /// - the name of a single channel (FL, FR, FC, LFE, BL, BR, FLC, FRC, BC,
        /// SL, SR, TC, TFL, TFC, TFR, TBL, TBC, TBR, DL, DR);
        /// - a number of channels, in decimal, optionally followed by 'c',
        /// yielding
        /// the default channel layout for that number of channels (@see
        /// av_get_default_channel_layout);
        /// - a channel layout mask, in hexadecimal starting with "0x" (see the
        /// AV_CH_* macros).
        /// 
        /// @warning Starting from the next major bump the trailing character
        /// 'c' to specify a number of channels will be required, while a
        /// channel layout mask could also be specified as a decimal number
        /// (if and only if not followed by "c").
        /// 
        /// Example: "stereo+FC" = "2c+FC" = "2c+1c" = "0x7"
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_get_channel_layout")]
        public static extern ulong av_get_channel_layout(string name);

        /// <summary>
        /// Return a description of a channel layout.
        /// If nb_channels is &lt;= 0, it is guessed from the channel_layout.
        /// </summary>
        /// <param name="buf">
        /// put here the string containing the channel layout
        /// </param>
        /// <param name="buf_size">
        /// size in bytes of the buffer
        /// </param>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_get_channel_layout_string")]
        public static extern void av_get_channel_layout_string(System.Text.StringBuilder buf, int buf_size, int nb_channels, ulong channel_layout);

        /// <summary>
        /// Append a description of a channel layout to a bprint buffer.
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_bprint_channel_layout")]
        public static extern void av_bprint_channel_layout(libavutil.AVBPrint* bp, int nb_channels, ulong channel_layout);

        /// <summary>
        /// Return the number of channels in the channel layout.
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_get_channel_layout_nb_channels")]
        public static extern int av_get_channel_layout_nb_channels(ulong channel_layout);

        /// <summary>
        /// Return default channel layout for a given number of channels.
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_get_default_channel_layout")]
        public static extern long av_get_default_channel_layout(int nb_channels);

        /// <summary>
        /// Get the index of a channel in channel_layout.
        /// </summary>
        /// <param name="channel">
        /// a channel layout describing exactly one channel which must be
        /// present in channel_layout.
        /// </param>
        /// <returns>
        /// index of channel in channel_layout on success, a negative AVERROR
        /// on error.
        /// </returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_get_channel_layout_channel_index")]
        public static extern int av_get_channel_layout_channel_index(ulong channel_layout, ulong channel);

        /// <summary>
        /// Get the channel with the given index in channel_layout.
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_channel_layout_extract_channel")]
        public static extern ulong av_channel_layout_extract_channel(ulong channel_layout, int index);

        /// <summary>
        /// Get the name of a given channel.
        /// </summary>
        /// <returns>
        /// channel name on success, NULL on error.
        /// </returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_get_channel_name")]
        public static extern sbyte* av_get_channel_name(ulong channel);

        /// <summary>
        /// Get the description of a given channel.
        /// </summary>
        /// <param name="channel">
        /// a channel layout with a single channel
        /// </param>
        /// <returns>
        /// channel description on success, NULL on error
        /// </returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_get_channel_description")]
        public static extern sbyte* av_get_channel_description(ulong channel);

        /// <summary>
        /// Get the value and name of a standard channel layout.
        /// </summary>
        /// <param name="[in]">
        /// index   index in an internal list, starting at 0
        /// </param>
        /// <param name="[out]">
        /// layout  channel layout mask
        /// </param>
        /// <param name="[out]">
        /// name    name of the layout
        /// </param>
        /// <returns>
        /// 0  if the layout exists,
        /// &lt;0 if index is beyond the limits
        /// </returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_get_standard_channel_layout")]
        public static extern int av_get_standard_channel_layout(uint index, ulong* layout, sbyte** name);

        /// <summary>
        /// Get the value and name of a standard channel layout.
        /// </summary>
        /// <param name="[in]">
        /// index   index in an internal list, starting at 0
        /// </param>
        /// <param name="[out]">
        /// layout  channel layout mask
        /// </param>
        /// <param name="[out]">
        /// name    name of the layout
        /// </param>
        /// <returns>
        /// 0  if the layout exists,
        /// &lt;0 if index is beyond the limits
        /// </returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_get_standard_channel_layout")]
        public static extern int av_get_standard_channel_layout(uint index, ulong* layout, ref string name);
    }
}
