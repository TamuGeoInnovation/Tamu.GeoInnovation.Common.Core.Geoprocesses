using System.Diagnostics;
using USC.GISResearchLab.Common.Diagnostics.TraceEvents;
using USC.GISResearchLab.Common.Geoprocesses.Processes.Interfaces;
using USC.GISResearchLab.Common.Utils.Files;

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

        public OverwriterClass() { }

        public OverwriterClass(TraceSource traceSource)
            : base(traceSource)
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
