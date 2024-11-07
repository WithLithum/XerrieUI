// SPDX-FileCopyrightText: 2024 WithLithum <WithLithum@outlook.com>
// 
// SPDX-License-Identifier: Apache-2.0

using System.Collections;
using System.Runtime.InteropServices;
using XerrieUI.Native.Interop;

namespace XerrieUI.Native.Extensions.RAndR;

public sealed class MonitorInfoEnumerator : IEnumerator<MonitorInfo>, IEnumerable<MonitorInfo>
{
    private readonly unsafe LibXcbRandR.XRandRGetMonitorsReply* _replyPtr;
    private LibXcbRandR.XRandRMonitorInfoIterator _iterator;

    internal unsafe MonitorInfoEnumerator(LibXcbRandR.XRandRMonitorInfoIterator iterator, 
        LibXcbRandR.XRandRGetMonitorsReply* replyPtr)
    {
        _iterator = iterator;
        _replyPtr = replyPtr;
    }
    
    public bool MoveNext()
    {
        if (_iterator.Remaining == 0)
        {
            return false;
        }
        
        var varIterator = _iterator;
        LibXcbRandR.xcb_randr_monitor_info_next(ref varIterator);
        _iterator = varIterator;
        return true;
    }

    public void Reset()
    {
        throw new NotSupportedException();
    }

    public unsafe MonitorInfo Current => *_iterator.Data;

    object? IEnumerator.Current => Current;
    
    public IEnumerator<MonitorInfo> GetEnumerator()
    {
        return this;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    private unsafe void ReleaseUnmanagedResources()
    {
        Marshal.FreeHGlobal((IntPtr)_replyPtr);
    }

    public void Dispose()
    {
        ReleaseUnmanagedResources();
        GC.SuppressFinalize(this);
    }

    ~MonitorInfoEnumerator()
    {
        ReleaseUnmanagedResources();
    }
}