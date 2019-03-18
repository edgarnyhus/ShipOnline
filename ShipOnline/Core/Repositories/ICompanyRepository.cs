using ShipOnline.Core.Domain;
namespace ShipOnline.Core.Repositories
{
    public interface ICompanyRepository : IRepository<Company>
    {
        Company GetCompanyWithShips(string id);
    }
}