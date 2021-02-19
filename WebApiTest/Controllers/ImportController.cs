using Microsoft.AspNetCore.Mvc;

namespace WebApiTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImportController : ControllerBase
    {
        public IActionResult UploadFile()
        {
            foreach (var file in Request.Form.Files)
            {

            }

            return Ok(1);
        }
    }
}
