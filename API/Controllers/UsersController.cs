using Microsoft.AspNetCore.Mvc;
using API.Data;
using System.Data.Common;
using API.Entity;
using Microsoft.EntityFrameworkCore;
namespace API.Controllers;

[ApiController]
[Route("api/[controller]")] //api/User
public class UserController : ControllerBase
{
    private readonly DataContext Db;
    public UserController(DataContext context)
    {
        Db = context;
    }


    [HttpGet]
    [Route("AllUsers")]
    public async Task<ActionResult<IEnumerable<Users>>> GetUsers()
    {

        //Users --> maps to the class which is mentioned in the Entity
        //Users Class is maps to the ApplicationUsers Table in  DB 
        List<Users> res = await Db.ApplicationUsers.Where(x => x.Id > 1).ToListAsync();
        return  res;
    }

    [HttpGet]
    [Route("{id:int}")]
    public async Task<ActionResult<Users>> GetUsers(int id)
    {

        //Users --> maps to the class which is mentioned in the Entity
        //Users Class is maps to the ApplicationUsers Table in  DB 
        Entity.Users? res = await Db.ApplicationUsers.FindAsync(id);
        if(res == null) return  new Users{Id= -1, Name = "NotExist"};
        return res;
    }

    [HttpGet]
    [Route("Add")]
    public ActionResult<IEnumerable<Temp>> AddUsers()
    {
        List<Temp> tempp = new List<Temp>();
        var temp = new Temp();
        temp.Id = 1;
        temp.Name = "Ullas";
        tempp.Add(temp);
        temp = new Temp();
        temp.Id = 2;
        temp.Name = "Uddddllas";
        tempp.Add(temp);
        temp = new Temp();
        temp.Id = 3;
        temp.Name = "gfhhgf";

        tempp.Add(temp);
        return tempp;
    }
}
