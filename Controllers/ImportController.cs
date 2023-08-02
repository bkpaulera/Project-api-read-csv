using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Project_api_read_csv.Core;
using Project_api_read_csv.Domain.Model;
using Project_api_read_csv.Services.Interfaces;

namespace Project_api_read_csv.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImportController : ControllerBase
    {
        //Interface para chamar os metodos que estão na camada service
        private readonly IImportService _importService;

        public ImportController(IImportService importService) {
            //Injeção de dependencia , olhe o Program.cs
            _importService = importService;
        }
                
        // POST api/<ImportController>
        [HttpPost("post-csv")]
        public async Task<ActionResult<ImportResponse>> ImportUser([FromBody] ImportRequest value)
        {
            
            return _importService.ImportCsv(value);
        }

    }
}
