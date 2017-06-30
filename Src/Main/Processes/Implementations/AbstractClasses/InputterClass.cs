using USC.GISResearchLab.Common.Geoprocesses.Processes.Interfaces;
using System.Diagnostics;

namespace USC.GISResearchLab.Common.Geoprocesses.Processes.Implementations
{
    public abstract class InputterClass: TraceProcess, IInputableProcess
    {
        #region Properties
        private string _InputFilePath;
        public string InputFilePath
        {
            get { return _InputFilePath; }
            set { _InputFilePath = value; }
        }
        #endregion

        public InputterClass(TraceSource traceSource)
            :base(traceSource){}

        public string GetInput()
        {
            return InputFilePath;
        }
    }
}
