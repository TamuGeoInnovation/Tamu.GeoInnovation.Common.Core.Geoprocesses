using System;
using System.Diagnostics;

namespace USC.GISResearchLab.Common.Geoprocesses.Configurations
{
    public class InputOutputConfig: TraceableConfig
    {
        #region Properties
        private String _InputFilePath;
        private String _OutputFilePath;
        public String InputFilePath
        {
            get { return _InputFilePath; }
            set { _InputFilePath = value; }
        }

        public String OutputFilePath
        {
            get { return _OutputFilePath; }
            set { _OutputFilePath = value; }
        }
        #endregion

        public InputOutputConfig(string inputFilePath, string outputFilePath, TraceSource traceSource)
            :base(traceSource)
        {
            InputFilePath = inputFilePath;
            OutputFilePath = outputFilePath;
        }
    }
}
