using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackEnd.Models
{
    public class Pedido
    {
        [Key]
        public int _id { get; set; }
        [ForeignKey("Carga")]
        public int _cargaId { get; set; }
        public string _motoristaId { get; set; }
        public Motorista _motorista { get; set; }
        public Caminhao _caminhao { get; set; }
        public DateTime _datahora { get; set; }
        public string _numeroNfs { get; set; }

        public Pedido(
            int cargaId,
            DateTime datahora,
            string numeroNfs
            )
        {
            this._cargaId = cargaId;
            this._datahora = datahora;
            this._numeroNfs = numeroNfs;
        }
    }
}