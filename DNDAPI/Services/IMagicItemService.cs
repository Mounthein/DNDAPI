﻿using DNDAPI.Models;

namespace DNDAPI.Services
{
    public interface IMagicItemService
    {
        List<MagicItem> Get();
        MagicItem Get(string id);
        MagicItem Create(MagicItem item);
        void Update(string id, MagicItem item);
        void Remove(string id);
    }
}
