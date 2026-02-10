using Microsoft.AspNetCore.Mvc;

[ApiController]

[Route("api/")]
public class TestController : ControllerBase
{
    [HttpGet]
    public string Get()
    {
        return "Controller is working";
    }
    [HttpGet("{id}")]
    public IActionResult GetId(int id)
    {
        return Ok(
            new
            {
                message = "User fetced successfully",
                userID = id
            }
        );
    }   
}