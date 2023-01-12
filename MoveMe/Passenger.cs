using System;

namespace MoveMe
{
    public class Passenger : Person
    {
        private readonly string _cityOfDestination;
        
        public Passenger(string name, string destinationCity):base(name)
        {
            throw new NotImplementedException();
        }

        public string CityOfDestination
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public string LookLandscap() 
        {
            throw new NotImplementedException();
        }
    }
}
