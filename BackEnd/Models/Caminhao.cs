using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
namespace BackEnd.Models
{
    public class Caminhao
    {
        [Key]
        public int _id { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [MinLength(7, ErrorMessage = "Este campo deve conter entre 7 e 8 caracteres")]
        [MaxLength(8, ErrorMessage = "Este campo deve conter entre 7 e 8 caracteres")]
        public string _placa { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        public double _capacidadeCarga { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        public int _quantidadeEixos { get; set; }
        public IEnumerable<Motorista> _motoristas { get; set; }

        public Caminhao(
            int id,
            string placa,
            double capacidadeCarga,
            int quantidadeEixos
            )
        {
            this._id = id;
            this._placa = placa;
            this._capacidadeCarga = capacidadeCarga;
            this._quantidadeEixos = quantidadeEixos;
        }
    }
}