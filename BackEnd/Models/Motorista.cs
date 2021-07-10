using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BackEnd.Models
{
    public class Motorista
    {
        [Key]
        public int _id { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        [MinLength(2, ErrorMessage = "O campo deve conter de 2 a 50 caracteres")]
        [MaxLength(50, ErrorMessage = "O campo deve conter de 2 a 50 caracteres")]
        public string _nome { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        [MinLength(2, ErrorMessage = "O campo deve conter de 2 a 100 caracteres")]
        [MaxLength(100, ErrorMessage = "O campo deve conter de 2 a 100 caracteres")]
        public string _sobrenome { get; set; }
        [Required(ErrorMessage = "Campo obrigatório")]
        [MinLength(11, ErrorMessage = "O campo deve conter 11 caracteres")]
        [MaxLength(11, ErrorMessage = "O campo deve conter 11 caracteres")]
        public string _cpf { get; set; }

        public Motorista(int id, string nome, string sobrenome, string cpf)
        {
            this._id = id;
            this._nome = nome;
            this._sobrenome = sobrenome;
            this._cpf = cpf;
        }
    }
}