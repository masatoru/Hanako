using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hanako.Models
{
    public class HKWaxPage : IHKWaxPage
    {
        public HKWaxPage(int page)
        {
            Lines = new List<HKWaxLine>();
            Page = page;
            CanDraw = false;
        }

        public IList<HKWaxLine> Lines { get; set; }
        public int Page { get; set; }
        public bool CanDraw { get; set; }
    };
}