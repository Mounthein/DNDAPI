﻿namespace DNDAPI.Models
{
    public interface IDndStoreDatabaseSettings
    {
        string ConnectionString { get; set; }
        string DatabaseName {  get; set; }
        string DndDamageTypeCollectionName { get; set; }
        string DndAlignmentCollectionName { get; set; }
        string DndWeaponPropertyCollectionName { get; set; }
        string DndConditionsCollectionName { get; set; }
        string DndLanguageCollectionName { get; set; }
        string DndSkillCollectionName { get; set; }
        string DndAbilityScoreCollectionName { get; set; }
        string DndBackgroundCollectionName { get; set; }
        string DndClassCollectionName { get; set; }
        string DndEquipmentCollectionName { get; set; }
        string DndEquipmentCategoriesCollectionName { get; set; }
        string DndFeatsCollectionName { get; set; }
        string DndFeaturesCollectionName { get; set; }
        string DndLevelCollectioName { get; set; }
        string DndMagicItemsCollectionName { get; set; }
        string DndMagicSchoolsCollectionName { get; set; }
        string DndProficiencyCollectionName { get; set; }
        string DndRaceCollectionName { get; set; }
        string DndSpellCollectionName { get; set; }
        string DndSubclassesCollectionName { get; set; }
        string DndSubRaceCollectionName { get; set; }
        string DndTraitCollectionName { get; set; }
        string DndCharacterCollectionName { get; set; }
        string DndUserCollectionName { get; set; }
        string DndPass { get; set; }
    }
}
