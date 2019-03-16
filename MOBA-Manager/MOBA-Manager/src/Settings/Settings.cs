using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOBA_Manager.src.Settings
{
    public class Settings
    {
        public Boolean fullSCreenEnabled { get; set; }

        internal void SaveSettings(Settings _settings)
        {
        }

        internal Settings LoadSettings()
        {
            return this;
        }
    }
}
