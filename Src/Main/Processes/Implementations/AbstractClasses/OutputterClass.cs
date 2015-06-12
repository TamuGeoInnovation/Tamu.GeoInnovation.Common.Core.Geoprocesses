using System;
using System.Collections.Generic;
using System.Text;
using USC.GISResearchLab.Common.Geoprocesses.Processes.Interfaces;
using USC.GISResearchLab.Common.Geoprocesses.Configurations;
using System.Diagnostics;

namespace USC.GISResearchLab.Common.Geoprocesses.Processes.Implementations
{
    public abstract class OutputterClass : TraceProcess, IOutputableProcess
    {
        #region Properties
        private string _OutputFilePath;
        public string OutputFilePath
        {
            get { return _OutputFilePath; }
            set { _OutputFilePath = value; }
        }
        #endregion

        public OutputterClass() { }

        public OutputterClass(TraceSource traceSource)
            : base(traceSource){ }


        public string GetOutput()
        {
            return OutputFilePath;
        }
    }
}
