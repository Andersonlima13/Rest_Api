using api_c_.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace api_c_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserControler : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<UserModel>> BuscarTodosUsuarios()
        {
            return Ok();
        }
    }
}
