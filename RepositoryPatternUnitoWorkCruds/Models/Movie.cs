using System;
using System.Collections.Generic;

#nullable disable

namespace RepositoryPatternUnitoWorkCruds.Models
{
    public partial class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Language { get; set; }
        public int? Rating { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public int GeneroId { get; set; }
        public int DirectorId { get; set; }

        public virtual Director Director { get; set; }
        public virtual Genero Genero { get; set; }
    }
}
