using System;
using System.Collections.Generic;

#nullable disable

namespace RepositoryPatternUnitoWorkCruds.Models
{
    public partial class Director
    {
        public Director()
        {
            Movies = new HashSet<Movie>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual ICollection<Movie> Movies { get; set; }
    }
}
