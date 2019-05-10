using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie
{
    public class TextAnalyzer
    {
        public static List<string> Analyze(string text)
        {
            var d = AnalyseHelper.GetFrequency(text);
            var pointlessWord = AnalyseHelper.GetPointlessWords();
            d.Where(x => !pointlessWord.Contains(x.Key));
            var collectIndex = AnalyseHelper.AnalizeDict().Select(x => x.Value);
            var collectWord = AnalyseHelper.AnalizeDict().Select(x => x.Key).ToArray();

            //var govno = AnalyseHelper.GetFrequencySyn(text, AnalyseHelper.AnalizeDict()) ;
            //var normgovno = govno.Select(x =>
            //{
            //    var t = new KeyValuePair<string, int>(collectWord[x.Key], x.Value);
            //    return t;
            //});
            //normgovno.Where(x => !pointlessWord.Contains(x.Key));

            return FunctionClass<string>.GetKeys(d.Where(x => !pointlessWord.Contains(x.Key)).ToDictionary(x => x.Key, x => x.Value));
        }
    }
}
