using System.Diagnostics;
using USC.GISResearchLab.Common.Geoprocesses.Processes.Interfaces;

namespace USC.GISResearchLab.Common.Geoprocesses.Processes.Implementations
{
    public abstract class InputterOutputterOvewriterClass : OverwriterClass, IInputableProcess, IOutputableProcess, IOverwriteableProcess
    {
        #region Properties
        private string _InputFilePath;
        public string InputFilePath
        {
            get { return _InputFilePath; }
            set { _InputFilePath = value; }
        }
        #endregion

        public InputterOutputterOvewriterClass() { }

        public InputterOutputterOvewriterClass(TraceSource traceSource)
            : base(traceSource)
        {
            Overwrite = true;
        }

        public string GetInput()
        {
            return InputFilePath;
        }

        public new string GetOutput()
        {
            return OutputFilePath;
        }
    }
}
