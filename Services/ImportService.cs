using Microsoft.AspNetCore.Mvc;
using Project_api_read_csv.Core;
using Project_api_read_csv.Services.Interfaces;

namespace Project_api_read_csv.Services
{
    public class ImportService : IImportService
    {
        public ImportService() { }

        public ActionResult<ImportResponse> ImportCsv(ImportRequest request)
        {
            ImportResponse importResponse = new ImportResponse();
            importResponse.import = request.import;

            return importResponse;
        }
    }
}
