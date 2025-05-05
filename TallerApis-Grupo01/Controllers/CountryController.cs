using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TallerApis_Grupo01.Repositories;

namespace TallerApis_Grupo01.Controllers
{
    public class CountryController : Controller
    {
        private CountryRepository _repo;

     public CountryController()
        {
            _repo = new CountryRepository();
        }

        public async Task<IActionResult> CountryList()
        {
            var countries = await _repo.GetCountryList();
            return View(countries);
        }
    }
}
