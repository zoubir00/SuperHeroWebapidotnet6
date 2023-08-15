using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SuperHeroWebApi.Models;

namespace SuperHeroWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<SuperHero>>> getSuperHero()
        {
            return new List<SuperHero>
            {
                new SuperHero
                {
                    Name="Spider man",
                    firsName="Peter",
                    lastName="Parck",
                    Place="New york"

                },
                new SuperHero
                {
                     Name="Allal L9adouss",
                    firsName="Allal",
                    lastName="Qadous",
                    Place="Casablanca"
                }
            };
        }
    }
}
