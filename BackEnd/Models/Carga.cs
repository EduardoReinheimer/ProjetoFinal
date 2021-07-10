using System.ComponentModel.DataAnnotations;
using static System.Net.Mime.MediaTypeNames;

namespace BackEnd.Models
{
    public class Carga
    {
        [Key]
        public int _id { get; set; }
        public string _descritivoCarga { get; set; }
        public double _pesoCarga { get; set; }

        public Carga(
            int id,
            string descritivoCarga,
             double pesoCarga
            )
        {
            this._id = id;
            this._descritivoCarga = descritivoCarga;
            this._pesoCarga = pesoCarga;
        }
    }
}