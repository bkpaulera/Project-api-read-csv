using Microsoft.AspNetCore.Components.Forms;
using Project_read_csv.Domain.Models;
using Project_read_csv.Domain.Response;

namespace Project_read_csv.Services
{
    public class UploadCsvService 
    {
        //Receber um arquvio csv e devolver uma response
        public async Task<List<UploadCsvResponse>> GetCsvAsync(InputFileChangeEventArgs filecsv)
        {
            var file = filecsv.File; 
            string fileContent;
            UploadCsv uploadCsvService;
            List<UploadCsvResponse> uploadCsvResponse = new List<UploadCsvResponse>();

            //Leitura do CSV
            using (var stream = file.OpenReadStream())
            using (var reader = new StreamReader(stream))
            {
                fileContent = await reader.ReadToEndAsync(); //Ler todo o aquivo  csv
            }
            
            var rows = fileContent.Split(new char[] { '\r','\n'}); //Separa por linhas
            try
            {
                foreach(var line in rows)
                {
                    if (line == rows[0] || line =="") //Verifica caso seja o index ou se a linha é vazia
                        continue;
                    //Monta o Objeto para a response
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
