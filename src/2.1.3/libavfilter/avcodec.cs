//----------------------------------------------------------------------------
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
//----------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;
using System.Security;

namespace libavfilter
{
    public unsafe partial class libavfilter
    {
        /// <summary>
        /// Create and return a picref reference from the data and properties
        /// contained in frame.
        /// 
        /// @param perms permissions to assign to the new buffer reference
        /// @deprecated avfilter APIs work natively with AVFrame instead.
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport("avfilter-if-3.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="avfilter_get_video_buffer_ref_from_frame")]
        internal static extern AVFilterBufferRef* avfilter_get_video_buffer_ref_from_frame(AVFrame* frame, int perms);

        /// <summary>
        /// Create and return a picref reference from the data and properties
        /// contained in frame.
        /// 
        /// @param perms permissions to assign to the new buffer reference
        /// @deprecated avfilter APIs work natively with AVFrame instead.
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport("avfilter-if-3.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="avfilter_get_audio_buffer_ref_from_frame")]
        internal static extern AVFilterBufferRef* avfilter_get_audio_buffer_ref_from_frame(AVFrame* frame, int perms);

        /// <summary>
        /// Create and return a buffer reference from the data and properties
        /// contained in frame.
        /// 
        /// @param perms permissions to assign to the new buffer reference
        /// @deprecated avfilter APIs work natively with AVFrame instead.
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport("avfilter-if-3.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="avfilter_get_buffer_ref_from_frame")]
        internal static extern AVFilterBufferRef* avfilter_get_buffer_ref_from_frame(AVMediaType type, AVFrame* frame, int perms);

        /// <summary>
        /// Fill an AVFrame with the information stored in samplesref.
        /// 
        /// @param frame an already allocated AVFrame
        /// @param samplesref an audio buffer reference
        /// @return >= 0 in case of success, a negative AVERROR code in case of
        /// failure
        /// @deprecated Use avfilter_copy_buf_props() instead.
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport("avfilter-if-3.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="avfilter_fill_frame_from_audio_buffer_ref")]
        internal static extern int avfilter_fill_frame_from_audio_buffer_ref(AVFrame* frame, AVFilterBufferRef* samplesref);

        /// <summary>
        /// Fill an AVFrame with the information stored in picref.
        /// 
        /// @param frame an already allocated AVFrame
        /// @param picref a video buffer reference
        /// @return >= 0 in case of success, a negative AVERROR code in case of
        /// failure
        /// @deprecated Use avfilter_copy_buf_props() instead.
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport("avfilter-if-3.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="avfilter_fill_frame_from_video_buffer_ref")]
        internal static extern int avfilter_fill_frame_from_video_buffer_ref(AVFrame* frame, AVFilterBufferRef* picref);

        /// <summary>
        /// Fill an AVFrame with information stored in ref.
        /// 
        /// @param frame an already allocated AVFrame
        /// @param ref a video or audio buffer reference
        /// @return >= 0 in case of success, a negative AVERROR code in case of
        /// failure
        /// @deprecated Use avfilter_copy_buf_props() instead.
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport("avfilter-if-3.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="avfilter_fill_frame_from_buffer_ref")]
        internal static extern int avfilter_fill_frame_from_buffer_ref(AVFrame* frame, AVFilterBufferRef* @ref);
    }
}
