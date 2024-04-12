namespace DNDAPI.Models
{
    public class DndStoreDatabaseSettings : IDndStoreDatabaseSettings
    {
        public string ConnectionString { get; set; } = String.Empty;
        public string DatabaseName { get; set; } = String.Empty;
        public string DndDamageTypeCollectionName { get; set; } = String.Empty;
        public string DndAlignmentCollectionName {  get; set; } = String.Empty;
        public string DndWeaponPropertyCollectionName {get; set; } = String.Empty;
        public string DndConditionsCollectionName { get; set; } = String.Empty;
        public string DndLanguageCollectionName { get; set; } = String.Empty;
    }
}
