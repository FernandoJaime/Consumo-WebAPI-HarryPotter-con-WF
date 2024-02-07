using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Books
{
    public class AttributesBook
    {
        public string slug { get; set; }
        public string author { get; set; }
        public string cover { get; set; }
        public string dedication { get; set; }
        public int pages { get; set; }
        public DateOnly release_date { get; set; }
        public string summary { get; set; }
        public string title { get; set; }
        public string wiki { get; set; }
    }
}