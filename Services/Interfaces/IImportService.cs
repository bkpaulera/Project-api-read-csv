using Microsoft.AspNetCore.Mvc;
using Project_api_read_csv.Core;

namespace Project_api_read_csv.Services.Interfaces
{
    public interface IImportService
    {
       public ActionResult<ImportResponse> ImportCsv(ImportRequest request);
    }
}
