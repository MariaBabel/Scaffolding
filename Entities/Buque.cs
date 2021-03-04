using System;
using System.Collections.Generic;

#nullable disable

namespace Scaffolding.Entities
{
    public partial class Buque
    {
        public Buque()
        {
            Sigmas = new HashSet<Sigma>();
        }

        public int Id { get; set; }
        public string Denominacion { get; set; }
        public string TipoBi { get; set; }
        public string MarCos { get; set; }
        public float Eslora { get; set; }
        public float Manga { get; set; }
        public DateTimeOffset FechaCreacion { get; set; }
        public DateTimeOffset? FechaModificacion { get; set; }
        public string UsuarioCreacion { get; set; }
        public string UsuarioModificacion { get; set; }

        public virtual ICollection<Sigma> Sigmas { get; set; }
    }
}
