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
        public unsafe partial struct AVAudioFifo
        {
        }

        /// <summary>
        /// Free an AVAudioFifo.
        /// 
        /// @param af  AVAudioFifo to free
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_audio_fifo_free")]
        public static extern void av_audio_fifo_free(libavutil.AVAudioFifo* af);

        /// <summary>
        /// Allocate an AVAudioFifo.
        /// 
        /// @param sample_fmt  sample format
        /// @param channels    number of channels
        /// @param nb_samples  initial allocation size, in samples
        /// @return            newly allocated AVAudioFifo, or NULL on error
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_audio_fifo_alloc")]
        public static extern libavutil.AVAudioFifo* av_audio_fifo_alloc(libavutil.AVSampleFormat sample_fmt, int channels, int nb_samples);

        /// <summary>
        /// Reallocate an AVAudioFifo.
        /// 
        /// @param af          AVAudioFifo to reallocate
        /// @param nb_samples  new allocation size, in samples
        /// @return            0 if OK, or negative AVERROR code on failure
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_audio_fifo_realloc")]
        public static extern int av_audio_fifo_realloc(libavutil.AVAudioFifo* af, int nb_samples);

        /// <summary>
        /// Write data to an AVAudioFifo.
        /// 
        /// The AVAudioFifo will be reallocated automatically if the available
        /// space
        /// is less than nb_samples.
        /// 
        /// @see enum AVSampleFormat
        /// The documentation for AVSampleFormat describes the data layout.
        /// 
        /// @param af          AVAudioFifo to write to
        /// @param data        audio data plane pointers
        /// @param nb_samples  number of samples to write
        /// @return            number of samples actually written, or negative
        /// AVERROR
        /// code on failure. If successful, the number of samples
        /// actually written will always be nb_samples.
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_audio_fifo_write")]
        public static extern int av_audio_fifo_write(libavutil.AVAudioFifo* af, void** data, int nb_samples);

        /// <summary>
        /// Write data to an AVAudioFifo.
        /// 
        /// The AVAudioFifo will be reallocated automatically if the available
        /// space
        /// is less than nb_samples.
        /// 
        /// @see enum AVSampleFormat
        /// The documentation for AVSampleFormat describes the data layout.
        /// 
        /// @param af          AVAudioFifo to write to
        /// @param data        audio data plane pointers
        /// @param nb_samples  number of samples to write
        /// @return            number of samples actually written, or negative
        /// AVERROR
        /// code on failure. If successful, the number of samples
        /// actually written will always be nb_samples.
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_audio_fifo_write")]
        public static extern int av_audio_fifo_write(libavutil.AVAudioFifo* af, ref void* data, int nb_samples);

        /// <summary>
        /// Read data from an AVAudioFifo.
        /// 
        /// @see enum AVSampleFormat
        /// The documentation for AVSampleFormat describes the data layout.
        /// 
        /// @param af          AVAudioFifo to read from
        /// @param data        audio data plane pointers
        /// @param nb_samples  number of samples to read
        /// @return            number of samples actually read, or negative AVERROR
        /// code
        /// on failure. The number of samples actually read will not
        /// be greater than nb_samples, and will only be less than
        /// nb_samples if av_audio_fifo_size is less than nb_samples.
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_audio_fifo_read")]
        public static extern int av_audio_fifo_read(libavutil.AVAudioFifo* af, void** data, int nb_samples);

        /// <summary>
        /// Read data from an AVAudioFifo.
        /// 
        /// @see enum AVSampleFormat
        /// The documentation for AVSampleFormat describes the data layout.
        /// 
        /// @param af          AVAudioFifo to read from
        /// @param data        audio data plane pointers
        /// @param nb_samples  number of samples to read
        /// @return            number of samples actually read, or negative AVERROR
        /// code
        /// on failure. The number of samples actually read will not
        /// be greater than nb_samples, and will only be less than
        /// nb_samples if av_audio_fifo_size is less than nb_samples.
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_audio_fifo_read")]
        public static extern int av_audio_fifo_read(libavutil.AVAudioFifo* af, ref void* data, int nb_samples);

        /// <summary>
        /// Drain data from an AVAudioFifo.
        /// 
        /// Removes the data without reading it.
        /// 
        /// @param af          AVAudioFifo to drain
        /// @param nb_samples  number of samples to drain
        /// @return            0 if OK, or negative AVERROR code on failure
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_audio_fifo_drain")]
        public static extern int av_audio_fifo_drain(libavutil.AVAudioFifo* af, int nb_samples);

        /// <summary>
        /// Reset the AVAudioFifo buffer.
        /// 
        /// This empties all data in the buffer.
        /// 
        /// @param af  AVAudioFifo to reset
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_audio_fifo_reset")]
        public static extern void av_audio_fifo_reset(libavutil.AVAudioFifo* af);

        /// <summary>
        /// Get the current number of samples in the AVAudioFifo available for
        /// reading.
        /// 
        /// @param af  the AVAudioFifo to query
        /// @return    number of samples available for reading
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_audio_fifo_size")]
        public static extern int av_audio_fifo_size(libavutil.AVAudioFifo* af);

        /// <summary>
        /// Get the current number of samples in the AVAudioFifo available for
        /// writing.
        /// 
        /// @param af  the AVAudioFifo to query
        /// @return    number of samples available for writing
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_audio_fifo_space")]
        public static extern int av_audio_fifo_space(libavutil.AVAudioFifo* af);
    }
}
