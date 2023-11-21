using Santander.Vehicles.Model;

namespace Santander.Vehicles.Repositories
{
    class MakeRepository
    {
        public List<Make> GetAllMakes()
        {
            List<Make> makes = new List<Make>();
            makes.Add(new Make { Id = 1, Name = "Mazda" });
            makes.Add(new Make { Id = 2, Name = "Toyota" });
            makes.Add(new Make { Id = 3, Name = "Audi" });

            return makes;
        }
    }
}
