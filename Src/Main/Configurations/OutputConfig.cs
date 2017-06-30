using System.Diagnostics;

namespace USC.GISResearchLab.Common.Geoprocesses.Configurations
{
    public class OutputConfig : TraceableConfig
    {
        #region Properties
        private string _OutputFilePath;
        public string OutputFilePath
        {
            get { return _OutputFilePath; }
            set { _OutputFilePath = value; }
        }
        #endregion

        public OutputConfig(string outputFilePath, TraceSource traceSource)
            :base(traceSource)
        {
            OutputFilePath = outputFilePath;
        }
    }
}
