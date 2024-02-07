using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Movies
{
    public class AttributesMovie
    {
        public string slug { get; set; }
        public string box_office { get; set; }
        public string budget { get; set; }
        public List<string> cinematographers { get; set; }
        public List<string> directors { get; set; }
        public List<string> distributors { get; set; }
        public List<string> editors { get; set; }
        public List<string> music_composers { get; set; }
        public string poster { get; set; }
        public List<string> producers { get; set; }
        public string rating { get; set; }
        public DateOnly release_date { get; set; }
        public string running_time { get; set; }
        public List<string> screenwriters { get; set; }
        public string summary { get; set; }
        public string title { get; set; }
        public string trailer { get; set; }
        public string wiki { get; set; }
    }
}