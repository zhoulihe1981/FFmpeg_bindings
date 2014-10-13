//----------------------------------------------------------------------------
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
//----------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;
using System.Security;

namespace FFmpeg
{
    public unsafe static partial class libavdevice
    {
        /// <summary>
        /// Message types used by avdevice_app_to_dev_control_message().
        /// </summary>
        public enum AVAppToDevMessageType
        {
            /// <summary>Dummy message.</summary>
            AV_APP_TO_DEV_NONE = 1313820229,
            /// <summary>Window size change message.</summary>
            AV_APP_TO_DEV_WINDOW_SIZE = 1195724621,
            /// <summary>Repaint request message.</summary>
            AV_APP_TO_DEV_WINDOW_REPAINT = 1380274241,
            /// <summary>Request pause/play.</summary>
            AV_APP_TO_DEV_PAUSE = 1346458912,
            /// <summary>Request pause/play.</summary>
            AV_APP_TO_DEV_PLAY = 1347174745,
            /// <summary>Request pause/play.</summary>
            AV_APP_TO_DEV_TOGGLE_PAUSE = 1346458964,
            /// <summary>Volume control message.</summary>
            AV_APP_TO_DEV_SET_VOLUME = 1398165324,
            /// <summary>Mute control messages.</summary>
            AV_APP_TO_DEV_MUTE = 541939028,
            /// <summary>Mute control messages.</summary>
            AV_APP_TO_DEV_UNMUTE = 1431131476,
            /// <summary>Mute control messages.</summary>
            AV_APP_TO_DEV_TOGGLE_MUTE = 1414354260,
            /// <summary>Get volume/mute messages.</summary>
            AV_APP_TO_DEV_GET_VOLUME = 1196838732,
            /// <summary>Get volume/mute messages.</summary>
            AV_APP_TO_DEV_GET_MUTE = 1196250452
        }

        /// <summary>
        /// Message types used by avdevice_dev_to_app_control_message().
        /// </summary>
        public enum AVDevToAppMessageType
        {
            /// <summary>Dummy message.</summary>
            AV_DEV_TO_APP_NONE = 1313820229,
            /// <summary>Create window buffer message.</summary>
            AV_DEV_TO_APP_CREATE_WINDOW_BUFFER = 1111708229,
            /// <summary>Prepare window buffer message.</summary>
            AV_DEV_TO_APP_PREPARE_WINDOW_BUFFER = 1112560197,
            /// <summary>Display window buffer message.</summary>
            AV_DEV_TO_APP_DISPLAY_WINDOW_BUFFER = 1111771475,
            /// <summary>Destroy window buffer message.</summary>
            AV_DEV_TO_APP_DESTROY_WINDOW_BUFFER = 1111770451,
            /// <summary>Buffer fullness status messages.</summary>
            AV_DEV_TO_APP_BUFFER_OVERFLOW = 1112491596,
            /// <summary>Buffer fullness status messages.</summary>
            AV_DEV_TO_APP_BUFFER_UNDERFLOW = 1112884812,
            /// <summary>Buffer readable/writable.</summary>
            AV_DEV_TO_APP_BUFFER_READABLE = 1112687648,
            /// <summary>Buffer readable/writable.</summary>
            AV_DEV_TO_APP_BUFFER_WRITABLE = 1113018912,
            /// <summary>Mute state change message.</summary>
            AV_DEV_TO_APP_MUTE_STATE_CHANGED = 1129141588,
            /// <summary>Volume level change message.</summary>
            AV_DEV_TO_APP_VOLUME_LEVEL_CHANGED = 1129729868
        }

        [StructLayout(LayoutKind.Sequential)]
        public unsafe partial struct AVDeviceRect
        {
            /// <summary>
            /// x coordinate of top left corner
            /// </summary>
            public int x;

            /// <summary>
            /// y coordinate of top left corner
            /// </summary>
            public int y;

            /// <summary>
            /// width
            /// </summary>
            public int width;

            /// <summary>
            /// height
            /// </summary>
            public int height;
        }

        /// <summary>
        /// Structure describes device capabilities.
        /// 
        /// It is used by devices in conjunction with av_device_capabilities
        /// AVOption table
        /// to implement capabilities probing API based on AVOption API. Should not
        /// be used directly.
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public unsafe partial struct AVDeviceCapabilitiesQuery
        {
            public libavutil.AVClass* av_class;

            public libavformat.AVFormatContext* device_context;

            public libavcodec.AVCodecID codec;

            public libavutil.AVSampleFormat sample_format;

            public libavutil.AVPixelFormat pixel_format;

            public int sample_rate;

            public int channels;

            public long channel_layout;

            public int window_width;

            public int window_height;

            public int frame_width;

            public int frame_height;

            public libavutil.AVRational fps;
        }

        /// <summary>
        /// Structure describes basic parameters of the device.
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public unsafe partial struct AVDeviceInfo
        {
            /// <summary>
            /// device name, format depends on device
            /// </summary>
            public sbyte* device_name;

            /// <summary>
            /// human friendly name
            /// </summary>
            public sbyte* device_description;
        }

        /// <summary>
        /// List of devices.
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public unsafe partial struct AVDeviceInfoList
        {
            /// <summary>
            /// list of autodetected devices
            /// </summary>
            public libavdevice.AVDeviceInfo** devices;

            /// <summary>
            /// number of autodetected devices
            /// </summary>
            public int nb_devices;

            /// <summary>
            /// index of default device or -1 if no default
            /// </summary>
            public int default_device;
        }

        /// <summary>
        /// Return the LIBAVDEVICE_VERSION_INT constant.
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVDEVICE_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="avdevice_version")]
        public static extern uint avdevice_version();

        /// <summary>
        /// Return the libavdevice build-time configuration.
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVDEVICE_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="avdevice_configuration")]
        public static extern sbyte* avdevice_configuration();

        /// <summary>
        /// Return the libavdevice license.
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVDEVICE_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="avdevice_license")]
        public static extern sbyte* avdevice_license();

        /// <summary>
        /// Initialize libavdevice and register all the input and output devices.
        /// @warning This function is not thread safe.
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVDEVICE_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="avdevice_register_all")]
        public static extern void avdevice_register_all();

        /// <summary>
        /// Audio input devices iterator.
        /// 
        /// If d is NULL, returns the first registered input audio/video device,
        /// if d is non-NULL, returns the next registered input audio/video device
        /// after d
        /// or NULL if d is the last one.
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVDEVICE_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_input_audio_device_next")]
        public static extern libavformat.AVInputFormat* av_input_audio_device_next(libavformat.AVInputFormat* d);

        /// <summary>
        /// Video input devices iterator.
        /// 
        /// If d is NULL, returns the first registered input audio/video device,
        /// if d is non-NULL, returns the next registered input audio/video device
        /// after d
        /// or NULL if d is the last one.
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVDEVICE_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_input_video_device_next")]
        public static extern libavformat.AVInputFormat* av_input_video_device_next(libavformat.AVInputFormat* d);

        /// <summary>
        /// Audio output devices iterator.
        /// 
        /// If d is NULL, returns the first registered output audio/video device,
        /// if d is non-NULL, returns the next registered output audio/video device
        /// after d
        /// or NULL if d is the last one.
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVDEVICE_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_output_audio_device_next")]
        public static extern libavformat.AVOutputFormat* av_output_audio_device_next(libavformat.AVOutputFormat* d);

        /// <summary>
        /// Video output devices iterator.
        /// 
        /// If d is NULL, returns the first registered output audio/video device,
        /// if d is non-NULL, returns the next registered output audio/video device
        /// after d
        /// or NULL if d is the last one.
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVDEVICE_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_output_video_device_next")]
        public static extern libavformat.AVOutputFormat* av_output_video_device_next(libavformat.AVOutputFormat* d);

        /// <summary>
        /// Send control message from application to device.
        /// </summary>
        /// <param name="s">
        /// device context.
        /// </param>
        /// <param name="type">
        /// message type.
        /// </param>
        /// <param name="data">
        /// message data. Exact type depends on message type.
        /// </param>
        /// <param name="data_size">
        /// size of message data.
        /// </param>
        /// <returns>
        /// >= 0 on success, negative on error.
        /// AVERROR(ENOSYS) when device doesn't implement handler of the message.
        /// </returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVDEVICE_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="avdevice_app_to_dev_control_message")]
        public static extern int avdevice_app_to_dev_control_message(libavformat.AVFormatContext* s, libavdevice.AVAppToDevMessageType type, void* data, global::System.UIntPtr data_size);

        /// <summary>
        /// Send control message from device to application.
        /// </summary>
        /// <param name="s">
        /// device context.
        /// </param>
        /// <param name="type">
        /// message type.
        /// </param>
        /// <param name="data">
        /// message data. Can be NULL.
        /// </param>
        /// <param name="data_size">
        /// size of message data.
        /// </param>
        /// <returns>
        /// >= 0 on success, negative on error.
        /// AVERROR(ENOSYS) when application doesn't implement handler of the
        /// message.
        /// </returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVDEVICE_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="avdevice_dev_to_app_control_message")]
        public static extern int avdevice_dev_to_app_control_message(libavformat.AVFormatContext* s, libavdevice.AVDevToAppMessageType type, void* data, global::System.UIntPtr data_size);

        /// <summary>
        /// Initialize capabilities probing API based on AVOption API.
        /// 
        /// avdevice_capabilities_free() must be called when query capabilities API
        /// is
        /// not used anymore.
        /// </summary>
        /// <param name="[out]">
        /// caps      Device capabilities data. Pointer to a NULL pointer must be
        /// passed.
        /// </param>
        /// <param name="s">
        /// Context of the device.
        /// </param>
        /// <param name="device_options">
        /// An AVDictionary filled with device-private options.
        /// On return this parameter will be destroyed and replaced with a dict
        /// containing options that were not found. May be NULL.
        /// The same options must be passed later to avformat_write_header() for
        /// output
        /// devices or avformat_open_input() for input devices, or at any other
        /// place
        /// that affects device-private options.
        /// </param>
        /// <returns>
        /// >= 0 on success, negative otherwise.
        /// </returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVDEVICE_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="avdevice_capabilities_create")]
        public static extern int avdevice_capabilities_create(libavdevice.AVDeviceCapabilitiesQuery** caps, libavformat.AVFormatContext* s, libavutil.AVDictionary** device_options);

        /// <summary>
        /// Initialize capabilities probing API based on AVOption API.
        /// 
        /// avdevice_capabilities_free() must be called when query capabilities API
        /// is
        /// not used anymore.
        /// </summary>
        /// <param name="[out]">
        /// caps      Device capabilities data. Pointer to a NULL pointer must be
        /// passed.
        /// </param>
        /// <param name="s">
        /// Context of the device.
        /// </param>
        /// <param name="device_options">
        /// An AVDictionary filled with device-private options.
        /// On return this parameter will be destroyed and replaced with a dict
        /// containing options that were not found. May be NULL.
        /// The same options must be passed later to avformat_write_header() for
        /// output
        /// devices or avformat_open_input() for input devices, or at any other
        /// place
        /// that affects device-private options.
        /// </param>
        /// <returns>
        /// >= 0 on success, negative otherwise.
        /// </returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVDEVICE_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="avdevice_capabilities_create")]
        public static extern int avdevice_capabilities_create(ref libavdevice.AVDeviceCapabilitiesQuery* caps, libavformat.AVFormatContext* s, ref libavutil.AVDictionary* device_options);

        /// <summary>
        /// Free resources created by avdevice_capabilities_create()
        /// </summary>
        /// <param name="caps">
        /// Device capabilities data to be freed.
        /// </param>
        /// <param name="s">
        /// Context of the device.
        /// </param>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVDEVICE_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="avdevice_capabilities_free")]
        public static extern void avdevice_capabilities_free(libavdevice.AVDeviceCapabilitiesQuery** caps, libavformat.AVFormatContext* s);

        /// <summary>
        /// Free resources created by avdevice_capabilities_create()
        /// </summary>
        /// <param name="caps">
        /// Device capabilities data to be freed.
        /// </param>
        /// <param name="s">
        /// Context of the device.
        /// </param>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVDEVICE_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="avdevice_capabilities_free")]
        public static extern void avdevice_capabilities_free(ref libavdevice.AVDeviceCapabilitiesQuery* caps, libavformat.AVFormatContext* s);

        /// <summary>
        /// List devices.
        /// 
        /// Returns available device names and their parameters.
        /// </summary>
        /// <remark>
        /// : Some devices may accept system-dependent device names that cannot be
        /// autodetected. The list returned by this function cannot be assumed to
        /// be always completed.
        /// </remark>
        /// <param name="s">
        /// device context.
        /// </param>
        /// <param name="[out]">
        /// device_list list of autodetected devices.
        /// </param>
        /// <returns>
        /// count of autodetected devices, negative on error.
        /// </returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVDEVICE_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="avdevice_list_devices")]
        public static extern int avdevice_list_devices(libavformat.AVFormatContext* s, libavdevice.AVDeviceInfoList** device_list);

        /// <summary>
        /// List devices.
        /// 
        /// Returns available device names and their parameters.
        /// </summary>
        /// <remark>
        /// : Some devices may accept system-dependent device names that cannot be
        /// autodetected. The list returned by this function cannot be assumed to
        /// be always completed.
        /// </remark>
        /// <param name="s">
        /// device context.
        /// </param>
        /// <param name="[out]">
        /// device_list list of autodetected devices.
        /// </param>
        /// <returns>
        /// count of autodetected devices, negative on error.
        /// </returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVDEVICE_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="avdevice_list_devices")]
        public static extern int avdevice_list_devices(libavformat.AVFormatContext* s, ref libavdevice.AVDeviceInfoList* device_list);

        /// <summary>
        /// Convenient function to free result of avdevice_list_devices().
        /// </summary>
        /// <param name="devices">
        /// device list to be freed.
        /// </param>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVDEVICE_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="avdevice_free_list_devices")]
        public static extern void avdevice_free_list_devices(libavdevice.AVDeviceInfoList** device_list);

        /// <summary>
        /// Convenient function to free result of avdevice_list_devices().
        /// </summary>
        /// <param name="devices">
        /// device list to be freed.
        /// </param>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVDEVICE_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="avdevice_free_list_devices")]
        public static extern void avdevice_free_list_devices(ref libavdevice.AVDeviceInfoList* device_list);
    }
}
