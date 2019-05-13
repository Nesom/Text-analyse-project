using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = "rkjkb ikkjbk lblblklk rty rty rty rty  Hold, rвамщзьваы хыьавы fdg fdg fdg fdg estrain, retain, detain, guard, preserve, suppress,\nrepress, conceal, tend, support, maintain, conduct, continue, obey,\nhaunt, observe, frequent, celebrate, protect, adhere_to, practise,\nbinder,";
            var parse = AnalyseHelper.ParseText(t); 
            var len = parse.Count();
            var supDict = AnalyseHelper.AnalizeDict2();
            var dict = AnalyseHelper.GetNormalFrequencyOfSyno2(t, supDict)
                .OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key);
        }
    }
}
