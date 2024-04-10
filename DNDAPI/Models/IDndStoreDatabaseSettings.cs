namespace DNDAPI.Models
{
    public interface IDndStoreDatabaseSettings
    {
        string DndDamageTypeCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName {  get; set; }
    }
}
