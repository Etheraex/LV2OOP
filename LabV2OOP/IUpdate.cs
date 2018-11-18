using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabV2OOP
{
    interface IUpdate
    {
        void UpdateTemperature(double temp);
        void UpdatePressure(double press);
        void UpdateHumidity(double humid);
        void UpdateStandardValues();
    }
}