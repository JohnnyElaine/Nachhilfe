namespace CarRentalCompanyLibrary
{
    public class Car : IEquatable<Car>
    {
        public bool Equals(Car? other)
        {
            if (other == null) return false;

            return true;
        }
    }
}