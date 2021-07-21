using System;
using System.Collections.Generic;
using System.Text;

namespace test_task
{
    class Logic
    {
        Dictionary<string, string> numbersTranslate = new Dictionary<string, string> //Создал словарь из цифр
        {
            {"ноль","0"},
            {"один","1"},
            {"одна","1"},
            {"два","2"},
            {"три","3"},
            {"четыре","4"},
            {"пять","5"},
            {"шесть","6"},
            {"семь","7"},
            {"восемь","8"},
            {"девять","9"},
            {"десять","10"},
            {"одиннадцать","11"},
            {"двенадцать","12"},
            {"тринадцать","13"},
            {"четырнадцать","14"},
            {"пятнадцать","15"},
            {"шестнадцать","16"},
            {"семьнадцать","17"},
            {"восемнадцать","18"},
            {"девятнадцать","19"},
            {"двадцать","20"},
            {"тридцать","30"},
            {"сорок","40"},
            {"пятьдесят","50"},
            {"шестьдесят","60"},
            {"семьдесят","70"},
            {"восемьдесят","80"},
            {"девяносто","90"},
            {"сто","100"},
            {"двести","200"},
            {"триста","300"},
            {"четыреста","400"},
            {"пятьсот","500"},
            {"шестьсот","600"},
            {"семьсот","700"},
            {"восемьсот","800"},
            {"девятьсот","900"},
            {"тысяча","1000"},
            {"тысяч","1000"},
            {"миллион","1000000"},
            {"миллионов","1000000"}
        };

        public string FindNumbers(string input)
        {
            string tmp = "", tmpout = "", output = "";
            foreach (string word in input.Split(' '))// Получаем строку и разбиваем ее на слова
            {
                if (numbersTranslate.TryGetValue(word, out tmp)) //Проходим по словарю и следуем по условию
                {
                    if (tmpout != "") tmpout += " ";
                    tmpout += tmp;
                }
                else
                {
                    if (tmpout != "") output += " " + AddNumbers(tmpout);
                    tmpout = "";
                    if (output != "") output += " ";
                    output += word;
                }
            }
            if (tmpout != "")
            {
                tmpout = AddNumbers(tmpout);
                if (output != "") output += " ";
                output += tmpout;
            }
            return output;
        }
        private string AddNumbers(string input)
        {
            int output = 0;
            int output2 = 0;
            foreach (string num in input.Split(' '))
            {
                if (output > 999)
                {
                    output2 = output;
                    output = 0;
                }
                if (Int32.Parse(num) > 999)
                {
                    output = output * Int32.Parse(num);
                }
                else
                {
                    output = output + Int32.Parse(num);
                }
            }
            return (output + output2).ToString();
        }
    }
}
