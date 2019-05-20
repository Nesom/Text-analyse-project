using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace MvcMovie
{
    public static class AnalyseHelper
    {
        //вспомогательный метод, его не нужно использовать, он парсит текст в хэшсет
        public static HashSet<string> GetPointlessWords()
        {
            var words = File.ReadAllText("pointlesswords.txt");//имя файла из которого берем ненужные слова
            var separator = new[] { ',' };
            //var list = words
            //.Split(separator)
            //.Select(x => x.ToLower())
            //.Distinct().Where(x => x != "")
            //.OrderBy(x => x)
            //.ToList();
            //var t = list.Select(x => x + ",").SelectMany(x => x).ToArray();
            //File.WriteAllText("newWords.txt",new string(t) );
            var list = words.Split(separator);
            var hashset = new HashSet<string>(list);//результат
                                                    //foreach (var item in hashset)
                                                    //Console.WriteLine(item);
            return hashset;
        }

        //сериализует ненужные слова
        public static void SerializerHashset(HashSet<string> hash)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("pointlessWords.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, hash);
            stream.Close();
        }

        //возвращает словарь ненужных слов из файла
        public static HashSet<string> DeserializerPWords()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("pointlessWords.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
            var hash = (HashSet<string>)formatter.Deserialize(stream);
            stream.Close();
            return hash;
        }

        //сериализует словарь
        public static void SerializerDict(Dictionary<string, List<int>> dict)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("dictionary.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, dict);
            stream.Close();
        }

        //возвращает словарь из файла
        public static Dictionary<string, List<int>> DeserializerDict()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("dictionary.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
            var dict = (Dictionary<string, List<int>>)formatter.Deserialize(stream);
            stream.Close();
            return dict;
        }

        // парсит в коллекцию слов
        public static IEnumerable<string> ParseText(string text)
        {
            var separator = new[] { ',', ' ', '.', '?', '!', '"', '\'', '(', ')', ':', ';', '\t', '\n', '\r', '\"', '\\', '#', '*' };
            return text
                .Split(separator)
                .Where(x => x != "")
                .Select(x => x.ToLower().GetInitialForm());
        }

        //выдвет словарь <слово, частота>
        public static Dictionary<string, int> GetFrequency(string text)
        {
            var dict = new Dictionary<string, int>();
            foreach (var word in ParseText(text))
            {
                if (!dict.ContainsKey(word))
                    dict[word] = 1;
                else
                    dict[word]++;
            }
            return dict;
        }

        //выдает словарь <индекс коллекции синонимов, частота>
        //public static Dictionary<int, int> GetFrequencySyn(string text, Dictionary<string, List<int>> dict)
        //{
        //    var result = new Dictionary<int, int>();
        //    var subDict = new Dictionary<string, int>();
        //    foreach (var word in ParseText(text))
        //    {
        //        if (dict.ContainsKey(word))
        //        {
        //            foreach (var index in dict[word])
        //            {
        //                if (!result.ContainsKey(index))
        //                {
        //                    result[index] = 1;
        //                }
        //                else
        //                    result[index]++;
        //            }
        //        }
        //        else
        //        {
        //            if (!subDict.ContainsKey(word))
        //                subDict[word] = 1;
        //            else
        //                subDict[word]++;
        //        }
        //    }
        //    result.OrderBy(x => x.Value);
        //    subDict.OrderBy(x => x.Value);
        //    return result;
        //}
        public static Dictionary<string, int> GetNormalFrequencyOfSyno2(string text, Dictionary<string, List<string>> wordToSyns)
        {//работающая херная для синонимов , dict надо вводить из метода DeserializerDict()
            var result = new Dictionary<string, int>();
            var textInitial = (ParseText(text));
            foreach (var word in textInitial)
            {
                if (wordToSyns.ContainsKey(word))
                {
                    foreach (var syn in wordToSyns[word])
                    {
                        if (!textInitial.Contains(syn)) continue;//если синонима нет в тексте
                        if (!result.ContainsKey(syn))
                            result[syn] = 0;
                        result[syn]++;
                    }
                }
                if (!result.ContainsKey(word))
                    result[word] = 0;
                result[word]++;
            }
            return result;
        }

        //сортирует словарь
        public static Dictionary<string, int> GetOrderDict(Dictionary<string, int> dict)
        {
            return (Dictionary<string, int>)dict.OrderBy(x => x.Value);
        }

        //public static Dictionary<string, List<int>> AnalizeDict()//выдает словарь синонимов из большого текста
        //{
        //    var separator = new char[] { ',', '.', ':', '\n' };
        //    var result = new Dictionary<string, List<int>>();
        //    var text = File.ReadAllText("dict.txt");
        //    var t = text
        //        .Split('=')
        //        .Select(list => list
        //        .Split(separator)
        //        .TakeWhile(word => word != "ANT")
        //        .Where(word => word != "" && word != "SYN" && word != "KEY")
        //        .Select(word => word.ToLower().Trim()))
        //        .ToArray();
        //    for (int i = 0; i < t.Count(); i++)
        //    {
        //        foreach (var word in t[i])
        //        {
        //            if (!result.ContainsKey(word))
        //                result[word] = new List<int>();
        //            result[word].Add(i);
        //        }
        //    }
        //    return result;
        //}

        public static Dictionary<string, List<string>> AnalizeDict2()//выдает словарь синонимов из большого текста
        {
            var separator = new char[] { ',', '.', ':', '\n' };
            var result = new Dictionary<string, List<string>>();
            var text = File.ReadAllText("dict.txt");
            var listOfList = text
             .Split('=')
             .Select(list => list
             .Split(separator)
        .TakeWhile(word => word != "ANT")
        .Where(word => word != "" && word != "SYN" && word != "KEY")
        .Select(word => word.ToLower().Trim()))
        .ToArray();
            for (int i = 0; i < listOfList.Count(); i++)
            {
                var syn = listOfList[i].FirstOrDefault();
                if (syn == null) continue;
                foreach (var word in listOfList[i])
                {
                    if (!result.ContainsKey(word))
                        result[word] = new List<string>();
                    result[word].Add(syn);
                }
            }
            return result;
        }
    }

}
