//----------------------------------------------------------------------------
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
//----------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;
using System.Security;
using FFmpeg;

namespace FFmpeg
{
    public unsafe static partial class libavfilter
    {
        public const sbyte AV_BUFFERSINK_FLAG_PEEK = 1;

        public const sbyte AV_BUFFERSINK_FLAG_NO_REQUEST = 2;

        /// <summary>
        /// Struct to use for initializing a buffersink context.
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public unsafe partial struct AVBufferSinkParams
        {
            /// <summary>
            /// list of allowed pixel formats, terminated by AV_PIX_FMT_NONE
            /// </summary>
            public libavutil.AVPixelFormat* pixel_fmts;
        }

        /// <summary>
        /// Struct to use for initializing an abuffersink context.
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public unsafe partial struct AVABufferSinkParams
        {
            /// <summary>
            /// list of allowed sample formats, terminated by AV_SAMPLE_FMT_NONE
            /// </summary>
            public libavutil.AVSampleFormat* sample_fmts;

            /// <summary>
            /// list of allowed channel layouts, terminated by -1
            /// </summary>
            public long* channel_layouts;

            /// <summary>
            /// list of allowed channel counts, terminated by -1
            /// </summary>
            public int* channel_counts;

            /// <summary>
            /// if not 0, accept any channel count or layout
            /// </summary>
            public int all_channel_counts;

            /// <summary>
            /// list of allowed sample rates, terminated by -1
            /// </summary>
            public int* sample_rates;
        }

        /// <summary>
        /// Get an audio/video buffer data from buffer_sink and put it in bufref.
        /// 
        /// This function works with both audio and video buffer sinks.
        /// 
        /// @param buffer_sink pointer to a buffersink or abuffersink context
        /// @param flags a combination of AV_BUFFERSINK_FLAG_* flags
        /// @return >= 0 in case of success, a negative AVERROR code in case of
        /// failure
        /// </summary>
        [System.ObsoleteAttribute()]
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVFILTER_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_buffersink_get_buffer_ref")]
        public static extern int av_buffersink_get_buffer_ref(libavfilter.AVFilterContext* buffer_sink, libavfilter.AVFilterBufferRef** bufref, int flags);

        /// <summary>
        /// Get an audio/video buffer data from buffer_sink and put it in bufref.
        /// 
        /// This function works with both audio and video buffer sinks.
        /// 
        /// @param buffer_sink pointer to a buffersink or abuffersink context
        /// @param flags a combination of AV_BUFFERSINK_FLAG_* flags
        /// @return >= 0 in case of success, a negative AVERROR code in case of
        /// failure
        /// </summary>
        [System.ObsoleteAttribute()]
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVFILTER_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_buffersink_get_buffer_ref")]
        public static extern int av_buffersink_get_buffer_ref(libavfilter.AVFilterContext* buffer_sink, ref libavfilter.AVFilterBufferRef* bufref, int flags);

        /// <summary>
        /// Get the number of immediately available frames.
        /// </summary>
        [System.ObsoleteAttribute()]
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVFILTER_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_buffersink_poll_frame")]
        public static extern int av_buffersink_poll_frame(libavfilter.AVFilterContext* ctx);

        /// <summary>
        /// Get a buffer with filtered data from sink and put it in buf.
        /// 
        /// @param ctx pointer to a context of a buffersink or abuffersink
        /// AVFilter.
        /// @param buf pointer to the buffer will be written here if buf is
        /// non-NULL. buf
        /// must be freed by the caller using avfilter_unref_buffer().
        /// Buf may also be NULL to query whether a buffer is ready to be
        /// output.
        /// 
        /// @return >= 0 in case of success, a negative AVERROR code in case of
        /// failure.
        /// </summary>
        [System.ObsoleteAttribute()]
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVFILTER_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_buffersink_read")]
        public static extern int av_buffersink_read(libavfilter.AVFilterContext* ctx, libavfilter.AVFilterBufferRef** buf);

        /// <summary>
        /// Get a buffer with filtered data from sink and put it in buf.
        /// 
        /// @param ctx pointer to a context of a buffersink or abuffersink
        /// AVFilter.
        /// @param buf pointer to the buffer will be written here if buf is
        /// non-NULL. buf
        /// must be freed by the caller using avfilter_unref_buffer().
        /// Buf may also be NULL to query whether a buffer is ready to be
        /// output.
        /// 
        /// @return >= 0 in case of success, a negative AVERROR code in case of
        /// failure.
        /// </summary>
        [System.ObsoleteAttribute()]
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVFILTER_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_buffersink_read")]
        public static extern int av_buffersink_read(libavfilter.AVFilterContext* ctx, ref libavfilter.AVFilterBufferRef* buf);

        /// <summary>
        /// Same as av_buffersink_read, but with the ability to specify the number
        /// of
        /// samples read. This function is less efficient than
        /// av_buffersink_read(),
        /// because it copies the data around.
        /// 
        /// @param ctx pointer to a context of the abuffersink AVFilter.
        /// @param buf pointer to the buffer will be written here if buf is
        /// non-NULL. buf
        /// must be freed by the caller using avfilter_unref_buffer(). buf
        /// will contain exactly nb_samples audio samples, except at the end
        /// of stream, when it can contain less than nb_samples.
        /// Buf may also be NULL to query whether a buffer is ready to be
        /// output.
        /// 
        /// @warning do not mix this function with av_buffersink_read(). Use only
        /// one or
        /// the other with a single sink, not both.
        /// </summary>
        [System.ObsoleteAttribute()]
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVFILTER_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_buffersink_read_samples")]
        public static extern int av_buffersink_read_samples(libavfilter.AVFilterContext* ctx, libavfilter.AVFilterBufferRef** buf, int nb_samples);

        /// <summary>
        /// Same as av_buffersink_read, but with the ability to specify the number
        /// of
        /// samples read. This function is less efficient than
        /// av_buffersink_read(),
        /// because it copies the data around.
        /// 
        /// @param ctx pointer to a context of the abuffersink AVFilter.
        /// @param buf pointer to the buffer will be written here if buf is
        /// non-NULL. buf
        /// must be freed by the caller using avfilter_unref_buffer(). buf
        /// will contain exactly nb_samples audio samples, except at the end
        /// of stream, when it can contain less than nb_samples.
        /// Buf may also be NULL to query whether a buffer is ready to be
        /// output.
        /// 
        /// @warning do not mix this function with av_buffersink_read(). Use only
        /// one or
        /// the other with a single sink, not both.
        /// </summary>
        [System.ObsoleteAttribute()]
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVFILTER_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_buffersink_read_samples")]
        public static extern int av_buffersink_read_samples(libavfilter.AVFilterContext* ctx, ref libavfilter.AVFilterBufferRef* buf, int nb_samples);

        /// <summary>
        /// Get a frame with filtered data from sink and put it in frame.
        /// 
        /// @param ctx    pointer to a buffersink or abuffersink filter context.
        /// @param frame  pointer to an allocated frame that will be filled with
        /// data.
        /// The data must be freed using av_frame_unref() / av_frame_free()
        /// @param flags  a combination of AV_BUFFERSINK_FLAG_* flags
        /// 
        /// @return  >= 0 in for success, a negative AVERROR code for failure.
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVFILTER_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_buffersink_get_frame_flags")]
        public static extern int av_buffersink_get_frame_flags(libavfilter.AVFilterContext* ctx, libavutil.AVFrame* frame, int flags);

        /// <summary>
        /// Create an AVBufferSinkParams structure.
        /// 
        /// Must be freed with av_free().
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVFILTER_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_buffersink_params_alloc")]
        public static extern libavfilter.AVBufferSinkParams* av_buffersink_params_alloc();

        /// <summary>
        /// Create an AVABufferSinkParams structure.
        /// 
        /// Must be freed with av_free().
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVFILTER_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_abuffersink_params_alloc")]
        public static extern libavfilter.AVABufferSinkParams* av_abuffersink_params_alloc();

        /// <summary>
        /// Set the frame size for an audio buffer sink.
        /// 
        /// All calls to av_buffersink_get_buffer_ref will return a buffer with
        /// exactly the specified number of samples, or AVERROR(EAGAIN) if there is
        /// not enough. The last buffer at EOF will be padded with 0.
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVFILTER_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_buffersink_set_frame_size")]
        public static extern void av_buffersink_set_frame_size(libavfilter.AVFilterContext* ctx, uint frame_size);

        /// <summary>
        /// Get the frame rate of the input.
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVFILTER_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_buffersink_get_frame_rate")]
        public static extern libavutil.AVRational av_buffersink_get_frame_rate(libavfilter.AVFilterContext* ctx);

        /// <summary>
        /// Get a frame with filtered data from sink and put it in frame.
        /// 
        /// @param ctx pointer to a context of a buffersink or abuffersink
        /// AVFilter.
        /// @param frame pointer to an allocated frame that will be filled with
        /// data.
        /// The data must be freed using av_frame_unref() / av_frame_free()
        /// 
        /// @return
        /// - >= 0 if a frame was successfully returned.
        /// - AVERROR(EAGAIN) if no frames are available at this point; more
        /// input frames must be added to the filtergraph to get more output.
        /// - AVERROR_EOF if there will be no more output frames on this sink.
        /// - A different negative AVERROR code in other failure cases.
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVFILTER_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_buffersink_get_frame")]
        public static extern int av_buffersink_get_frame(libavfilter.AVFilterContext* ctx, libavutil.AVFrame* frame);

        /// <summary>
        /// Same as av_buffersink_get_frame(), but with the ability to specify the
        /// number
        /// of samples read. This function is less efficient than
        /// av_buffersink_get_frame(), because it copies the data around.
        /// 
        /// @param ctx pointer to a context of the abuffersink AVFilter.
        /// @param frame pointer to an allocated frame that will be filled with
        /// data.
        /// The data must be freed using av_frame_unref() / av_frame_free()
        /// frame will contain exactly nb_samples audio samples, except at
        /// the end of stream, when it can contain less than nb_samples.
        /// 
        /// @return The return codes have the same meaning as for
        /// av_buffersink_get_samples().
        /// 
        /// @warning do not mix this function with av_buffersink_get_frame(). Use
        /// only one or
        /// the other with a single sink, not both.
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVFILTER_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_buffersink_get_samples")]
        public static extern int av_buffersink_get_samples(libavfilter.AVFilterContext* ctx, libavutil.AVFrame* frame, int nb_samples);
    }
}
