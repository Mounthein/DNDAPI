using DNDAPI.Models;

namespace DNDAPI.Services
{
    public interface IFeatureService
    {
        List<Feature> Get();
        Feature Get(string id);
        Feature Create(Feature feature);
        void Update(string id, Feature feature);
        void Remove(string id);
    }
}
