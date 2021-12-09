﻿using System.Collections.Generic;

namespace GirLoader.Output
{
    public partial class Signal : GirModel.Signal
    {
        string GirModel.Signal.Name => OriginalName;
        IEnumerable<GirModel.Parameter> GirModel.Signal.Parameters => ParameterList.SingleParameters;
    }
}
