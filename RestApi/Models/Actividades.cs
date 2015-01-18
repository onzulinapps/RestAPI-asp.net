using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace RestApi.Models
{
    [Table("actividades")]
    public class Actividades
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public Int64 id { get; set; }
        public string nombre { get; set; }
        public string informacion { get; set; }
        public string direccion { get; set; }
        public DateTime horarioinicial { get; set; }
        public DateTime horariofinal { get; set; }
        public string latitud { get; set; }
        public string longitud { get; set; }
        public string altitud { get; set; }
        //precision = accuracy
        public string accuracy { get; set; }

        public Int64 idusuario { get; set; }
        public virtual Usuarios Usuarios { get; set; }
        
        
        
    }
}