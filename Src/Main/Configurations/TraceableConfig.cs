using System;
using System.Diagnostics;

namespace USC.GISResearchLab.Common.Geoprocesses.Configurations
{
    public class TraceableConfig : ProcessConfig
    {
        #region Properties
        private TraceSource _TraceSource;

        public TraceSource TraceSource
        {
            get { return _TraceSource; }
            set { _TraceSource = value; }
        }

        #endregion

        public TraceableConfig(TraceSource _traceSource)
        {
            TraceSource = _traceSource;
        }
    }
}
