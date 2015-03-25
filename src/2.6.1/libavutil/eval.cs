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
        public unsafe partial struct AVExpr
        {
        }

        /// <summary>
        /// Parse and evaluate an expression.
        /// Note, this is significantly slower than av_expr_eval().
        /// </summary>
        /// <param name="res">
        /// a pointer to a double where is put the result value of
        /// the expression, or NAN in case of error
        /// </param>
        /// <param name="s">
        /// expression as a zero terminated string, for example
        /// "1+2^3+5*5+sin(2/3)"
        /// </param>
        /// <param name="const_names">
        /// NULL terminated array of zero terminated strings of constant
        /// identifiers, for example {"PI", "E", 0}
        /// </param>
        /// <param name="const_values">
        /// a zero terminated array of values for the identifiers from const_names
        /// </param>
        /// <param name="func1_names">
        /// NULL terminated array of zero terminated strings of funcs1 identifiers
        /// </param>
        /// <param name="funcs1">
        /// NULL terminated array of function pointers for functions which take 1
        /// argument
        /// </param>
        /// <param name="func2_names">
        /// NULL terminated array of zero terminated strings of funcs2 identifiers
        /// </param>
        /// <param name="funcs2">
        /// NULL terminated array of function pointers for functions which take 2
        /// arguments
        /// </param>
        /// <param name="opaque">
        /// a pointer which will be passed to all functions from funcs1 and funcs2
        /// </param>
        /// <param name="log_ctx">
        /// parent logging context
        /// </param>
        /// <returns>
        /// >= 0 in case of success, a negative value corresponding to an
        /// AVERROR code otherwise
        /// </returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_expr_parse_and_eval")]
        public static extern int av_expr_parse_and_eval(double* res, string s, sbyte** const_names, double* const_values, sbyte** func1_names, global::System.IntPtr* funcs1, sbyte** func2_names, global::System.IntPtr* funcs2, void* opaque, int log_offset, void* log_ctx);

        /// <summary>
        /// Parse and evaluate an expression.
        /// Note, this is significantly slower than av_expr_eval().
        /// </summary>
        /// <param name="res">
        /// a pointer to a double where is put the result value of
        /// the expression, or NAN in case of error
        /// </param>
        /// <param name="s">
        /// expression as a zero terminated string, for example
        /// "1+2^3+5*5+sin(2/3)"
        /// </param>
        /// <param name="const_names">
        /// NULL terminated array of zero terminated strings of constant
        /// identifiers, for example {"PI", "E", 0}
        /// </param>
        /// <param name="const_values">
        /// a zero terminated array of values for the identifiers from const_names
        /// </param>
        /// <param name="func1_names">
        /// NULL terminated array of zero terminated strings of funcs1 identifiers
        /// </param>
        /// <param name="funcs1">
        /// NULL terminated array of function pointers for functions which take 1
        /// argument
        /// </param>
        /// <param name="func2_names">
        /// NULL terminated array of zero terminated strings of funcs2 identifiers
        /// </param>
        /// <param name="funcs2">
        /// NULL terminated array of function pointers for functions which take 2
        /// arguments
        /// </param>
        /// <param name="opaque">
        /// a pointer which will be passed to all functions from funcs1 and funcs2
        /// </param>
        /// <param name="log_ctx">
        /// parent logging context
        /// </param>
        /// <returns>
        /// >= 0 in case of success, a negative value corresponding to an
        /// AVERROR code otherwise
        /// </returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_expr_parse_and_eval")]
        public static extern int av_expr_parse_and_eval(double* res, string s, ref string const_names, double* const_values, ref string func1_names, ref global::System.IntPtr funcs1, ref string func2_names, ref global::System.IntPtr funcs2, void* opaque, int log_offset, void* log_ctx);

        /// <summary>
        /// Parse an expression.
        /// </summary>
        /// <param name="expr">
        /// a pointer where is put an AVExpr containing the parsed
        /// value in case of successful parsing, or NULL otherwise.
        /// The pointed to AVExpr must be freed with av_expr_free() by the user
        /// when it is not needed anymore.
        /// </param>
        /// <param name="s">
        /// expression as a zero terminated string, for example
        /// "1+2^3+5*5+sin(2/3)"
        /// </param>
        /// <param name="const_names">
        /// NULL terminated array of zero terminated strings of constant
        /// identifiers, for example {"PI", "E", 0}
        /// </param>
        /// <param name="func1_names">
        /// NULL terminated array of zero terminated strings of funcs1 identifiers
        /// </param>
        /// <param name="funcs1">
        /// NULL terminated array of function pointers for functions which take 1
        /// argument
        /// </param>
        /// <param name="func2_names">
        /// NULL terminated array of zero terminated strings of funcs2 identifiers
        /// </param>
        /// <param name="funcs2">
        /// NULL terminated array of function pointers for functions which take 2
        /// arguments
        /// </param>
        /// <param name="log_ctx">
        /// parent logging context
        /// </param>
        /// <returns>
        /// >= 0 in case of success, a negative value corresponding to an
        /// AVERROR code otherwise
        /// </returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_expr_parse")]
        public static extern int av_expr_parse(libavutil.AVExpr** expr, string s, sbyte** const_names, sbyte** func1_names, global::System.IntPtr* funcs1, sbyte** func2_names, global::System.IntPtr* funcs2, int log_offset, void* log_ctx);

        /// <summary>
        /// Parse an expression.
        /// </summary>
        /// <param name="expr">
        /// a pointer where is put an AVExpr containing the parsed
        /// value in case of successful parsing, or NULL otherwise.
        /// The pointed to AVExpr must be freed with av_expr_free() by the user
        /// when it is not needed anymore.
        /// </param>
        /// <param name="s">
        /// expression as a zero terminated string, for example
        /// "1+2^3+5*5+sin(2/3)"
        /// </param>
        /// <param name="const_names">
        /// NULL terminated array of zero terminated strings of constant
        /// identifiers, for example {"PI", "E", 0}
        /// </param>
        /// <param name="func1_names">
        /// NULL terminated array of zero terminated strings of funcs1 identifiers
        /// </param>
        /// <param name="funcs1">
        /// NULL terminated array of function pointers for functions which take 1
        /// argument
        /// </param>
        /// <param name="func2_names">
        /// NULL terminated array of zero terminated strings of funcs2 identifiers
        /// </param>
        /// <param name="funcs2">
        /// NULL terminated array of function pointers for functions which take 2
        /// arguments
        /// </param>
        /// <param name="log_ctx">
        /// parent logging context
        /// </param>
        /// <returns>
        /// >= 0 in case of success, a negative value corresponding to an
        /// AVERROR code otherwise
        /// </returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_expr_parse")]
        public static extern int av_expr_parse(ref libavutil.AVExpr* expr, string s, ref string const_names, ref string func1_names, ref global::System.IntPtr funcs1, ref string func2_names, ref global::System.IntPtr funcs2, int log_offset, void* log_ctx);

        /// <summary>
        /// Evaluate a previously parsed expression.
        /// </summary>
        /// <param name="const_values">
        /// a zero terminated array of values for the identifiers from
        /// av_expr_parse() const_names
        /// </param>
        /// <param name="opaque">
        /// a pointer which will be passed to all functions from funcs1 and funcs2
        /// </param>
        /// <returns>
        /// the value of the expression
        /// </returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_expr_eval")]
        public static extern double av_expr_eval(libavutil.AVExpr* e, double* const_values, void* opaque);

        /// <summary>
        /// Free a parsed expression previously created with av_expr_parse().
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_expr_free")]
        public static extern void av_expr_free(libavutil.AVExpr* e);

        /// <summary>
        /// Parse the string in numstr and return its value as a double. If
        /// the string is empty, contains only whitespaces, or does not contain
        /// an initial substring that has the expected syntax for a
        /// floating-point number, no conversion is performed. In this case,
        /// returns a value of zero and the value returned in tail is the value
        /// of numstr.
        /// </summary>
        /// <param name="numstr">
        /// a string representing a number, may contain one of
        /// the International System number postfixes, for example 'K', 'M',
        /// 'G'. If 'i' is appended after the postfix, powers of 2 are used
        /// instead of powers of 10. The 'B' postfix multiplies the value for
        /// 8, and can be appended after another postfix or used alone. This
        /// allows using for example 'KB', 'MiB', 'G' and 'B' as postfix.
        /// </param>
        /// <param name="tail">
        /// if non-NULL puts here the pointer to the char next
        /// after the last parsed character
        /// </param>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_strtod")]
        public static extern double av_strtod(string numstr, sbyte** tail);

        /// <summary>
        /// Parse the string in numstr and return its value as a double. If
        /// the string is empty, contains only whitespaces, or does not contain
        /// an initial substring that has the expected syntax for a
        /// floating-point number, no conversion is performed. In this case,
        /// returns a value of zero and the value returned in tail is the value
        /// of numstr.
        /// </summary>
        /// <param name="numstr">
        /// a string representing a number, may contain one of
        /// the International System number postfixes, for example 'K', 'M',
        /// 'G'. If 'i' is appended after the postfix, powers of 2 are used
        /// instead of powers of 10. The 'B' postfix multiplies the value for
        /// 8, and can be appended after another postfix or used alone. This
        /// allows using for example 'KB', 'MiB', 'G' and 'B' as postfix.
        /// </param>
        /// <param name="tail">
        /// if non-NULL puts here the pointer to the char next
        /// after the last parsed character
        /// </param>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_strtod")]
        public static extern double av_strtod(string numstr, ref System.Text.StringBuilder tail);
    }
}
