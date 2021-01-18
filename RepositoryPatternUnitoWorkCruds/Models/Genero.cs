using System;
using System.Collections.Generic;

#nullable disable

namespace RepositoryPatternUnitoWorkCruds.Models
{
    public partial class Genero
    {
        public Genero()
        {
            Movies = new HashSet<Movie>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Movie> Movies { get; set; }
    }
}
