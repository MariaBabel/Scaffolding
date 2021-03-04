using System;
using System.Collections.Generic;

#nullable disable

namespace Scaffolding.Entities
{
    public partial class Sigma
    {
        public int Id { get; set; }
        public int BuqueId { get; set; }
        public string TipoDocSigma { get; set; }
        public string Nsigma { get; set; }
        public int SecuSigma { get; set; }
        public string Titupara { get; set; }
        public string Titude { get; set; }
        public string Tipomate { get; set; }
        public DateTimeOffset FechaCreacion { get; set; }
        public DateTimeOffset? FechaModificacion { get; set; }
        public string UsuarioCreacion { get; set; }
        public string UsuarioModificacion { get; set; }

        public virtual Buque Buque { get; set; }
    }
}
