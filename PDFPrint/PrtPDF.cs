using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDFPrint
{
    class PrtPDF
    {
        private string name;
        private string orgPDF;
        private string saveRoot;
        private bool FieldReadOnly;

        public PrtPDF(string Name, string OrgPDF, string SaveRoot)
        {
            name = Name;
            orgPDF = OrgPDF;
            saveRoot = SaveRoot;

        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string OrgPDF
        {
            get { return name; }
            set { name = value; }
        }

        public string SaveRoot
        {
            get { return name; }
            set { name = value; }
        }

    }

}
