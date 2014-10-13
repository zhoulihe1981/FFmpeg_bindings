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
        /// <summary>
        /// Allocate a block of size bytes with alignment suitable for all
        /// memory accesses (including vectors if available on the CPU).
        /// </summary>
        /// <param name="size">
        /// Size in bytes for the memory block to be allocated.
        /// </param>
        /// <returns>
        /// Pointer to the allocated block, NULL if the block cannot
        /// be allocated.
        /// @see av_mallocz()
        /// </returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_malloc")]
        public static extern void* av_malloc(global::System.UIntPtr size);

        /// <summary>
        /// Allocate a block of size * nmemb bytes with av_malloc().
        /// </summary>
        /// <param name="nmemb">
        /// Number of elements
        /// </param>
        /// <param name="size">
        /// Size of the single element
        /// </param>
        /// <returns>
        /// Pointer to the allocated block, NULL if the block cannot
        /// be allocated.
        /// @see av_malloc()
        /// </returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_malloc_array")]
        public static extern void* av_malloc_array(global::System.UIntPtr nmemb, global::System.UIntPtr size);

        /// <summary>
        /// Allocate or reallocate a block of memory.
        /// If ptr is NULL and size > 0, allocate a new block. If
        /// size is zero, free the memory block pointed to by ptr.
        /// </summary>
        /// <param name="ptr">
        /// Pointer to a memory block already allocated with
        /// av_realloc() or NULL.
        /// </param>
        /// <param name="size">
        /// Size in bytes of the memory block to be allocated or
        /// reallocated.
        /// </param>
        /// <returns>
        /// Pointer to a newly-reallocated block or NULL if the block
        /// cannot be reallocated or the function is used to free the memory block.
        /// @warning Pointers originating from the av_malloc() family of functions
        /// must
        /// not be passed to av_realloc(). The former can be implemented using
        /// memalign() (or other functions), and there is no guarantee that
        /// pointers from such functions can be passed to realloc() at all.
        /// The situation is undefined according to POSIX and may crash with
        /// some libc implementations.
        /// @see av_fast_realloc()
        /// </returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_realloc")]
        public static extern void* av_realloc(void* ptr, global::System.UIntPtr size);

        /// <summary>
        /// Allocate or reallocate a block of memory.
        /// This function does the same thing as av_realloc, except:
        /// - It takes two arguments and checks the result of the multiplication
        /// for
        /// integer overflow.
        /// - It frees the input block in case of failure, thus avoiding the memory
        /// leak with the classic "buf = realloc(buf); if (!buf) return -1;".
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_realloc_f")]
        public static extern void* av_realloc_f(void* ptr, global::System.UIntPtr nelem, global::System.UIntPtr elsize);

        /// <summary>
        /// Allocate or reallocate a block of memory.
        /// If *ptr is NULL and size > 0, allocate a new block. If
        /// size is zero, free the memory block pointed to by ptr.
        /// </summary>
        /// <param name="ptr">
        /// Pointer to a pointer to a memory block already allocated
        /// with av_realloc(), or pointer to a pointer to NULL.
        /// The pointer is updated on success, or freed on failure.
        /// </param>
        /// <param name="size">
        /// Size in bytes for the memory block to be allocated or
        /// reallocated
        /// </param>
        /// <returns>
        /// Zero on success, an AVERROR error code on failure.
        /// @warning Pointers originating from the av_malloc() family of functions
        /// must
        /// not be passed to av_reallocp(). The former can be implemented using
        /// memalign() (or other functions), and there is no guarantee that
        /// pointers from such functions can be passed to realloc() at all.
        /// The situation is undefined according to POSIX and may crash with
        /// some libc implementations.
        /// </returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_reallocp")]
        public static extern int av_reallocp(void* ptr, global::System.UIntPtr size);

        /// <summary>
        /// Allocate or reallocate an array.
        /// If ptr is NULL and nmemb > 0, allocate a new block. If
        /// nmemb is zero, free the memory block pointed to by ptr.
        /// </summary>
        /// <param name="ptr">
        /// Pointer to a memory block already allocated with
        /// av_realloc() or NULL.
        /// </param>
        /// <param name="nmemb">
        /// Number of elements
        /// </param>
        /// <param name="size">
        /// Size of the single element
        /// </param>
        /// <returns>
        /// Pointer to a newly-reallocated block or NULL if the block
        /// cannot be reallocated or the function is used to free the memory block.
        /// @warning Pointers originating from the av_malloc() family of functions
        /// must
        /// not be passed to av_realloc(). The former can be implemented using
        /// memalign() (or other functions), and there is no guarantee that
        /// pointers from such functions can be passed to realloc() at all.
        /// The situation is undefined according to POSIX and may crash with
        /// some libc implementations.
        /// </returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_realloc_array")]
        public static extern void* av_realloc_array(void* ptr, global::System.UIntPtr nmemb, global::System.UIntPtr size);

        /// <summary>
        /// Allocate or reallocate an array through a pointer to a pointer.
        /// If *ptr is NULL and nmemb > 0, allocate a new block. If
        /// nmemb is zero, free the memory block pointed to by ptr.
        /// </summary>
        /// <param name="ptr">
        /// Pointer to a pointer to a memory block already allocated
        /// with av_realloc(), or pointer to a pointer to NULL.
        /// The pointer is updated on success, or freed on failure.
        /// </param>
        /// <param name="nmemb">
        /// Number of elements
        /// </param>
        /// <param name="size">
        /// Size of the single element
        /// </param>
        /// <returns>
        /// Zero on success, an AVERROR error code on failure.
        /// @warning Pointers originating from the av_malloc() family of functions
        /// must
        /// not be passed to av_realloc(). The former can be implemented using
        /// memalign() (or other functions), and there is no guarantee that
        /// pointers from such functions can be passed to realloc() at all.
        /// The situation is undefined according to POSIX and may crash with
        /// some libc implementations.
        /// </returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_reallocp_array")]
        public static extern int av_reallocp_array(void* ptr, global::System.UIntPtr nmemb, global::System.UIntPtr size);

        /// <summary>
        /// Free a memory block which has been allocated with av_malloc(z)() or
        /// av_realloc().
        /// </summary>
        /// <param name="ptr">
        /// Pointer to the memory block which should be freed.
        /// </param>
        /// <remark>
        /// ptr = NULL is explicitly allowed.
        /// </remark>
        /// <remark>
        /// It is recommended that you use av_freep() instead.
        /// @see av_freep()
        /// </remark>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_free")]
        public static extern void av_free(void* ptr);

        /// <summary>
        /// Allocate a block of size bytes with alignment suitable for all
        /// memory accesses (including vectors if available on the CPU) and
        /// zero all the bytes of the block.
        /// </summary>
        /// <param name="size">
        /// Size in bytes for the memory block to be allocated.
        /// </param>
        /// <returns>
        /// Pointer to the allocated block, NULL if it cannot be allocated.
        /// @see av_malloc()
        /// </returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_mallocz")]
        public static extern void* av_mallocz(global::System.UIntPtr size);

        /// <summary>
        /// Allocate a block of nmemb * size bytes with alignment suitable for all
        /// memory accesses (including vectors if available on the CPU) and
        /// zero all the bytes of the block.
        /// The allocation will fail if nmemb * size is greater than or equal
        /// to INT_MAX.
        /// </summary>
        /// <param name="nmemb">
        /// 
        /// </param>
        /// <param name="size">
        /// 
        /// </param>
        /// <returns>
        /// Pointer to the allocated block, NULL if it cannot be allocated.
        /// </returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_calloc")]
        public static extern void* av_calloc(global::System.UIntPtr nmemb, global::System.UIntPtr size);

        /// <summary>
        /// Allocate a block of size * nmemb bytes with av_mallocz().
        /// </summary>
        /// <param name="nmemb">
        /// Number of elements
        /// </param>
        /// <param name="size">
        /// Size of the single element
        /// </param>
        /// <returns>
        /// Pointer to the allocated block, NULL if the block cannot
        /// be allocated.
        /// @see av_mallocz()
        /// @see av_malloc_array()
        /// </returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_mallocz_array")]
        public static extern void* av_mallocz_array(global::System.UIntPtr nmemb, global::System.UIntPtr size);

        /// <summary>
        /// Duplicate the string s.
        /// </summary>
        /// <param name="s">
        /// string to be duplicated
        /// </param>
        /// <returns>
        /// Pointer to a newly-allocated string containing a
        /// copy of s or NULL if the string cannot be allocated.
        /// </returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_strdup")]
        public static extern sbyte* av_strdup(string s);

        /// <summary>
        /// Duplicate a substring of the string s.
        /// </summary>
        /// <param name="s">
        /// string to be duplicated
        /// </param>
        /// <param name="len">
        /// the maximum length of the resulting string (not counting the
        /// terminating byte).
        /// </param>
        /// <returns>
        /// Pointer to a newly-allocated string containing a
        /// copy of s or NULL if the string cannot be allocated.
        /// </returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_strndup")]
        public static extern sbyte* av_strndup(string s, global::System.UIntPtr len);

        /// <summary>
        /// Duplicate the buffer p.
        /// </summary>
        /// <param name="p">
        /// buffer to be duplicated
        /// </param>
        /// <returns>
        /// Pointer to a newly allocated buffer containing a
        /// copy of p or NULL if the buffer cannot be allocated.
        /// </returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_memdup")]
        public static extern void* av_memdup(void* p, global::System.UIntPtr size);

        /// <summary>
        /// Free a memory block which has been allocated with av_malloc(z)() or
        /// av_realloc() and set the pointer pointing to it to NULL.
        /// </summary>
        /// <param name="ptr">
        /// Pointer to the pointer to the memory block which should
        /// be freed.
        /// </param>
        /// <remark>
        /// passing a pointer to a NULL pointer is safe and leads to no action.
        /// @see av_free()
        /// </remark>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_freep")]
        public static extern void av_freep(void* ptr);

        /// <summary>
        /// Add an element to a dynamic array.
        /// 
        /// The array to grow is supposed to be an array of pointers to
        /// structures, and the element to add must be a pointer to an already
        /// allocated structure.
        /// 
        /// The array is reallocated when its size reaches powers of 2.
        /// Therefore, the amortized cost of adding an element is constant.
        /// 
        /// In case of success, the pointer to the array is updated in order to
        /// point to the new grown array, and the number pointed to by nb_ptr
        /// is incremented.
        /// In case of failure, the array is freed, *tab_ptr is set to NULL and
        /// nb_ptr is set to 0.
        /// </summary>
        /// <param name="tab_ptr">
        /// pointer to the array to grow
        /// </param>
        /// <param name="nb_ptr">
        /// pointer to the number of elements in the array
        /// </param>
        /// <param name="elem">
        /// element to add
        /// @see av_dynarray_add_nofree(), av_dynarray2_add()
        /// </param>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_dynarray_add")]
        public static extern void av_dynarray_add(void* tab_ptr, int* nb_ptr, void* elem);

        /// <summary>
        /// Add an element to a dynamic array.
        /// 
        /// Function has the same functionality as av_dynarray_add(),
        /// but it doesn't free memory on fails. It returns error code
        /// instead and leave current buffer untouched.
        /// </summary>
        /// <param name="tab_ptr">
        /// pointer to the array to grow
        /// </param>
        /// <param name="nb_ptr">
        /// pointer to the number of elements in the array
        /// </param>
        /// <param name="elem">
        /// element to add
        /// </param>
        /// <returns>
        /// >=0 on success, negative otherwise.
        /// @see av_dynarray_add(), av_dynarray2_add()
        /// </returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_dynarray_add_nofree")]
        public static extern int av_dynarray_add_nofree(void* tab_ptr, int* nb_ptr, void* elem);

        /// <summary>
        /// Add an element of size elem_size to a dynamic array.
        /// 
        /// The array is reallocated when its number of elements reaches powers of
        /// 2.
        /// Therefore, the amortized cost of adding an element is constant.
        /// 
        /// In case of success, the pointer to the array is updated in order to
        /// point to the new grown array, and the number pointed to by nb_ptr
        /// is incremented.
        /// In case of failure, the array is freed, *tab_ptr is set to NULL and
        /// nb_ptr is set to 0.
        /// </summary>
        /// <param name="tab_ptr">
        /// pointer to the array to grow
        /// </param>
        /// <param name="nb_ptr">
        /// pointer to the number of elements in the array
        /// </param>
        /// <param name="elem_size">
        /// size in bytes of the elements in the array
        /// </param>
        /// <param name="elem_data">
        /// pointer to the data of the element to add. If NULL, the space of
        /// the new added element is not filled.
        /// </param>
        /// <returns>
        /// pointer to the data of the element to copy in the new allocated space.
        /// If NULL, the new allocated space is left uninitialized."
        /// @see av_dynarray_add(), av_dynarray_add_nofree()
        /// </returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_dynarray2_add")]
        public static extern void* av_dynarray2_add(void** tab_ptr, int* nb_ptr, global::System.UIntPtr elem_size, byte* elem_data);

        /// <summary>
        /// Add an element of size elem_size to a dynamic array.
        /// 
        /// The array is reallocated when its number of elements reaches powers of
        /// 2.
        /// Therefore, the amortized cost of adding an element is constant.
        /// 
        /// In case of success, the pointer to the array is updated in order to
        /// point to the new grown array, and the number pointed to by nb_ptr
        /// is incremented.
        /// In case of failure, the array is freed, *tab_ptr is set to NULL and
        /// nb_ptr is set to 0.
        /// </summary>
        /// <param name="tab_ptr">
        /// pointer to the array to grow
        /// </param>
        /// <param name="nb_ptr">
        /// pointer to the number of elements in the array
        /// </param>
        /// <param name="elem_size">
        /// size in bytes of the elements in the array
        /// </param>
        /// <param name="elem_data">
        /// pointer to the data of the element to add. If NULL, the space of
        /// the new added element is not filled.
        /// </param>
        /// <returns>
        /// pointer to the data of the element to copy in the new allocated space.
        /// If NULL, the new allocated space is left uninitialized."
        /// @see av_dynarray_add(), av_dynarray_add_nofree()
        /// </returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_dynarray2_add")]
        public static extern void* av_dynarray2_add(ref void* tab_ptr, int* nb_ptr, global::System.UIntPtr elem_size, byte* elem_data);

        /// <summary>
        /// Multiply two size_t values checking for overflow.
        /// </summary>
        /// <returns>
        /// 0 if success, AVERROR(EINVAL) if overflow.
        /// </returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_size_mult")]
        public static extern int av_size_mult(global::System.UIntPtr a, global::System.UIntPtr b, global::System.UIntPtr* r);

        /// <summary>
        /// Set the maximum size that may me allocated in one block.
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_max_alloc")]
        public static extern void av_max_alloc(global::System.UIntPtr max);

        /// <summary>
        /// deliberately overlapping memcpy implementation
        /// </summary>
        /// <param name="dst">
        /// destination buffer
        /// </param>
        /// <param name="back">
        /// how many bytes back we start (the initial size of the overlapping
        /// window), must be > 0
        /// </param>
        /// <param name="cnt">
        /// number of bytes to copy, must be >= 0
        /// 
        /// cnt > back is valid, this will copy the bytes we just copied,
        /// thus creating a repeating pattern with a period length of back.
        /// </param>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_memcpy_backptr")]
        public static extern void av_memcpy_backptr(byte* dst, int back, int cnt);

        /// <summary>
        /// Reallocate the given block if it is not large enough, otherwise do
        /// nothing.
        /// 
        /// @see av_realloc
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_fast_realloc")]
        public static extern void* av_fast_realloc(void* ptr, uint* size, global::System.UIntPtr min_size);

        /// <summary>
        /// Allocate a buffer, reusing the given one if large enough.
        /// 
        /// Contrary to av_fast_realloc the current buffer contents might not be
        /// preserved and on error the old buffer is freed, thus no special
        /// handling to avoid memleaks is necessary.
        /// </summary>
        /// <param name="ptr">
        /// pointer to pointer to already allocated buffer, overwritten with
        /// pointer to new buffer
        /// </param>
        /// <param name="size">
        /// size of the buffer *ptr points to
        /// </param>
        /// <param name="min_size">
        /// minimum size of *ptr buffer after returning, *ptr will be NULL and
        /// size 0 if an error occurred.
        /// </param>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_fast_malloc")]
        public static extern void av_fast_malloc(void* ptr, uint* size, global::System.UIntPtr min_size);
    }
}
