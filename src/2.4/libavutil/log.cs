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
        public const sbyte AV_LOG_QUIET = -8;

        public const sbyte AV_LOG_PANIC = 0;

        public const sbyte AV_LOG_FATAL = 8;

        public const sbyte AV_LOG_ERROR = 16;

        public const sbyte AV_LOG_WARNING = 24;

        public const sbyte AV_LOG_INFO = 32;

        public const sbyte AV_LOG_VERBOSE = 40;

        public const sbyte AV_LOG_DEBUG = 48;

        public const sbyte AV_LOG_SKIP_REPEATED = 1;

        public const sbyte AV_LOG_PRINT_LEVEL = 2;

        public enum AVClassCategory
        {
            AV_CLASS_CATEGORY_NA = 0,
            AV_CLASS_CATEGORY_INPUT = 1,
            AV_CLASS_CATEGORY_OUTPUT = 2,
            AV_CLASS_CATEGORY_MUXER = 3,
            AV_CLASS_CATEGORY_DEMUXER = 4,
            AV_CLASS_CATEGORY_ENCODER = 5,
            AV_CLASS_CATEGORY_DECODER = 6,
            AV_CLASS_CATEGORY_FILTER = 7,
            AV_CLASS_CATEGORY_BITSTREAM_FILTER = 8,
            AV_CLASS_CATEGORY_SWSCALER = 9,
            AV_CLASS_CATEGORY_SWRESAMPLER = 10,
            AV_CLASS_CATEGORY_DEVICE_VIDEO_OUTPUT = 40,
            AV_CLASS_CATEGORY_DEVICE_VIDEO_INPUT = 41,
            AV_CLASS_CATEGORY_DEVICE_AUDIO_OUTPUT = 42,
            AV_CLASS_CATEGORY_DEVICE_AUDIO_INPUT = 43,
            AV_CLASS_CATEGORY_DEVICE_OUTPUT = 44,
            AV_CLASS_CATEGORY_DEVICE_INPUT = 45,
            /// <summary>not part of ABI/API</summary>
            AV_CLASS_CATEGORY_NB = 46
        }

        /// <summary>
        /// Describe the class of an AVClass context structure. That is an
        /// arbitrary struct of which the first field is a pointer to an
        /// AVClass struct (e.g. AVCodecContext, AVFormatContext etc.).
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public unsafe partial struct AVClass
        {
            /// <summary>
            /// The name of the class; usually it is the same name as the
            /// context structure type to which the AVClass is associated.
            /// </summary>
            public sbyte* class_name;

            /// <summary>
            /// A pointer to a function which returns the name of a context
            /// instance ctx associated with the class.
            /// </summary>
            public global::System.IntPtr item_name;

            /// <summary>
            /// a pointer to the first option specified in the class if any or NULL
            /// 
            /// @see av_set_default_options()
            /// </summary>
            public libavutil.AVOption* option;

            /// <summary>
            /// LIBAVUTIL_VERSION with which this structure was created.
            /// This is used to allow fields to be added without requiring major
            /// version bumps everywhere.
            /// </summary>
            public int version;

            /// <summary>
            /// Offset in the structure where log_level_offset is stored.
            /// 0 means there is no such variable
            /// </summary>
            public int log_level_offset_offset;

            /// <summary>
            /// Offset in the structure where a pointer to the parent context for
            /// logging is stored. For example a decoder could pass its AVCodecContext
            /// to eval as such a parent context, which an av_log() implementation
            /// could then leverage to display the parent context.
            /// The offset can be NULL.
            /// </summary>
            public int parent_log_context_offset;

            /// <summary>
            /// Return next AVOptions-enabled child or NULL
            /// </summary>
            public global::System.IntPtr child_next;

            /// <summary>
            /// Return an AVClass corresponding to the next potential
            /// AVOptions-enabled child.
            /// 
            /// The difference between child_next and this is that
            /// child_next iterates over _already existing_ objects, while
            /// child_class_next iterates over _all possible_ children.
            /// </summary>
            public global::System.IntPtr child_class_next;

            /// <summary>
            /// Category used for visualization (like color)
            /// This is only set if the category is equal for all objects using this
            /// class.
            /// available since version (51 << 16 | 56 << 8 | 100)
            /// </summary>
            public libavutil.AVClassCategory category;

            /// <summary>
            /// Callback to return the category.
            /// available since version (51 << 16 | 59 << 8 | 100)
            /// </summary>
            public global::System.IntPtr get_category;

            /// <summary>
            /// Callback to return the supported/allowed ranges.
            /// available since version (52.12)
            /// </summary>
            public global::System.IntPtr query_ranges;
        }

        /// <summary>
        /// Send the specified message to the log if the level is less than or
        /// equal
        /// to the current av_log_level. By default, all logging messages are sent
        /// to
        /// stderr. This behavior can be altered by setting a different logging
        /// callback
        /// function.
        /// @see av_log_set_callback
        /// </summary>
        /// <param name="avcl">
        /// A pointer to an arbitrary struct of which the first field is a
        /// pointer to an AVClass struct.
        /// </param>
        /// <param name="level">
        /// The importance level of the message expressed using a @ref
        /// lavu_log_constants "Logging Constant".
        /// </param>
        /// <param name="fmt">
        /// The format string (printf-compatible) that specifies how
        /// subsequent arguments are converted to output.
        /// </param>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_log")]
        public static extern void av_log(void* avcl, int level, string fmt);

        /// <summary>
        /// Get the current log level
        /// 
        /// @see lavu_log_constants
        /// </summary>
        /// <returns>
        /// Current log level
        /// </returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_log_get_level")]
        public static extern int av_log_get_level();

        /// <summary>
        /// Set the log level
        /// 
        /// @see lavu_log_constants
        /// </summary>
        /// <param name="level">
        /// Logging level
        /// </param>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_log_set_level")]
        public static extern void av_log_set_level(int level);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_log_set_formatted_callback")]
        public static extern void av_log_set_formatted_callback(global::System.IntPtr _0);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_log_set_formatted_filtered_callback")]
        public static extern void av_log_set_formatted_filtered_callback(global::System.IntPtr _0);

        /// <summary>
        /// Return the context name
        /// </summary>
        /// <param name="ctx">
        /// The AVClass context
        /// </param>
        /// <returns>
        /// The AVClass class_name
        /// </returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_default_item_name")]
        public static extern sbyte* av_default_item_name(void* ctx);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_default_get_category")]
        public static extern libavutil.AVClassCategory av_default_get_category(void* ptr);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_log_set_flags")]
        public static extern void av_log_set_flags(int arg);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_log_get_flags")]
        public static extern int av_log_get_flags();
    }
}
