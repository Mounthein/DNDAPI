namespace DNDAPI.Models
{
    public class DndStoreDatabaseSettings : IDndStoreDatabaseSettings
    {
        public string DndDamageTypeCollectionName { get; set; } = String.Empty;
        public string ConnectionString { get; set; } = String.Empty;
        public string DatabaseName { get; set; } = String.Empty;
    }
}
