using Microsoft.AspNetCore.Mvc;
using Project_api_read_csv.Core;
using Project_api_read_csv.Domain.Model;

namespace Project_api_read_csv.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImportController : ControllerBase
    {
        public ImportController() {
            
        }
                
        // POST api/<ImportController>
        [HttpPost("post-csv")]
        public async Task<ActionResult<ImportResponse>> ImportUser([FromBody] ImportRequest value)
        {
            ImportResponse importResponse = new ImportResponse();
            importResponse.import = value.import;

            return importResponse;
        }

    }
}
