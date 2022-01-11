using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Movie : IEntity
    {
        public int Id { get; set; }
        public string OriginalLanguage { get; set; }
        public string OriginalTitle { get; set; }
        public string Overview { get; set; }
        public double Popularity { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Title { get; set; }
        public double VoteAverage { get; set; }
        public int VoteCount { get; set; }

    }
}
