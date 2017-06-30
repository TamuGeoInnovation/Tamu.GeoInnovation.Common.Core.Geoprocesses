using USC.GISResearchLab.Common.Geoprocesses.Processes.Interfaces;
using System.Diagnostics;

namespace USC.GISResearchLab.Common.Geoprocesses.Processes.Implementations
{
    public abstract class InputterOutputterClass : TraceProcess, IInputableProcess, IOutputableProcess
    {
        #region Properties
        private string _OutputFilePath;
        private string _InputFilePath;
        public string InputFilePath
        {
            get { return _InputFilePath; }
            set { _InputFilePath = value; }
        }
        public string OutputFilePath
        {
            get { return _OutputFilePath; }
            set { _OutputFilePath = value; }
        }
        #endregion

        public InputterOutputterClass(TraceSource traceSource)
            : base(traceSource) { }
        

        public string GetInput()
        {
            return InputFilePath;
        }

        public string GetOutput()
        {
            return OutputFilePath;
        }
    }
}
