using Entities.Chapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Movies
{
    public class Movie
    {
        public string id { get; set; }
        public string type { get; set; }
        public AttributesMovie attributes { get; set; }
        public LinkMovies links { get; set; }
    }
}
