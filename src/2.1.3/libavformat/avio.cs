//----------------------------------------------------------------------------
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
//----------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;
using System.Security;

namespace libavformat
{
    /// <summary>
    /// Callback for checking whether to abort blocking functions.
    /// AVERROR_EXIT is returned in this case by the interrupted
    /// function. During blocking operations, callback is called with
    /// opaque as parameter. If the callback returns 1, the
    /// blocking operation will be aborted.
    /// 
    /// No members can be added to this struct without a major bump, if
    /// new elements have been added after this struct in AVFormatContext
    /// or AVIOContext.
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct AVIOInterruptCB
    {
        [FieldOffset(0)]
        public global::System.IntPtr callback;

        [FieldOffset(4)]
        public global::System.IntPtr opaque;
    }

    /// <summary>
    /// Bytestream IO Context.
    /// New fields can be added to the end with minor version bumps.
    /// Removal, reordering and changes to existing fields require a major
    /// version bump.
    /// sizeof(AVIOContext) must not be used outside libav*.
    /// 
    /// @note None of the function pointers in AVIOContext should be called
    /// directly, they should only be set by the client application
    /// when implementing custom I/O. Normally these are set to the
    /// function pointers specified in avio_alloc_context()
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct AVIOContext
    {
        /// <summary>
        /// A class for private options.
        /// 
        /// If this AVIOContext is created by avio_open2(), av_class is set and
        /// passes the options down to protocols.
        /// 
        /// If this AVIOContext is manually allocated, then av_class may be set
        /// by
        /// the caller.
        /// 
        /// warning -- this field can be NULL, be sure to not pass this
        /// AVIOContext
        /// to any av_opt_* functions in that case.
        /// </summary>
        [FieldOffset(0)]
        public AVClass* av_class;

        /// <summary>
        /// </summary>
        [FieldOffset(4)]
        public byte* buffer;

        /// <summary>
        /// </summary>
        [FieldOffset(8)]
        public int buffer_size;

        /// <summary>
        /// </summary>
        [FieldOffset(12)]
        public byte* buf_ptr;

        /// <summary>
        /// buffer+buffer_size if the read function returned
        /// less data than requested, e.g. for streams where
        /// no more data has been received yet. */
        /// </summary>
        [FieldOffset(16)]
        public byte* buf_end;

        /// <summary>
        /// functions. */
        /// </summary>
        [FieldOffset(20)]
        public global::System.IntPtr opaque;

        [FieldOffset(24)]
        public global::System.IntPtr read_packet;

        [FieldOffset(28)]
        public global::System.IntPtr write_packet;

        [FieldOffset(32)]
        public global::System.IntPtr seek;

        /// <summary>
        /// </summary>
        [FieldOffset(40)]
        public long pos;

        /// <summary>
        /// </summary>
        [FieldOffset(48)]
        public int must_flush;

        /// <summary>
        /// </summary>
        [FieldOffset(52)]
        public int eof_reached;

        /// <summary>
        /// </summary>
        [FieldOffset(56)]
        public int write_flag;

        [FieldOffset(60)]
        public int max_packet_size;

        [FieldOffset(64)]
        public uint checksum;

        [FieldOffset(68)]
        public byte* checksum_ptr;

        [FieldOffset(72)]
        public global::System.IntPtr update_checksum;

        /// <summary>
        /// </summary>
        [FieldOffset(76)]
        public int error;

        /// <summary>
        /// Pause or resume playback for network streaming protocols - e.g.
        /// MMS.
        /// </summary>
        [FieldOffset(80)]
        public global::System.IntPtr read_pause;

        /// <summary>
        /// Seek to a given timestamp in stream with the specified
        /// stream_index.
        /// Needed for some network streaming protocols which don't support
        /// seeking
        /// to byte position.
        /// </summary>
        [FieldOffset(84)]
        public global::System.IntPtr read_seek;

        /// <summary>
        /// A combination of AVIO_SEEKABLE_ flags or 0 when the stream is not
        /// seekable.
        /// </summary>
        [FieldOffset(88)]
        public int seekable;

        /// <summary>
        /// max filesize, used to limit allocations
        /// This field is internal to libavformat and access from outside is
        /// not allowed.
        /// </summary>
        [FieldOffset(96)]
        public long maxsize;

        /// <summary>
        /// avio_read and avio_write should if possible be satisfied directly
        /// instead of going through a buffer, and avio_seek will always
        /// call the underlying seek function directly.
        /// </summary>
        [FieldOffset(104)]
        public int direct;

        /// <summary>
        /// Bytes read statistic
        /// This field is internal to libavformat and access from outside is
        /// not allowed.
        /// </summary>
        [FieldOffset(112)]
        public long bytes_read;

        /// <summary>
        /// seek statistic
        /// This field is internal to libavformat and access from outside is
        /// not allowed.
        /// </summary>
        [FieldOffset(120)]
        public int seek_count;

        /// <summary>
        /// writeout statistic
        /// This field is internal to libavformat and access from outside is
        /// not allowed.
        /// </summary>
        [FieldOffset(124)]
        public int writeout_count;
    }

    public unsafe partial class libavformat
    {
        /// <summary>
        /// Return AVIO_FLAG_* access flags corresponding to the access permissions
        /// of the resource in url, or a negative value corresponding to an
        /// AVERROR code in case of failure. The returned access flags are
        /// masked by the value in flags.
        /// 
        /// @note This function is intrinsically unsafe, in the sense that the
        /// checked resource may change its existence or permission status from
        /// one call to another. Thus you should not trust the returned value,
        /// unless you are sure that no other processes are accessing the
        /// checked resource.
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport("avformat-if-55.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="avio_check")]
        internal static extern int avio_check(global::System.IntPtr url, int flags);

        /// <summary>
        /// Allocate and initialize an AVIOContext for buffered I/O. It must be
        /// later
        /// freed with av_free().
        /// 
        /// @param buffer Memory block for input/output operations via AVIOContext.
        /// The buffer must be allocated with av_malloc() and friends.
        /// @param buffer_size The buffer size is very important for performance.
        /// For protocols with fixed blocksize it should be set to this blocksize.
        /// For others a typical size is a cache page, e.g. 4kb.
        /// @param write_flag Set to 1 if the buffer should be writable, 0
        /// otherwise.
        /// @param opaque An opaque pointer to user-specific data.
        /// @param read_packet  A function for refilling the buffer, may be NULL.
        /// @param write_packet A function for writing the buffer contents, may be
        /// NULL.
        /// The function may not change the input buffers content.
        /// @param seek A function for seeking to specified byte position, may be
        /// NULL.
        /// 
        /// @return Allocated AVIOContext or NULL on failure.
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport("avformat-if-55.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="avio_alloc_context")]
        internal static extern AVIOContext* avio_alloc_context(byte* buffer, int buffer_size, int write_flag, global::System.IntPtr opaque, global::System.IntPtr read_packet, global::System.IntPtr write_packet, global::System.IntPtr seek);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("avformat-if-55.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="avio_w8")]
        internal static extern void avio_w8(AVIOContext* s, int b);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("avformat-if-55.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="avio_write")]
        internal static extern void avio_write(AVIOContext* s, byte* buf, int size);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("avformat-if-55.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="avio_wl64")]
        internal static extern void avio_wl64(AVIOContext* s, ulong val);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("avformat-if-55.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="avio_wb64")]
        internal static extern void avio_wb64(AVIOContext* s, ulong val);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("avformat-if-55.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="avio_wl32")]
        internal static extern void avio_wl32(AVIOContext* s, uint val);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("avformat-if-55.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="avio_wb32")]
        internal static extern void avio_wb32(AVIOContext* s, uint val);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("avformat-if-55.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="avio_wl24")]
        internal static extern void avio_wl24(AVIOContext* s, uint val);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("avformat-if-55.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="avio_wb24")]
        internal static extern void avio_wb24(AVIOContext* s, uint val);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("avformat-if-55.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="avio_wl16")]
        internal static extern void avio_wl16(AVIOContext* s, uint val);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("avformat-if-55.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="avio_wb16")]
        internal static extern void avio_wb16(AVIOContext* s, uint val);

        /// <summary>
        /// Write a NULL-terminated string.
        /// @return number of bytes written.
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport("avformat-if-55.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="avio_put_str")]
        internal static extern int avio_put_str(AVIOContext* s, global::System.IntPtr str);

        /// <summary>
        /// Convert an UTF-8 string to UTF-16LE and write it.
        /// @return number of bytes written.
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport("avformat-if-55.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="avio_put_str16le")]
        internal static extern int avio_put_str16le(AVIOContext* s, global::System.IntPtr str);

        /// <summary>
        /// fseek() equivalent for AVIOContext.
        /// @return new position or AVERROR.
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport("avformat-if-55.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="avio_seek")]
        internal static extern long avio_seek(AVIOContext* s, long offset, int whence);

        /// <summary>
        /// Skip given number of bytes forward
        /// @return new position or AVERROR.
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport("avformat-if-55.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="avio_skip")]
        internal static extern long avio_skip(AVIOContext* s, long offset);

        /// <summary>
        /// ftell() equivalent for AVIOContext.
        /// @return position or AVERROR.
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport("avformat-if-55.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="avio_tell")]
        internal static extern long avio_tell(AVIOContext* s);

        /// <summary>
        /// Get the filesize.
        /// @return filesize or AVERROR
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport("avformat-if-55.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="avio_size")]
        internal static extern long avio_size(AVIOContext* s);

        /// <summary>
        /// feof() equivalent for AVIOContext.
        /// @return non zero if and only if end of file
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport("avformat-if-55.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="url_feof")]
        internal static extern int url_feof(AVIOContext* s);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("avformat-if-55.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="avio_printf")]
        internal static extern int avio_printf(AVIOContext* s, global::System.IntPtr fmt);

        /// <summary>
        /// Force flushing of buffered data to the output s.
        /// 
        /// Force the buffered data to be immediately written to the output,
        /// without to wait to fill the internal buffer.
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport("avformat-if-55.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="avio_flush")]
        internal static extern void avio_flush(AVIOContext* s);

        /// <summary>
        /// Read size bytes from AVIOContext into buf.
        /// @return number of bytes read or AVERROR
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport("avformat-if-55.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="avio_read")]
        internal static extern int avio_read(AVIOContext* s, byte* buf, int size);

        /// <summary>
        /// @name Functions for reading from AVIOContext
        /// @{
        /// 
        /// @note return 0 if EOF, so you cannot use it if EOF handling is
        /// necessary
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport("avformat-if-55.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="avio_r8")]
        internal static extern int avio_r8(AVIOContext* s);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("avformat-if-55.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="avio_rl16")]
        internal static extern uint avio_rl16(AVIOContext* s);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("avformat-if-55.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="avio_rl24")]
        internal static extern uint avio_rl24(AVIOContext* s);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("avformat-if-55.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="avio_rl32")]
        internal static extern uint avio_rl32(AVIOContext* s);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("avformat-if-55.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="avio_rl64")]
        internal static extern ulong avio_rl64(AVIOContext* s);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("avformat-if-55.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="avio_rb16")]
        internal static extern uint avio_rb16(AVIOContext* s);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("avformat-if-55.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="avio_rb24")]
        internal static extern uint avio_rb24(AVIOContext* s);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("avformat-if-55.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="avio_rb32")]
        internal static extern uint avio_rb32(AVIOContext* s);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("avformat-if-55.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="avio_rb64")]
        internal static extern ulong avio_rb64(AVIOContext* s);

        /// <summary>
        /// Read a string from pb into buf. The reading will terminate when either
        /// a NULL character was encountered, maxlen bytes have been read, or
        /// nothing
        /// more can be read from pb. The result is guaranteed to be
        /// NULL-terminated, it
        /// will be truncated if buf is too small.
        /// Note that the string is not interpreted or validated in any way, it
        /// might get truncated in the middle of a sequence for multi-byte
        /// encodings.
        /// 
        /// @return number of bytes read (is always <= maxlen).
        /// If reading ends on EOF or error, the return value will be one more than
        /// bytes actually read.
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport("avformat-if-55.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="avio_get_str")]
        internal static extern int avio_get_str(AVIOContext* pb, int maxlen, sbyte* buf, int buflen);

        /// <summary>
        /// Read a UTF-16 string from pb and convert it to UTF-8.
        /// The reading will terminate when either a null or invalid character was
        /// encountered or maxlen bytes have been read.
        /// @return number of bytes read (is always <= maxlen)
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport("avformat-if-55.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="avio_get_str16le")]
        internal static extern int avio_get_str16le(AVIOContext* pb, int maxlen, sbyte* buf, int buflen);

        [SuppressUnmanagedCodeSecurity]
        [DllImport("avformat-if-55.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="avio_get_str16be")]
        internal static extern int avio_get_str16be(AVIOContext* pb, int maxlen, sbyte* buf, int buflen);

        /// <summary>
        /// Create and initialize a AVIOContext for accessing the
        /// resource indicated by url.
        /// @note When the resource indicated by url has been opened in
        /// read+write mode, the AVIOContext can be used only for writing.
        /// 
        /// @param s Used to return the pointer to the created AVIOContext.
        /// In case of failure the pointed to value is set to NULL.
        /// @param flags flags which control how the resource indicated by url
        /// is to be opened
        /// @return >= 0 in case of success, a negative value corresponding to an
        /// AVERROR code in case of failure
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport("avformat-if-55.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="avio_open")]
        internal static extern int avio_open(AVIOContext* s, global::System.IntPtr url, int flags);

        /// <summary>
        /// Create and initialize a AVIOContext for accessing the
        /// resource indicated by url.
        /// @note When the resource indicated by url has been opened in
        /// read+write mode, the AVIOContext can be used only for writing.
        /// 
        /// @param s Used to return the pointer to the created AVIOContext.
        /// In case of failure the pointed to value is set to NULL.
        /// @param flags flags which control how the resource indicated by url
        /// is to be opened
        /// @param int_cb an interrupt callback to be used at the protocols level
        /// @param options  A dictionary filled with protocol-private options. On
        /// return
        /// this parameter will be destroyed and replaced with a dict containing
        /// options
        /// that were not found. May be NULL.
        /// @return >= 0 in case of success, a negative value corresponding to an
        /// AVERROR code in case of failure
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport("avformat-if-55.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="avio_open2")]
        internal static extern int avio_open2(AVIOContext* s, global::System.IntPtr url, int flags, AVIOInterruptCB* int_cb, AVDictionary* options);

        /// <summary>
        /// Close the resource accessed by the AVIOContext s and free it.
        /// This function can only be used if s was opened by avio_open().
        /// 
        /// The internal buffer is automatically flushed before closing the
        /// resource.
        /// 
        /// @return 0 on success, an AVERROR < 0 on error.
        /// @see avio_closep
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport("avformat-if-55.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="avio_close")]
        internal static extern int avio_close(AVIOContext* s);

        /// <summary>
        /// Close the resource accessed by the AVIOContext *s, free it
        /// and set the pointer pointing to it to NULL.
        /// This function can only be used if s was opened by avio_open().
        /// 
        /// The internal buffer is automatically flushed before closing the
        /// resource.
        /// 
        /// @return 0 on success, an AVERROR < 0 on error.
        /// @see avio_close
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport("avformat-if-55.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="avio_closep")]
        internal static extern int avio_closep(AVIOContext* s);

        /// <summary>
        /// Open a write only memory stream.
        /// 
        /// @param s new IO context
        /// @return zero if no error.
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport("avformat-if-55.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="avio_open_dyn_buf")]
        internal static extern int avio_open_dyn_buf(AVIOContext* s);

        /// <summary>
        /// Return the written size and a pointer to the buffer. The buffer
        /// must be freed with av_free().
        /// Padding of FF_INPUT_BUFFER_PADDING_SIZE is added to the buffer.
        /// 
        /// @param s IO context
        /// @param pbuffer pointer to a byte buffer
        /// @return the length of the byte buffer
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport("avformat-if-55.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="avio_close_dyn_buf")]
        internal static extern int avio_close_dyn_buf(AVIOContext* s, byte* pbuffer);

        /// <summary>
        /// Iterate through names of available protocols.
        /// 
        /// @param opaque A private pointer representing current protocol.
        /// It must be a pointer to NULL on first iteration and will
        /// be updated by successive calls to avio_enum_protocols.
        /// @param output If set to 1, iterate over output protocols,
        /// otherwise over input protocols.
        /// 
        /// @return A static string containing the name of current protocol or NULL
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport("avformat-if-55.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="avio_enum_protocols")]
        internal static extern global::System.IntPtr avio_enum_protocols(global::System.IntPtr opaque, int output);

        /// <summary>
        /// Pause and resume playing - only meaningful if using a network streaming
        /// protocol (e.g. MMS).
        /// @param pause 1 for pause, 0 for resume
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport("avformat-if-55.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="avio_pause")]
        internal static extern int avio_pause(AVIOContext* h, int pause);

        /// <summary>
        /// Seek to a given timestamp relative to some component stream.
        /// Only meaningful if using a network streaming protocol (e.g. MMS.).
        /// @param stream_index The stream index that the timestamp is relative to.
        /// If stream_index is (-1) the timestamp should be in AV_TIME_BASE
        /// units from the beginning of the presentation.
        /// If a stream_index >= 0 is used and the protocol does not support
        /// seeking based on component streams, the call will fail.
        /// @param timestamp timestamp in AVStream.time_base units
        /// or if there is no stream specified then in AV_TIME_BASE units.
        /// @param flags Optional combination of AVSEEK_FLAG_BACKWARD,
        /// AVSEEK_FLAG_BYTE
        /// and AVSEEK_FLAG_ANY. The protocol may silently ignore
        /// AVSEEK_FLAG_BACKWARD and AVSEEK_FLAG_ANY, but AVSEEK_FLAG_BYTE will
        /// fail if used and not supported.
        /// @return >= 0 on success
        /// @see AVInputFormat::read_seek
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport("avformat-if-55.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="avio_seek_time")]
        internal static extern long avio_seek_time(AVIOContext* h, int stream_index, long timestamp, int flags);
    }
}
