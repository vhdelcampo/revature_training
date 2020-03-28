using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MovieWorld.API.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class MovieController : ControllerBase
  {
    private static readonly List<MovieModel> _mml = new List<MovieModel>();

    [HttpGet]
    public IActionResult Get()
    {
      return Ok(_mml);
    }
    public void Get(int id)
    {

    }

    public IActionResult Post(MovieModel model)
    {
      if (ModelState.IsValid)
      {
        _mml.Add(model);
        return Ok("Success");
      }
      return BadRequest(model);
    }

    public void Put(int id)
    {

    }

    public void Delete(MovieModel model)
    {

    }
  }
}
