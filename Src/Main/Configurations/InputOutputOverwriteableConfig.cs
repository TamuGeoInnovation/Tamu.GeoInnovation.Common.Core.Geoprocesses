using System;
using System.Diagnostics;

namespace USC.GISResearchLab.Common.Geoprocesses.Configurations
{
    public class InputOutputOverwriteableConfig : InputOutputConfig
    {
        #region Properties
        private bool _Overwrite;
        public bool Overwrite
        {
            get { return _Overwrite; }
            set { _Overwrite = value; }
        }
        #endregion

        public InputOutputOverwriteableConfig(string inputFilePath, string outputFilePath, bool overwrite, TraceSource traceSource)
            :base(inputFilePath, outputFilePath, traceSource)
        {
            Overwrite = overwrite;
        }
    }
}
