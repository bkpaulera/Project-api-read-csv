using Microsoft.AspNetCore.Mvc;
using Project_api_read_csv.Core;
using Project_api_read_csv.Services.Interfaces;

namespace Project_api_read_csv.Services
{
    public class ImportService : IImportService
   {
        //A camada service será responsavel por :
        //Validar os dados  
        //Montar uma response 
        //Fazer a conexão como a camara de repositorio
        public ImportService() { }

        public ActionResult<ImportResponse> ImportCsv(ImportRequest request)
        {
            ImportResponse importResponse = new ImportResponse();
            importResponse.import = request.import;

            return importResponse;
        }
    }
}
