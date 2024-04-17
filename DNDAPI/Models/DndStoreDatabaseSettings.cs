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
        public string DndSkillCollectionName { get; set; } = String.Empty;
        public string DndAbilityScoreCollectionName { get; set; } = String.Empty;
        public string DndBackgroundCollectionName { get; set; } = String.Empty;
        public string DndEquipmentCollectionName { get; set; } = String.Empty;
    }
}
