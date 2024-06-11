using APBD_KOLO.Models;

namespace APBD_KOLO.Services;

public interface IDbService
{
    Task<characters> GetCharacterById(int id);
}