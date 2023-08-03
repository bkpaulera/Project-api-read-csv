using Microsoft.AspNetCore.Components.Forms;
using Project_read_csv.Domain.Models;
using Project_read_csv.Domain.Response;

namespace Project_read_csv.Services
{
    public class UploadCsvService 
    {
        public async Task<List<UploadCsvResponse>> GetCsvAsync(InputFileChangeEventArgs filecsv)
        {
            var file = filecsv.File;
            string fileContent;
            UploadCsv uploadCsvService;
            var uploadCsvList = new List<UploadCsv>();
            List<UploadCsvResponse> uploadCsvResponse = new List<UploadCsvResponse>();

            using (var stream = file.OpenReadStream())
            using (var reader = new StreamReader(stream))
            {
                fileContent = await reader.ReadToEndAsync();
            }
            
           var rows = fileContent.Split(new char[] { '\r','\n'});
            try
            {
                foreach(var line in rows)
                {
                    if (line == rows[0] || line =="")
                        continue;
                    uploadCsvService = line;
                    uploadCsvResponse.Add(uploadCsvService);
                }
            }
            catch(Exception ex) {
                Console.WriteLine(ex);
            }

            return uploadCsvResponse;
        }
    }
}
