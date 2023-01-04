using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexComparer.Models
{
    internal class CompareResults
    {
        public String EmailAddress { get; set; }
        public RegexComparison OriginalRegexComparison { get; set; }
        public RegexComparison NewRegexComparison { get; set; }
    }
}
