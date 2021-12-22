﻿using Generator3.Renderer.Internal;

namespace Generator3.Generation.Record
{
    public class InternalDelegatesTemplate : Template<InternalDelegatesModel>
    {
        public string Render(InternalDelegatesModel model)
        {
            return $@"
using System;
using System.Runtime.InteropServices;

#nullable enable

namespace { model.NamespaceName }
{{
    // AUTOGENERATED FILE - DO NOT MODIFY

    public partial class { model.Name }
    {{
        {model.Callbacks.RenderWithAttributes()}
    }}
}}";
        }
    }
}
