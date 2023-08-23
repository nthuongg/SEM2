using Microsoft.AspNetCore.Mvc;
using SupermarketAPI.Models;
using SupermarketAPI.Repository;

namespace SupermarketAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MembershipController : ControllerBase
    {
        private readonly IGenericRepository<Membership> membershipRepository;

        public MembershipController(IGenericRepository<Membership> membershipRepository)
        {
            this.membershipRepository = membershipRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var memberships = await membershipRepository.GetAll();
                return Ok(memberships);

            }
            catch (Exception ex)
            {
                return StatusCode(500, "Intenal server error. Please try again later");
            }
        }

    }
}
