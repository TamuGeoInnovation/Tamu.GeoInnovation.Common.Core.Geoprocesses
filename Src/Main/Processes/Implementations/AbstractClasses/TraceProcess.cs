using System;
using System.Collections.Generic;
using System.Text;
using USC.GISResearchLab.Common.Geoprocesses.Processes.Interfaces;
using System.Diagnostics;

namespace USC.GISResearchLab.Common.Geoprocesses.Processes.Implementations
{
    public abstract class TraceProcess : ITraceableProcess
    {
        #region Properties
        private TraceSource _TraceSource;

        public TraceSource TraceSource
        {
            get { return _TraceSource; }
            set { _TraceSource = value; }
        }

        #endregion

        public TraceProcess() { }

        public TraceProcess(TraceSource traceSource)
        {
            TraceSource = traceSource;
        }

        public TraceSource GetTrace()
        {
            return TraceSource;
        }
    }
}
