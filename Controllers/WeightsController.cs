using fitlog.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace fitlog.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class WeightsController : ControllerBase
  {
    private readonly WeightsRepository _repo;

    public WeightsController(WeightsRepository repo)
    {
      _repo = repo;
    }
  }
}