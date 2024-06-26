﻿using DNDAPI.Models;

namespace DNDAPI.Services
{
    public interface ICharacterService
    {
        List<Character> Get();
        Character Get(string id);
        List<Character> GetByUserName(string userName);
        Character Create(Character character);
        void Update(string id, Character character);
        void Remove(string id);
    }
}
