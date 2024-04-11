﻿namespace DNDAPI.Models
{
    public interface IDndStoreDatabaseSettings
    {
        string ConnectionString { get; set; }
        string DatabaseName {  get; set; }
        string DndDamageTypeCollectionName { get; set; }
        string DndAlignmentCollectionName { get; set; }
        string DndWeaponPropertyCollectionName { get; set; }
    }
}
