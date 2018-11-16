using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabV2OOP
{
    interface IChanges
    {
        void AcceptChanges(String temp, String pressure, String humidity);
    }
}
