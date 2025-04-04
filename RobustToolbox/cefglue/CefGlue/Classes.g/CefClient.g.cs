﻿//
// DO NOT MODIFY! THIS IS AUTOGENERATED FILE!
//
namespace Xilium.CefGlue
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Runtime.InteropServices;
    using Xilium.CefGlue.Interop;
    
    // Role: HANDLER
    public abstract unsafe partial class CefClient
    {
        private static Dictionary<IntPtr, CefClient> _roots = new Dictionary<IntPtr, CefClient>();
        
        private int _refct;
        private cef_client_t* _self;
        
        protected object SyncRoot { get { return this; } }
        
        internal static CefClient FromNativeOrNull(cef_client_t* ptr)
        {
            CefClient value = null;
            bool found;
            lock (_roots)
            {
                found = _roots.TryGetValue((IntPtr)ptr, out value);
            }
            return found ? value : null;
        }
        
        internal static CefClient FromNative(cef_client_t* ptr)
        {
            var value = FromNativeOrNull(ptr);
            if (value == null) throw ExceptionBuilder.ObjectNotFound();
            return value;
        }
        
        protected CefClient()
        {
            _self = cef_client_t.Alloc();
        }
        
        ~CefClient()
        {
            Dispose(false);
        }
        
        protected virtual void Dispose(bool disposing)
        {
            if (_self != null)
            {
                cef_client_t.Free(_self);
                _self = null;
            }
        }
        
        internal void add_ref(cef_client_t* self)
        {
            lock (SyncRoot)
            {
                var result = ++_refct;
                if (result == 1)
                {
                    _self->_obj = GCHandle.Alloc(this);
                    lock (_roots) { _roots.Add((IntPtr)_self, this); }
                }
            }
        }
        
        internal int release(cef_client_t* self)
        {
            lock (SyncRoot)
            {
                var result = --_refct;
                if (result == 0)
                {
                    _self->_obj.Free();
                    lock (_roots) { _roots.Remove((IntPtr)_self); }
                    return 1;
                }
                return 0;
            }
        }
        
        internal int has_one_ref(cef_client_t* self)
        {
            lock (SyncRoot) { return _refct == 1 ? 1 : 0; }
        }
        
        internal int has_at_least_one_ref(cef_client_t* self)
        {
            lock (SyncRoot) { return _refct != 0 ? 1 : 0; }
        }
        
        internal cef_client_t* ToNative()
        {
            add_ref(_self);
            return _self;
        }
        
        [Conditional("DEBUG")]
        private void CheckSelf(cef_client_t* self)
        {
            if (_self != self) throw ExceptionBuilder.InvalidSelfReference();
        }
        
    }
}
