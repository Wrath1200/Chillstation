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
    internal unsafe struct cef_command_handler_t
    {
        internal cef_base_ref_counted_t _base;
        internal delegate* unmanaged<cef_command_handler_t*, cef_browser_t*, int, CefWindowOpenDisposition, int> _on_chrome_command;
        internal delegate* unmanaged<cef_command_handler_t*, cef_browser_t*, int, int> _is_chrome_app_menu_item_visible;
        internal delegate* unmanaged<cef_command_handler_t*, cef_browser_t*, int, int> _is_chrome_app_menu_item_enabled;
        internal delegate* unmanaged<cef_command_handler_t*, CefChromePageActionIconType, int> _is_chrome_page_action_icon_visible;
        internal delegate* unmanaged<cef_command_handler_t*, CefChromeToolbarButtonType, int> _is_chrome_toolbar_button_visible;
        
        internal GCHandle _obj;
        
        [UnmanagedCallersOnly]
        public static void add_ref(cef_command_handler_t* self)
        {
            var obj = (CefCommandHandler)self->_obj.Target;
            obj.add_ref(self);
        }
        
        [UnmanagedCallersOnly]
        public static int release(cef_command_handler_t* self)
        {
            var obj = (CefCommandHandler)self->_obj.Target;
            return obj.release(self);
        }
        
        [UnmanagedCallersOnly]
        public static int has_one_ref(cef_command_handler_t* self)
        {
            var obj = (CefCommandHandler)self->_obj.Target;
            return obj.has_one_ref(self);
        }
        
        [UnmanagedCallersOnly]
        public static int has_at_least_one_ref(cef_command_handler_t* self)
        {
            var obj = (CefCommandHandler)self->_obj.Target;
            return obj.has_at_least_one_ref(self);
        }
        
        [UnmanagedCallersOnly]
        public static int on_chrome_command(cef_command_handler_t* self, cef_browser_t* browser, int command_id, CefWindowOpenDisposition disposition)
        {
            var obj = (CefCommandHandler)self->_obj.Target;
            return obj.on_chrome_command(self, browser, command_id, disposition);
        }
        
        [UnmanagedCallersOnly]
        public static int is_chrome_app_menu_item_visible(cef_command_handler_t* self, cef_browser_t* browser, int command_id)
        {
            var obj = (CefCommandHandler)self->_obj.Target;
            return obj.is_chrome_app_menu_item_visible(self, browser, command_id);
        }
        
        [UnmanagedCallersOnly]
        public static int is_chrome_app_menu_item_enabled(cef_command_handler_t* self, cef_browser_t* browser, int command_id)
        {
            var obj = (CefCommandHandler)self->_obj.Target;
            return obj.is_chrome_app_menu_item_enabled(self, browser, command_id);
        }
        
        [UnmanagedCallersOnly]
        public static int is_chrome_page_action_icon_visible(cef_command_handler_t* self, CefChromePageActionIconType icon_type)
        {
            var obj = (CefCommandHandler)self->_obj.Target;
            return obj.is_chrome_page_action_icon_visible(self, icon_type);
        }
        
        [UnmanagedCallersOnly]
        public static int is_chrome_toolbar_button_visible(cef_command_handler_t* self, CefChromeToolbarButtonType button_type)
        {
            var obj = (CefCommandHandler)self->_obj.Target;
            return obj.is_chrome_toolbar_button_visible(self, button_type);
        }
        
        internal static cef_command_handler_t* Alloc()
        {
            var ptr = (cef_command_handler_t*)NativeMemory.Alloc((UIntPtr)sizeof(cef_command_handler_t));
            *ptr = default(cef_command_handler_t);
            ptr->_base._size = (UIntPtr)sizeof(cef_command_handler_t);
            ptr->_base._add_ref = (delegate* unmanaged<cef_base_ref_counted_t*, void>)(delegate* unmanaged<cef_command_handler_t*, void>)&add_ref;
            ptr->_base._release = (delegate* unmanaged<cef_base_ref_counted_t*, int>)(delegate* unmanaged<cef_command_handler_t*, int>)&release;
            ptr->_base._has_one_ref = (delegate* unmanaged<cef_base_ref_counted_t*, int>)(delegate* unmanaged<cef_command_handler_t*, int>)&has_one_ref;
            ptr->_base._has_at_least_one_ref = (delegate* unmanaged<cef_base_ref_counted_t*, int>)(delegate* unmanaged<cef_command_handler_t*, int>)&has_at_least_one_ref;
            ptr->_on_chrome_command = &on_chrome_command;
            ptr->_is_chrome_app_menu_item_visible = &is_chrome_app_menu_item_visible;
            ptr->_is_chrome_app_menu_item_enabled = &is_chrome_app_menu_item_enabled;
            ptr->_is_chrome_page_action_icon_visible = &is_chrome_page_action_icon_visible;
            ptr->_is_chrome_toolbar_button_visible = &is_chrome_toolbar_button_visible;
            return ptr;
        }
        
        internal static void Free(cef_command_handler_t* ptr)
        {
            NativeMemory.Free((void*)ptr);
        }
        
    }
}
