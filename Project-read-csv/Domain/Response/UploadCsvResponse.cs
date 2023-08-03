using Project_read_csv.Domain.Models;

namespace Project_read_csv.Domain.Response
{
    public class UploadCsvResponse
    {
        public UploadCsvResponse(UploadCsv uploadCsv, decimal valorTotal) { 
            UploadCsv = uploadCsv;
            ValorTotal = valorTotal;
        }

        public UploadCsv UploadCsv { get; set; }
        public decimal ValorTotal { get; set;}

        public static implicit operator UploadCsvResponse(UploadCsv file)
        {
            return new UploadCsvResponse(
                file,
                file.Precocusto*file.Estoque 
                );
        }
    }
}
