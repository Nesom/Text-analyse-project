using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextProject
{
    public class FunctionClass<T>
    {
        static void Main(string[] args)
        {
            var keyWords = new Dictionary<T, int>();
            
            PrintKeyWords(keyWords);
        }

        static IEnumerable<T> PrintKeyWords(Dictionary<T, int> keyWords)
        {
            if (keyWords == null)
                return new List<T>();

            keyWords.OrderByDescending(x => x.Value);
            int count = 0;
            int max = int.MinValue;
            var flag = true;
            int value = 0;
            // при маленьких входных данных обвал может быть нестабилен (не являться гаранией корректности результата)
            if (keyWords.Values.First() < 6 && keyWords.Values.First() > 2)
                return keyWords
                    .Where(x => x.Value > 2)
                    .Select(x => x.Key)
                    .ToList();
            // ищу с какой позиции обвал по количеству встречаемости
            foreach (var n in keyWords.Values)
            {
                if (flag)
                {
                    value = n;
                    flag = false;
                    continue;
                }
                if (value - n > max) max = value - n; // через разность текущего и следущего слова
                value = n;
                count++;
            }

            return keyWords
                .Select(x => x.Key)
                .Take(count)
                .ToList();
        }
    }
}
