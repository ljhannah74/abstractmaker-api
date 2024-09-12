using System;
using abstractmaker_api.Data;
using abstractmaker_api.Models;
using Microsoft.EntityFrameworkCore;

namespace abstractmaker_api.Repositories;

public class TitleAbstractRepository : ITitleAbstractRepository
{
    private readonly AppDbContext _context;
    public TitleAbstractRepository(AppDbContext context)
    {
        _context = context;
    }
    public async Task AddTitleAbstractAsync(TitleAbstract titleAbstract)
    {
        await _context.TitleAbstracts.AddAsync(titleAbstract);
        await _context.SaveChangesAsync();
    }

    public async Task<IEnumerable<TitleAbstract>> GetAllAsync()
    {
        return await _context.TitleAbstracts.ToListAsync();
    }

    public async Task<TitleAbstract?> GetByIdAsync(int id)
    {
        var titleAbstractInDb = await _context.TitleAbstracts.FindAsync(id);

        if (titleAbstractInDb == null)
        {
            throw new KeyNotFoundException($"Title Abstract with id {id} was not found");
        }

        return titleAbstractInDb;
    }

    public async Task<TitleAbstract?> GetByOrderNo(string orderId)
    {
        return await _context.TitleAbstracts.FirstOrDefaultAsync(b => b.OrderNo == orderId);
    }

    public async Task UpdateTitleAbstractAsync(TitleAbstract titleAbstract)
    {
        _context.TitleAbstracts.Update(titleAbstract);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteTitleAbstractAsync(int id)
    {
        var titleAbstractInDb = await GetByIdAsync(id);

        _context.TitleAbstracts.Remove(titleAbstractInDb);
        await _context.SaveChangesAsync();
    }

    public async Task AddDeedAsync(int id, Deed deedInfo)
    {
        var titleAbstractInDb = await GetByIdAsync(id);
        titleAbstractInDb.Deeds.Add(deedInfo);
        await _context.SaveChangesAsync();
    }
}
