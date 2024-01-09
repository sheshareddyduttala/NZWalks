using NZWalks.API.Models.Domain;

namespace NZWalks.API.Reositories
{
    public interface IRegionRepository
    {

       Task<IEnumerable<Region>> GetAllAsync();
    }
}
