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
    internal unsafe struct cef_navigation_entry_visitor_t
    {
        internal cef_base_ref_counted_t _base;
        internal delegate* unmanaged<cef_navigation_entry_visitor_t*, cef_navigation_entry_t*, int, int, int, int> _visit;
        
        internal GCHandle _obj;
        
        [UnmanagedCallersOnly]
        public static void add_ref(cef_navigation_entry_visitor_t* self)
        {
            var obj = (CefNavigationEntryVisitor)self->_obj.Target;
            obj.add_ref(self);
        }
        
        [UnmanagedCallersOnly]
        public static int release(cef_navigation_entry_visitor_t* self)
        {
            var obj = (CefNavigationEntryVisitor)self->_obj.Target;
            return obj.release(self);
        }
        
        [UnmanagedCallersOnly]
        public static int has_one_ref(cef_navigation_entry_visitor_t* self)
        {
            var obj = (CefNavigationEntryVisitor)self->_obj.Target;
            return obj.has_one_ref(self);
        }
        
        [UnmanagedCallersOnly]
        public static int has_at_least_one_ref(cef_navigation_entry_visitor_t* self)
        {
            var obj = (CefNavigationEntryVisitor)self->_obj.Target;
            return obj.has_at_least_one_ref(self);
        }
        
        [UnmanagedCallersOnly]
        public static int visit(cef_navigation_entry_visitor_t* self, cef_navigation_entry_t* entry, int current, int index, int total)
        {
            var obj = (CefNavigationEntryVisitor)self->_obj.Target;
            return obj.visit(self, entry, current, index, total);
        }
        
        internal static cef_navigation_entry_visitor_t* Alloc()
        {
            var ptr = (cef_navigation_entry_visitor_t*)NativeMemory.Alloc((UIntPtr)sizeof(cef_navigation_entry_visitor_t));
            *ptr = default(cef_navigation_entry_visitor_t);
            ptr->_base._size = (UIntPtr)sizeof(cef_navigation_entry_visitor_t);
            ptr->_base._add_ref = (delegate* unmanaged<cef_base_ref_counted_t*, void>)(delegate* unmanaged<cef_navigation_entry_visitor_t*, void>)&add_ref;
            ptr->_base._release = (delegate* unmanaged<cef_base_ref_counted_t*, int>)(delegate* unmanaged<cef_navigation_entry_visitor_t*, int>)&release;
            ptr->_base._has_one_ref = (delegate* unmanaged<cef_base_ref_counted_t*, int>)(delegate* unmanaged<cef_navigation_entry_visitor_t*, int>)&has_one_ref;
            ptr->_base._has_at_least_one_ref = (delegate* unmanaged<cef_base_ref_counted_t*, int>)(delegate* unmanaged<cef_navigation_entry_visitor_t*, int>)&has_at_least_one_ref;
            ptr->_visit = &visit;
            return ptr;
        }
        
        internal static void Free(cef_navigation_entry_visitor_t* ptr)
        {
            NativeMemory.Free((void*)ptr);
        }
        
    }
}
