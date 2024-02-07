using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.GenericClass
{
    public class Data<T>
    {
        public List<T> data { get; set; }
        public Links links { get; set; }
        public Meta meta { get; set; }
    }
}