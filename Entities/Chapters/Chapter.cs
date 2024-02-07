using Entities.Books;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Chapters
{
    public class Chapter
    {
        public string id { get; set; }
        public string type { get; set; }
        public AttributesChapter attributes { get; set; }
        public LinkChapters links { get; set; }
        public RelationshipsChapter relationships { get; set; }
    }
}
