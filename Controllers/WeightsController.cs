using System;
using fitlog.Models;
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
    [HttpPost]
    public ActionResult<Weight> Post([FromBody] Weight weight)
    {
      try
      {
        return Ok(_repo.AddWeight(weight));
      }
      catch (Exception e)
      {

        return BadRequest(e.Message);
      }
    }
  }
}