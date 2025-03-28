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
    internal unsafe struct cef_resource_bundle_handler_t
    {
        internal cef_base_ref_counted_t _base;
        internal delegate* unmanaged<cef_resource_bundle_handler_t*, int, cef_string_t*, int> _get_localized_string;
        internal delegate* unmanaged<cef_resource_bundle_handler_t*, int, void**, UIntPtr*, int> _get_data_resource;
        internal delegate* unmanaged<cef_resource_bundle_handler_t*, int, CefScaleFactor, void**, UIntPtr*, int> _get_data_resource_for_scale;
        
        internal GCHandle _obj;
        
        [UnmanagedCallersOnly]
        public static void add_ref(cef_resource_bundle_handler_t* self)
        {
            var obj = (CefResourceBundleHandler)self->_obj.Target;
            obj.add_ref(self);
        }
        
        [UnmanagedCallersOnly]
        public static int release(cef_resource_bundle_handler_t* self)
        {
            var obj = (CefResourceBundleHandler)self->_obj.Target;
            return obj.release(self);
        }
        
        [UnmanagedCallersOnly]
        public static int has_one_ref(cef_resource_bundle_handler_t* self)
        {
            var obj = (CefResourceBundleHandler)self->_obj.Target;
            return obj.has_one_ref(self);
        }
        
        [UnmanagedCallersOnly]
        public static int has_at_least_one_ref(cef_resource_bundle_handler_t* self)
        {
            var obj = (CefResourceBundleHandler)self->_obj.Target;
            return obj.has_at_least_one_ref(self);
        }
        
        [UnmanagedCallersOnly]
        public static int get_localized_string(cef_resource_bundle_handler_t* self, int string_id, cef_string_t* @string)
        {
            var obj = (CefResourceBundleHandler)self->_obj.Target;
            return obj.get_localized_string(self, string_id, @string);
        }
        
        [UnmanagedCallersOnly]
        public static int get_data_resource(cef_resource_bundle_handler_t* self, int resource_id, void** data, UIntPtr* data_size)
        {
            var obj = (CefResourceBundleHandler)self->_obj.Target;
            return obj.get_data_resource(self, resource_id, data, data_size);
        }
        
        [UnmanagedCallersOnly]
        public static int get_data_resource_for_scale(cef_resource_bundle_handler_t* self, int resource_id, CefScaleFactor scale_factor, void** data, UIntPtr* data_size)
        {
            var obj = (CefResourceBundleHandler)self->_obj.Target;
            return obj.get_data_resource_for_scale(self, resource_id, scale_factor, data, data_size);
        }
        
        internal static cef_resource_bundle_handler_t* Alloc()
        {
            var ptr = (cef_resource_bundle_handler_t*)NativeMemory.Alloc((UIntPtr)sizeof(cef_resource_bundle_handler_t));
            *ptr = default(cef_resource_bundle_handler_t);
            ptr->_base._size = (UIntPtr)sizeof(cef_resource_bundle_handler_t);
            ptr->_base._add_ref = (delegate* unmanaged<cef_base_ref_counted_t*, void>)(delegate* unmanaged<cef_resource_bundle_handler_t*, void>)&add_ref;
            ptr->_base._release = (delegate* unmanaged<cef_base_ref_counted_t*, int>)(delegate* unmanaged<cef_resource_bundle_handler_t*, int>)&release;
            ptr->_base._has_one_ref = (delegate* unmanaged<cef_base_ref_counted_t*, int>)(delegate* unmanaged<cef_resource_bundle_handler_t*, int>)&has_one_ref;
            ptr->_base._has_at_least_one_ref = (delegate* unmanaged<cef_base_ref_counted_t*, int>)(delegate* unmanaged<cef_resource_bundle_handler_t*, int>)&has_at_least_one_ref;
            ptr->_get_localized_string = &get_localized_string;
            ptr->_get_data_resource = &get_data_resource;
            ptr->_get_data_resource_for_scale = &get_data_resource_for_scale;
            return ptr;
        }
        
        internal static void Free(cef_resource_bundle_handler_t* ptr)
        {
            NativeMemory.Free((void*)ptr);
        }
        
    }
}
