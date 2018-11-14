using System;
using System.Collections.Generic;
using System.Text;

namespace Sf.ContractApi.ApplicationCore.Configuration
{
    public class ApplicationConfiguration
    {
        //        "Setting1": "Setting 1 value",
        //"Setting2": "Setting 2 value",
        //"Subsection A": {
        //  "Option1": "Subsection A - Option 1 value",
        //  "Option2": "Subsection A - Option 2 value"

        public string Setting1 { get; set; }
        public string Setting2 { get; set; }
        public SubsectionA SubsectionA { get; set; }
    }

    public class SubsectionA
    {
        public string Option1 { get; set; }
        public string Option2 { get; set; }

    }
}
