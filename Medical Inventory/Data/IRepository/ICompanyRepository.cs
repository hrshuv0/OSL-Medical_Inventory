﻿using Medical_Inventory.Models;

namespace Medical_Inventory.Data.IRepository;

public interface ICompanyRepository
{
    Task<Company?>? GetFirstOrDefault(long? id);
    Task<IEnumerable<Company>?>? GetAll();
    Task Add(Company entity);
    Task Update(Company entity);
    Task Remove(Company entity);
    Task<Company?> GetByName(string? name);
}