using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabV2OOP
{
    public interface IValidate
    {
        void SetValues(double x, double y);
        bool Validate(double x);
        void GetValues(out double x, out double y);
        bool ValuesSet();
    }

    #region Temperature

    class TemperatureValidator : IValidate
    {
        private double _minTemp;
        private double _maxTemp;

        public double MinTemp { get { return _minTemp; } }
        public double MaxTemp { get { return _maxTemp; } }

        private TemperatureValidator() { }

        public void GetValues(out double x, out double y)
        {
            x = _minTemp;
            y = _maxTemp;
        }

        public void SetValues(double x, double y)
        {
            _minTemp = x;
            _maxTemp = y;
        }

        public bool Validate(double x)
        {
            if( x > _minTemp && x < _maxTemp)
                return true;
            return false;
        }

        public bool ValuesSet()
        {
            if (_minTemp !=0 || _maxTemp !=0)
                return true;
            return false;
        }

        private static TemperatureValidator _temperatureInstance = null;
        public static TemperatureValidator TemperatureInstance
        {
            get
            {
                if (_temperatureInstance == null)
                    _temperatureInstance = new TemperatureValidator();
                return _temperatureInstance;
            }
        }

    }

    #endregion

    #region Pressure

    class PressureValidator : IValidate
    {
        private double _minPress;
        private double _maxPress;

        public double MinPressure { get { return _minPress; } }
        public double MaxPressure { get { return _maxPress; } }

        private PressureValidator() { }

        public void GetValues(out double x, out double y)
        {
            x = _minPress;
            y = _maxPress;
        }

        public void SetValues(double x, double y)
        {
            _minPress = x;
            _maxPress = y;
        }

        public bool Validate(double x)
        {
            if (x > _minPress && x < _maxPress)
                return true;
            return false;
        }

        public bool ValuesSet()
        {
            if (_maxPress != 0 || _minPress != 0)
                return true;
            return false;
        }

        private static PressureValidator _pressureInstance = null;
        public static PressureValidator PressureInstance
        {
            get
            {
                if (_pressureInstance == null)
                    _pressureInstance = new PressureValidator();
                return _pressureInstance;
            }
        }
    }

    #endregion

    #region Humidity

    class HumidityValidator : IValidate
    {
        private double _minHumid;
        private double _maxHumid;

        public double MinHumidity { get { return _minHumid; } }
        public double MaxHumidity { get { return _maxHumid; } }

        public bool Validate(double x)
        {
            if (x > _minHumid && x < _maxHumid)
                return true;
            return false;
        }

        public void SetValues(double x, double y)
        {
            _minHumid = x;
            _maxHumid = y;
        }

        public void GetValues(out double x, out double y)
        {
            x = _minHumid;
            y = _maxHumid;
        }

        public bool ValuesSet()
        {
            if (_maxHumid != 0 || _minHumid != 0)
                return true;
            return false;
        }

        private static HumidityValidator _humidityInstance = null;
        public static HumidityValidator HumidityInstance
        {
            get
            {
                if (_humidityInstance == null)
                    _humidityInstance = new HumidityValidator();
                return _humidityInstance;
            }
        }

    }

    #endregion

}
