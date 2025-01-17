﻿using workshop.wwwapi.Models;

namespace workshop.wwwapi.Repository
{
    public interface IRepository
    {
        IEnumerable<Pet> GetPets();
        Pet GetPet(int id);
        Pet DeletePet(int id);
        Pet AddPet(Pet pet);
    }
}
