using APBD_KOLO.DTOs;
using APBD_KOLO.Models;
using APBD_KOLO.Services;
using Microsoft.AspNetCore.Mvc;

namespace APBD_KOLO.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CharactersController : ControllerBase
    {
        private readonly IDbService _dbService;
        public CharactersController(IDbService dbService)
        {
            _dbService = dbService;
        }

        [HttpGet]
        public async Task<IActionResult> GetCharactersData(int characterId)
        {
            var character = await _dbService.GetCharacterById(characterId);
            
            
            var characterDto = new GetCharactersDTO
            {
                firstName = character.FirstName,
                lastName = character.LastName,
                currentWeight = character.CurrentWei,
                maxWeight = character.MaxWeight,
                Items = character.Backpacks.Select(item => new GetBackPackItemsDTO
                {
                    itemName = item.Items.Name,
                    itemWeight = item.Items.Weight,
                    Amount = item.Amount
                }).ToList(),
                Titles = character.Character_titles.Select(title => new GetTitles
                {
                    title = title.Titles.Name,
                }).ToList()
            };

            return Ok(characterDto);
        }
    }
}