﻿using Project_read_csv.Services;
using System.Numerics;
using System.Xml.Linq;

namespace Project_read_csv.Domain.Models
{
    public class UploadCsv
    {
        //Model para a criação do objeto 
        public UploadCsv(int id, int tipocodigo, string descricao, decimal estoque,
            decimal precovenda, decimal precocusto, string datahoracadastro)
        {
            Id = id;
            Tipocodigo = tipocodigo;
            Descricao = descricao;
            Estoque = estoque;
            Precovenda = precovenda;
            Precocusto = precocusto;
            Datahoracadastro = datahoracadastro;
        }

        public int Id { get; set; }
        public int Tipocodigo { get; set; }
        public string Descricao { get; set; }
        public decimal Estoque { get; set; }
        public decimal Precovenda { get; set; }
        public decimal Precocusto { get; set; }
        public string Datahoracadastro { get; set; }

        
        //Metodo implicito para a conversão do csv
        public static implicit operator UploadCsv(string line)
        {
            var data = line.Split(";");
            return new UploadCsv(
                Int32.Parse(data[0]),
                Int32.Parse(data[1]),
                data[2],
                decimal.Parse(data[3]),
                decimal.Parse(data[4]),
                decimal.Parse(data[5]),
                data[6]);
        }
    }
}
