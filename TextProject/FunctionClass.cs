using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextProject
{
    public class FunctionClass<T>
    {
        public static List<T> GetKeys(Dictionary<T, int> dict)
        {
            dict.OrderByDescending(x => x.Value);
            var count = 0;// сколько ключевых слов
            if (dict.Count < 6 && dict.Count > 2)
            {// на маленьких словарях резкий упадок частоты не может гарантировать корректность результата
                count = 3;// пример ильдара показал, что ближе всего число 3
            }
            else
            {
                var max = int.MinValue;
                int prev = 0;
                var index = 0;
                foreach (var value in dict.Values)
                {// резкий упадок
                    if (prev - value > max)
                    {
                        max = prev - value;
                        count = index;
                    }
                    index++;
                    prev = value;
                }
            }

            return dict
                    .Select(x => x.Key)
                    .Take(count)
                    .ToList();
        }
    }
}
