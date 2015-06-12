using System;
using System.Collections.Generic;
using System.Text;
using USC.GISResearchLab.Common.Geoprocesses.Configurations;

namespace USC.GISResearchLab.Common.Geoprocesses.Processes.Interfaces
{
    public interface IOverwriteableProcess
    {
        void DeleteExistingOutput();
    }
}
