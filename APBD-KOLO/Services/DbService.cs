using APBD_KOLO.Data;
using APBD_KOLO.Models;
using Microsoft.EntityFrameworkCore;

namespace APBD_KOLO.Services;

public class DbService : IDbService
{
    private readonly DatabaseContext _context;
    public DbService(DatabaseContext context)
    {
        _context = context;
    }

    public async Task<characters> GetCharacterById(int id)
    {
        return await _context.characters
            .Include(e => e.Character_titles)
            .ThenInclude(e => e.Titles)
            .Include(e => e.Backpacks)
            .ThenInclude(e => e.Items)
            .FirstOrDefaultAsync(e => e.Id == id);
    }

}