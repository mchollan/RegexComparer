using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexComparer.Models
{
    internal class RegexComparison
    {
        public Boolean IsMatch { get; set; }
        public TimeSpan TimeTaken { get; set; }

    }
}
