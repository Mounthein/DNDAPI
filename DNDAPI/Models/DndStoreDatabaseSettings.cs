﻿namespace DNDAPI.Models
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
        public string DndAbilityScoreCollectionName {  get; set; } = String.Empty;
        public string DndBackgroundCollectionName {  get; set; } = String.Empty;
        public string DndClassCollectionName { get; set; } = String.Empty;
        public string DndEquipmentCollectionName { get; set; } = String.Empty;
        public string DndEquipmentCategoriesCollectionName { get; set; } = String.Empty;
        public string DndFeatsCollectionName { get; set; } = String.Empty;
        public string DndFeaturesCollectionName { get; set; } = String.Empty;
        public string DndLevelCollectioName { get; set; } = String.Empty;
        public string DndMagicItemsCollectionName { get; set; } = String.Empty;
        public string DndMagicSchoolsCollectionName { get; set; } = String.Empty;
        public string DndProficiencyCollectionName { get; set; } = String.Empty;
        public string DndRaceCollectionName { get; set; } = String.Empty;
        public string DndSpellCollectionName { get; set; } = String.Empty;
        public string DndSubclassesCollectionName { get; set; } = String.Empty;
        public string DndSubRaceCollectionName { get; set; } = String.Empty;
        public string DndTraitCollectionName { get; set; } = String.Empty;
        public string DndCharacterCollectionName { get; set; } = String.Empty;
        public string DndUserCollectionName { get; set; } = String.Empty;
        public string DndPass { get; set; } = String.Empty;
    }
}
