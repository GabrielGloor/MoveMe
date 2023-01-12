using System;

namespace MoveMe
{
    public class Vehicle : IVehicle
    {
        private string _brand = "";
        private bool _engineState = false;

        public Vehicle(string brand)
        {
            _brand = brand;
        }

        public string Brand
        {
            get
            {
                return _brand;
            }
        }

        public Boolean IsEngineStarted
        {
            get
            {
                return _engineState;
            }
        }

        public void StartEngine()
        {
            throw new NotImplementedException();
        }

        public void StopEngine()
        {
            throw new NotImplementedException();
        }

        public class VehicleException : Exception { }

        public class MotorStartException : VehicleException { };
    }
}
