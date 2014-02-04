//----------------------------------------------------------------------------
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
//----------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;
using System.Security;

namespace libavutil
{
    public enum AVMatrixEncoding
    {
        AV_MATRIX_ENCODING_NONE = 0,
        AV_MATRIX_ENCODING_DOLBY = 1,
        AV_MATRIX_ENCODING_DPLII = 2,
        AV_MATRIX_ENCODING_NB = 3
    }

    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct AVBPrint
    {
    }

    public unsafe partial class libavutil
    {
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
        [DllImport("avutil-if-52.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="av_get_channel_layout")]
        internal static extern ulong av_get_channel_layout(global::System.IntPtr name);

        /// <summary>
        /// Return a description of a channel layout.
        /// If nb_channels is <= 0, it is guessed from the channel_layout.
        /// 
        /// @param buf put here the string containing the channel layout
        /// @param buf_size size in bytes of the buffer
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport("avutil-if-52.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="av_get_channel_layout_string")]
        internal static extern void av_get_channel_layout_string(sbyte* buf, int buf_size, int nb_channels, ulong channel_layout);

        /// <summary>
        /// Append a description of a channel layout to a bprint buffer.
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport("avutil-if-52.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="av_bprint_channel_layout")]
        internal static extern void av_bprint_channel_layout(AVBPrint* bp, int nb_channels, ulong channel_layout);

        /// <summary>
        /// Return the number of channels in the channel layout.
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport("avutil-if-52.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="av_get_channel_layout_nb_channels")]
        internal static extern int av_get_channel_layout_nb_channels(ulong channel_layout);

        /// <summary>
        /// Return default channel layout for a given number of channels.
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport("avutil-if-52.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="av_get_default_channel_layout")]
        internal static extern long av_get_default_channel_layout(int nb_channels);

        /// <summary>
        /// Get the index of a channel in channel_layout.
        /// 
        /// @param channel a channel layout describing exactly one channel which
        /// must be
        /// present in channel_layout.
        /// 
        /// @return index of channel in channel_layout on success, a negative
        /// AVERROR
        /// on error.
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport("avutil-if-52.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="av_get_channel_layout_channel_index")]
        internal static extern int av_get_channel_layout_channel_index(ulong channel_layout, ulong channel);

        /// <summary>
        /// Get the channel with the given index in channel_layout.
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport("avutil-if-52.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="av_channel_layout_extract_channel")]
        internal static extern ulong av_channel_layout_extract_channel(ulong channel_layout, int index);

        /// <summary>
        /// Get the name of a given channel.
        /// 
        /// @return channel name on success, NULL on error.
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport("avutil-if-52.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="av_get_channel_name")]
        internal static extern global::System.IntPtr av_get_channel_name(ulong channel);

        /// <summary>
        /// Get the description of a given channel.
        /// 
        /// @param channel  a channel layout with a single channel
        /// @return  channel description on success, NULL on error
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport("avutil-if-52.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="av_get_channel_description")]
        internal static extern global::System.IntPtr av_get_channel_description(ulong channel);

        /// <summary>
        /// Get the value and name of a standard channel layout.
        /// 
        /// @param[in]  index   index in an internal list, starting at 0
        /// @param[out] layout  channel layout mask
        /// @param[out] name    name of the layout
        /// @return  0  if the layout exists,
        /// <0 if index is beyond the limits
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport("avutil-if-52.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="av_get_standard_channel_layout")]
        internal static extern int av_get_standard_channel_layout(uint index, ulong* layout, global::System.IntPtr name);
    }
}
