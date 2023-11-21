using HashCodeDemo.Model;
using System.Security.Cryptography.X509Certificates;

namespace HashCodeDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DomainObject myElectricBike = new DomainObject("Link013",147,"GreenRenter19", "Electric bike 12Wh", "Electrobike", 24);
            DomainObject alsoMyElectricBike = new DomainObject
            {
                LotId = myElectricBike.LotId,
                CityCode = myElectricBike.CityCode,
                Name = myElectricBike.Name,
                Description = myElectricBike.Description,
                Type = myElectricBike.Type,
                CurrentBatteryLevel = 4            
            };
            if (myElectricBike.Equals(alsoMyElectricBike))
            {
                HashSet<DomainObject> availableBikes = new HashSet<DomainObject>();
                availableBikes.Add(myElectricBike);
                availableBikes.Add(alsoMyElectricBike);
            }
            if(myElectricBike.Equals(alsoMyElectricBike))
            {
                Console.WriteLine("Success!");
                if (myElectricBike.GetHashCode() == alsoMyElectricBike.GetHashCode())
                {
                    Console.WriteLine("Yay! We made it!");
                }
                else { Console.WriteLine("Not yet!"); }
            }
            Console.WriteLine(myElectricBike.GetHashCode());
            Console.WriteLine(alsoMyElectricBike.GetHashCode());           

        }
    }
}
