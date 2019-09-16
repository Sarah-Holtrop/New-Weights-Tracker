using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using fitlog.Models;
using fitlog.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace fitlog.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class LiftsController : ControllerBase
  {
    private readonly LiftsRepository _repo;

    public LiftsController(LiftsRepository repo)
    {
      _repo = repo;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Lift>> Get()
    {
      try
      {
        return Ok(_repo.GetLifts());
      }
      catch (Exception e)
      {

        return BadRequest(e.Message);
      }
    }

    [HttpPost]
    public ActionResult<Lift> Post([FromBody] Lift lift)
    {
      try
      {
        return Ok(_repo.CreateLift(lift));
      }
      catch (Exception e)
      {
        return BadRequest("Bad Request");
      }
    }

    // [HttpGet("{id}")]
    // public ActionResult<string> Get(int id)
    // {
    //   return null;
    // }




    // [HttpPut("{id}")]
    // public void Put(int id, [FromBody] string value)
    // {
    // }


    // [HttpDelete("{id}")]
    // public void Delete(int id)
    // {
    // }
  }
}
