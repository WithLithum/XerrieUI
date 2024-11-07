// SPDX-FileCopyrightText: 2024 WithLithum <WithLithum@outlook.com>
// 
// SPDX-License-Identifier: Apache-2.0

using System.Runtime.InteropServices;
using XerrieUI.Native.Interop;

namespace XerrieUI.Native.Extensions.RAndR;

public sealed class ScreenResources : IDisposable
{
    private readonly unsafe LibXcbRandR.XRandRGetScreenResourcesReply* _resourcesPtr;

    internal unsafe ScreenResources(LibXcbRandR.XRandRGetScreenResourcesReply* resourcesPtr)
    {
        _resourcesPtr = resourcesPtr;
    }

    public unsafe uint GetCrtc(int index)
    {
        var length = LibXcbRandR.xcb_randr_get_screen_resources_crtcs_length(_resourcesPtr);
        ArgumentOutOfRangeException.ThrowIfGreaterThanOrEqual(index, length);

        var arrayPtr = LibXcbRandR.xcb_randr_get_screen_resources_crtcs(_resourcesPtr);
        return arrayPtr[index];
    }

    public unsafe uint[] GetCrtc()
    {
        var length = LibXcbRandR.xcb_randr_get_screen_resources_crtcs_length(_resourcesPtr);
        var arrayPtr = LibXcbRandR.xcb_randr_get_screen_resources_crtcs(_resourcesPtr);
        
        var result = new uint[length];
        fixed (uint* resultPtr = result)
        {
            for (var i = 0; i < length; i++)
            {
                resultPtr[i] = result[i];
            }
        }
        
        return result;
    }
    
    public unsafe ScreenModeInfo[] GetModeInfos()
    {
        var length = LibXcbRandR.xcb_randr_get_screen_resources_modes_length(_resourcesPtr);
        var ptr = LibXcbRandR.xcb_randr_get_screen_resources_modes(_resourcesPtr);
        var resultArray = new ScreenModeInfo[length];

        fixed (ScreenModeInfo* resultPtr = resultArray)
        {
            for (var i = 0; i < length; i++)
            {
                resultPtr[i] = ptr[i];
            }
        }

        return resultArray;
    }
    
    private unsafe void ReleaseUnmanagedResources()
    {
        Marshal.FreeHGlobal((IntPtr)_resourcesPtr);
    }

    public void Dispose()
    {
        ReleaseUnmanagedResources();
        GC.SuppressFinalize(this);
    }

    ~ScreenResources()
    {
        ReleaseUnmanagedResources();
    }
}