using RegexComparer.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexComparer.Workers
{
    internal static class WorkFlow
    {
        public static RegexComparison DoRegexMatch(String emailAddress, String regexPattern)
        {
            RegexComparison regexComparison= new RegexComparison();
            Stopwatch timer = new Stopwatch();

            timer.Start();
            regexComparison.IsMatch = Regex.IsMatch(emailAddress, regexPattern);
            timer.Stop();

            regexComparison.TimeTaken = timer.Elapsed;

            return regexComparison;
        }

        public static CompareResults DoRegexComparison(String emailAddress, String originalPattern, String newPattern)
        {
            CompareResults compareResults= new CompareResults();

            compareResults.EmailAddress = emailAddress;
            compareResults.OriginalRegexComparison = DoRegexMatch(emailAddress, originalPattern);
            compareResults.NewRegexComparison =DoRegexMatch(emailAddress, newPattern);

            return compareResults;
        }

        public static List<String> GetEmailAddressList()
        {
            return new List<String>() { "test@gmail.com", "4324324324324324", "...", "this@notanemail444", "4445435435435435454@com", "test@yahoo.com"};
        }

        public static String FormatResults(CompareResults compareResults)
        {
            return String.Format($"{compareResults.EmailAddress}, {compareResults.OriginalRegexComparison.IsMatch}, {compareResults.OriginalRegexComparison.TimeTaken.ToString(@"m\:ss\.fff")}, {compareResults.NewRegexComparison.IsMatch}, {compareResults.NewRegexComparison.TimeTaken.ToString(@"m\:ss\.fff")}");
        }
    }
}
