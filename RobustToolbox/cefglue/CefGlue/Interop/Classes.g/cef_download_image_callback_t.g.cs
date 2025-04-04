﻿//
// DO NOT MODIFY! THIS IS AUTOGENERATED FILE!
//
namespace Xilium.CefGlue.Interop
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Runtime.InteropServices;
    using System.Security;
    
    [StructLayout(LayoutKind.Sequential, Pack = libcef.ALIGN)]
    [SuppressMessage("Microsoft.Design", "CA1049:TypesThatOwnNativeResourcesShouldBeDisposable")]
    internal unsafe struct cef_download_image_callback_t
    {
        internal cef_base_ref_counted_t _base;
        internal delegate* unmanaged<cef_download_image_callback_t*, cef_string_t*, int, cef_image_t*, void> _on_download_image_finished;
        
        internal GCHandle _obj;
        
        [UnmanagedCallersOnly]
        public static void add_ref(cef_download_image_callback_t* self)
        {
            var obj = (CefDownloadImageCallback)self->_obj.Target;
            obj.add_ref(self);
        }
        
        [UnmanagedCallersOnly]
        public static int release(cef_download_image_callback_t* self)
        {
            var obj = (CefDownloadImageCallback)self->_obj.Target;
            return obj.release(self);
        }
        
        [UnmanagedCallersOnly]
        public static int has_one_ref(cef_download_image_callback_t* self)
        {
            var obj = (CefDownloadImageCallback)self->_obj.Target;
            return obj.has_one_ref(self);
        }
        
        [UnmanagedCallersOnly]
        public static int has_at_least_one_ref(cef_download_image_callback_t* self)
        {
            var obj = (CefDownloadImageCallback)self->_obj.Target;
            return obj.has_at_least_one_ref(self);
        }
        
        [UnmanagedCallersOnly]
        public static void on_download_image_finished(cef_download_image_callback_t* self, cef_string_t* image_url, int http_status_code, cef_image_t* image)
        {
            var obj = (CefDownloadImageCallback)self->_obj.Target;
            obj.on_download_image_finished(self, image_url, http_status_code, image);
        }
        
        internal static cef_download_image_callback_t* Alloc()
        {
            var ptr = (cef_download_image_callback_t*)NativeMemory.Alloc((UIntPtr)sizeof(cef_download_image_callback_t));
            *ptr = default(cef_download_image_callback_t);
            ptr->_base._size = (UIntPtr)sizeof(cef_download_image_callback_t);
            ptr->_base._add_ref = (delegate* unmanaged<cef_base_ref_counted_t*, void>)(delegate* unmanaged<cef_download_image_callback_t*, void>)&add_ref;
            ptr->_base._release = (delegate* unmanaged<cef_base_ref_counted_t*, int>)(delegate* unmanaged<cef_download_image_callback_t*, int>)&release;
            ptr->_base._has_one_ref = (delegate* unmanaged<cef_base_ref_counted_t*, int>)(delegate* unmanaged<cef_download_image_callback_t*, int>)&has_one_ref;
            ptr->_base._has_at_least_one_ref = (delegate* unmanaged<cef_base_ref_counted_t*, int>)(delegate* unmanaged<cef_download_image_callback_t*, int>)&has_at_least_one_ref;
            ptr->_on_download_image_finished = &on_download_image_finished;
            return ptr;
        }
        
        internal static void Free(cef_download_image_callback_t* ptr)
        {
            NativeMemory.Free((void*)ptr);
        }
        
    }
}
