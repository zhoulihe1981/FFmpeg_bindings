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
        public unsafe partial struct AVComponentDescriptor
        {
            /// <summary>
            /// which of the 4 planes contains the component
            /// </summary>
            public ushort plane;

            /// <summary>
            /// Number of elements between 2 horizontally consecutive pixels minus 1.
            /// Elements are bits for bitstream formats, bytes otherwise.
            /// </summary>
            public ushort step_minus1;

            /// <summary>
            /// Number of elements before the component of the first pixel plus 1.
            /// Elements are bits for bitstream formats, bytes otherwise.
            /// </summary>
            public ushort offset_plus1;

            /// <summary>
            /// number of least significant bits that must be shifted away to get the
            /// value
            /// </summary>
            public ushort shift;

            /// <summary>
            /// number of bits in the component minus 1
            /// </summary>
            public ushort depth_minus1;
        }

        /// <summary>
        /// Descriptor that unambiguously describes how the bits of a pixel are
        /// stored in the up to 4 data planes of an image. It also stores the
        /// subsampling factors and number of components.
        /// </summary>
        /// <remark>
        /// This is separate of the colorspace (RGB, YCbCr, YPbPr, JPEG-style YUV
        /// and all the YUV variants) AVPixFmtDescriptor just stores how values
        /// are stored not what these values represent.
        /// </remark>
        [StructLayout(LayoutKind.Sequential)]
        public unsafe partial struct AVPixFmtDescriptor
        {
            public sbyte* name;

            /// <summary>
            /// The number of components each pixel has, (1-4)
            /// </summary>
            public byte nb_components;

            /// <summary>
            /// chroma_width = -((-luma_width )>>log2_chroma_w)
            /// </summary>
            public byte log2_chroma_w;

            /// <summary>
            /// Amount to shift the luma height right to find the chroma height.
            /// For YV12 this is 1 for example.
            /// chroma_height= -((-luma_height) >> log2_chroma_h)
            /// The note above is needed to ensure rounding up.
            /// This value only refers to the chroma components.
            /// </summary>
            public byte log2_chroma_h;

            public byte flags;

            /// <summary>
            /// Parameters that describe how pixels are packed.
            /// If the format has 2 or 4 components, then alpha is last.
            /// If the format has 1 or 2 components, then luma is 0.
            /// If the format has 3 or 4 components,
            /// if the RGB flag is set then 0 is red, 1 is green and 2 is blue;
            /// otherwise 0 is luma, 1 is chroma-U and 2 is chroma-V.
            /// </summary>
            public libavutil.ArrayWrapper_AVComponentDescriptor4 comp;
        }

        /// <summary>
        /// Read a line from an image, and write the values of the
        /// pixel format component c to dst.
        /// </summary>
        /// <param name="data">
        /// the array containing the pointers to the planes of the image
        /// </param>
        /// <param name="linesize">
        /// the array containing the linesizes of the image
        /// </param>
        /// <param name="desc">
        /// the pixel format descriptor for the image
        /// </param>
        /// <param name="x">
        /// the horizontal coordinate of the first pixel to read
        /// </param>
        /// <param name="y">
        /// the vertical coordinate of the first pixel to read
        /// </param>
        /// <param name="w">
        /// the width of the line to read, that is the number of
        /// values to write to dst
        /// </param>
        /// <param name="read_pal_component">
        /// if not zero and the format is a paletted
        /// format writes the values corresponding to the palette
        /// component c in data[1] to dst, rather than the palette indexes in
        /// data[0]. The behavior is undefined if the format is not paletted.
        /// </param>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_read_image_line")]
        public static extern void av_read_image_line(ushort* dst, byte** data, int* linesize, libavutil.AVPixFmtDescriptor* desc, int x, int y, int c, int w, int read_pal_component);

        /// <summary>
        /// Write the values from src to the pixel format component c of an
        /// image line.
        /// </summary>
        /// <param name="src">
        /// array containing the values to write
        /// </param>
        /// <param name="data">
        /// the array containing the pointers to the planes of the
        /// image to write into. It is supposed to be zeroed.
        /// </param>
        /// <param name="linesize">
        /// the array containing the linesizes of the image
        /// </param>
        /// <param name="desc">
        /// the pixel format descriptor for the image
        /// </param>
        /// <param name="x">
        /// the horizontal coordinate of the first pixel to write
        /// </param>
        /// <param name="y">
        /// the vertical coordinate of the first pixel to write
        /// </param>
        /// <param name="w">
        /// the width of the line to write, that is the number of
        /// values to write to the image line
        /// </param>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_write_image_line")]
        public static extern void av_write_image_line(ushort* src, byte** data, int* linesize, libavutil.AVPixFmtDescriptor* desc, int x, int y, int c, int w);

        /// <summary>
        /// Return the pixel format corresponding to name.
        /// 
        /// If there is no pixel format with name name, then looks for a
        /// pixel format with the name corresponding to the native endian
        /// format of name.
        /// For example in a little-endian system, first looks for "gray16",
        /// then for "gray16le".
        /// 
        /// Finally if no pixel format has been found, returns AV_PIX_FMT_NONE.
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_get_pix_fmt")]
        public static extern libavutil.AVPixelFormat av_get_pix_fmt(string name);

        /// <summary>
        /// Return the short name for a pixel format, NULL in case pix_fmt is
        /// unknown.
        /// 
        /// @see av_get_pix_fmt(), av_get_pix_fmt_string()
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_get_pix_fmt_name")]
        public static extern sbyte* av_get_pix_fmt_name(libavutil.AVPixelFormat pix_fmt);

        /// <summary>
        /// Print in buf the string corresponding to the pixel format with
        /// number pix_fmt, or a header if pix_fmt is negative.
        /// </summary>
        /// <param name="buf">
        /// the buffer where to write the string
        /// </param>
        /// <param name="buf_size">
        /// the size of buf
        /// </param>
        /// <param name="pix_fmt">
        /// the number of the pixel format to print the
        /// corresponding info string, or a negative value to print the
        /// corresponding header.
        /// </param>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_get_pix_fmt_string")]
        public static extern sbyte* av_get_pix_fmt_string(System.Text.StringBuilder buf, int buf_size, libavutil.AVPixelFormat pix_fmt);

        /// <summary>
        /// Return the number of bits per pixel used by the pixel format
        /// described by pixdesc. Note that this is not the same as the number
        /// of bits per sample.
        /// 
        /// The returned number of bits refers to the number of bits actually
        /// used for storing the pixel information, that is padding bits are
        /// not counted.
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_get_bits_per_pixel")]
        public static extern int av_get_bits_per_pixel(libavutil.AVPixFmtDescriptor* pixdesc);

        /// <summary>
        /// Return the number of bits per pixel for the pixel format
        /// described by pixdesc, including any padding or unused bits.
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_get_padded_bits_per_pixel")]
        public static extern int av_get_padded_bits_per_pixel(libavutil.AVPixFmtDescriptor* pixdesc);

        /// <summary>
        /// 
        /// </summary>
        /// <returns>
        /// a pixel format descriptor for provided pixel format or NULL if
        /// this pixel format is unknown.
        /// </returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_pix_fmt_desc_get")]
        public static extern libavutil.AVPixFmtDescriptor* av_pix_fmt_desc_get(libavutil.AVPixelFormat pix_fmt);

        /// <summary>
        /// Iterate over all pixel format descriptors known to libavutil.
        /// </summary>
        /// <param name="prev">
        /// previous descriptor. NULL to get the first descriptor.
        /// </param>
        /// <returns>
        /// next descriptor or NULL after the last descriptor
        /// </returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_pix_fmt_desc_next")]
        public static extern libavutil.AVPixFmtDescriptor* av_pix_fmt_desc_next(libavutil.AVPixFmtDescriptor* prev);

        /// <summary>
        /// 
        /// </summary>
        /// <returns>
        /// an AVPixelFormat id described by desc, or AV_PIX_FMT_NONE if desc
        /// is not a valid pointer to a pixel format descriptor.
        /// </returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_pix_fmt_desc_get_id")]
        public static extern libavutil.AVPixelFormat av_pix_fmt_desc_get_id(libavutil.AVPixFmtDescriptor* desc);

        /// <summary>
        /// Utility function to access log2_chroma_w log2_chroma_h from
        /// the pixel format AVPixFmtDescriptor.
        /// 
        /// See avcodec_get_chroma_sub_sample() for a function that asserts a
        /// valid pixel format instead of returning an error code.
        /// Its recommanded that you use avcodec_get_chroma_sub_sample unless
        /// you do check the return code!
        /// </summary>
        /// <param name="[in]">
        /// pix_fmt the pixel format
        /// </param>
        /// <param name="[out]">
        /// h_shift store log2_chroma_w
        /// </param>
        /// <param name="[out]">
        /// v_shift store log2_chroma_h
        /// </param>
        /// <returns>
        /// 0 on success, AVERROR(ENOSYS) on invalid or unknown pixel format
        /// </returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_pix_fmt_get_chroma_sub_sample")]
        public static extern int av_pix_fmt_get_chroma_sub_sample(libavutil.AVPixelFormat pix_fmt, int* h_shift, int* v_shift);

        /// <summary>
        /// 
        /// </summary>
        /// <returns>
        /// number of planes in pix_fmt, a negative AVERROR if pix_fmt is not a
        /// valid pixel format.
        /// </returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_pix_fmt_count_planes")]
        public static extern int av_pix_fmt_count_planes(libavutil.AVPixelFormat pix_fmt);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="ff_check_pixfmt_descriptors")]
        public static extern void ff_check_pixfmt_descriptors();

        /// <summary>
        /// Utility function to swap the endianness of a pixel format.
        /// </summary>
        /// <param name="[in]">
        /// pix_fmt the pixel format
        /// </param>
        /// <returns>
        /// pixel format with swapped endianness if it exists,
        /// otherwise AV_PIX_FMT_NONE
        /// </returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_pix_fmt_swap_endianness")]
        public static extern libavutil.AVPixelFormat av_pix_fmt_swap_endianness(libavutil.AVPixelFormat pix_fmt);
    }
}
