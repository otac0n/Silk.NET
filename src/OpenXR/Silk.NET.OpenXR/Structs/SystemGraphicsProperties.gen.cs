// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrSystemGraphicsProperties")]
    public unsafe partial struct SystemGraphicsProperties
    {
        public SystemGraphicsProperties
        (
            uint maxSwapchainImageHeight = default,
            uint maxSwapchainImageWidth = default,
            uint maxLayerCount = default
        )
        {
            MaxSwapchainImageHeight = maxSwapchainImageHeight;
            MaxSwapchainImageWidth = maxSwapchainImageWidth;
            MaxLayerCount = maxLayerCount;
        }

/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxSwapchainImageHeight")]
        public uint MaxSwapchainImageHeight;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxSwapchainImageWidth")]
        public uint MaxSwapchainImageWidth;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxLayerCount")]
        public uint MaxLayerCount;
    }
}