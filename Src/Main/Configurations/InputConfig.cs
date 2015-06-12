using System;
using System.Diagnostics;

namespace USC.GISResearchLab.Common.Geoprocesses.Configurations
{
    public class InputConfig : TraceableConfig
    {
        #region Properties
        private String _InputFilePath;
        public String InputFilePath
        {
            get { return _InputFilePath; }
            set { _InputFilePath = value; }
        }
        #endregion

        public InputConfig(string inputFilePath, TraceSource traceSource)
            :base(traceSource)
        {
            InputFilePath = inputFilePath;
        }
    }
}
