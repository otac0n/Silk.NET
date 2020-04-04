// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

namespace Silk.NET.OpenGL.Extensions.NV
{
    [Extension("NV_blend_equation_advanced")]
    public abstract unsafe partial class NVBlendEquationAdvanced : NativeExtension<GL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBlendBarrierNV")]
        public abstract void BlendBarrier();

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBlendParameteriNV")]
        public abstract void BlendParameter([Flow(FlowDirection.In)] NV pname, [Flow(FlowDirection.In)] int value);

        public NVBlendEquationAdvanced(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}
