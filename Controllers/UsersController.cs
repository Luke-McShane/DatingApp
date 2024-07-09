using API.Entities;
using API.Data;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]

public class UsersController(DataContext context) : ControllerBase
{
  [HttpGet]
  public ActionResult<IEnumerable<AppUser>> GetUsers()
  {
    var users = context.Users.ToList();
    return users;
  }

  [HttpGet]
  public ActionResult<IEnumerable<AppUser>> GetUsers()
  {
    var users = context.Users.ToList();
    return users;
  }
}
