using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace USC.GISResearchLab.Common.Geoprocesses.Processes.Interfaces
{
    public interface ITraceableProcess
    {
        TraceSource GetTrace();
    }
}
