using System;
using System.Collections.Generic;
using System.Text;
using USC.GISResearchLab.Common.Geoprocesses.Configurations;
using USC.GISResearchLab.Common.Utils.Files;
using System.Diagnostics;
using USC.GISResearchLab.Common.Diagnostics.TraceEvents;
using USC.GISResearchLab.Common.Geoprocesses.Processes;
using USC.GISResearchLab.Common.Geoprocesses.Processes.Interfaces;

namespace USC.GISResearchLab.Common.Geoprocesses.Processes.Implementations
{
    public abstract class OverwriterClass : OutputterClass, IOverwriteableProcess, IOutputableProcess
    {
        #region Properties
        private bool _Overwrite;
        public bool Overwrite
        {
            get { return _Overwrite; }
            set { _Overwrite = value; }
        }
        #endregion

        public OverwriterClass(){ }

        public OverwriterClass(TraceSource traceSource)
            :base(traceSource)
        {
            Overwrite = true;
        }

        public void DeleteExistingOutput()
        {
            if (FileUtils.FileExists(OutputFilePath))
            {
                TraceSource.TraceEvent(TraceEventType.Verbose, (int)GeoprocessorEvents.Executing, "Deleting Output file : " + OutputFilePath);
                FileUtils.DeleteShapefile(OutputFilePath);
            }
        }
    }
}
