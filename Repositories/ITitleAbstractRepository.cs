using System;
using abstractmaker_api.Models;

namespace abstractmaker_api.Repositories;

public interface ITitleAbstractRepository
{
    Task<IEnumerable<TitleAbstract>> GetAllAsync();
    Task<TitleAbstract?> GetByIdAsync(int id);
    Task<TitleAbstract?> GetByOrderNo(string orderId);
    Task AddTitleAbstractAsync(TitleAbstract titleAbstract);
    Task UpdateTitleAbstractAsync(TitleAbstract titleAbstract);
    Task DeleteTitleAbstractAsync(int id);
}
