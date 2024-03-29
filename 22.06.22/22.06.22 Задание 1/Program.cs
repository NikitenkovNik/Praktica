﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._06._22_Задание_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> slova = new Dictionary<string, string>();
            slova.Add("Когараси", "Это слово, которое описывает холодный зимний ветер. Данное явление позволяет узнать о наступлении зимы.");
            slova.Add("Celtis", "Слово celtis, означает, судя по контексту(в греческом, и в еврейском тексте Библии), какой-то инструмент для резьбы по камню, например «резец» или «долото». Слово celtis не встречается, кроме перевода Библии, ни в одном античном тексте;");
            slova.Add("Жамевю", "Термин, близкий к психиатрии, антоним дежавю. При жамевю вы находитесь в привычной обстановке или обстоятельствах, в которых неоднократно раньше были, но чувствуете, будто оказались тут впервые.");
            slova.Add("Юрисдикция", "Спектр полномочий, которым обладает государственный орган или структура.");
            slova.Add("Неврастения", "Психогенное заболевание из группы неврозов, основные проявления — раздражительность, слабость.");
            slova.Add("Интроспекция", "Метод познания психических явлений путем самонаблюдения человека, т.е. внимательного изучения самим человеком того, что происходит в его сознании при решении разного рода задач.");
            slova.Add("Хапкидо", "Корейское боевое искусство, на появление которого во многом оказала влияние техника, положенная и в основу айкидо, Дайто-рю Айки-дзюдзюцу. ");
            slova.Add("Лэхвей", "Древнее боевое искусство из Мьянмы. Летхвей считается одним из самых жестоких видов спорта в мире, потому что удары головой разрешены, а борьба ведется голыми руками.");
            slova.Add("Куреш", "Традиционный вид спорта у тюркских народов, национальная борьба на поясах. У башкир, татар и чувашей кураш является важным элементом национальных праздников");
            slova.Add("Канабо", "Оружие самураев феодальной Японии, разновидность тэцубо в виде металлической палицы с круглой рукоятью, имеющей утолщение с кольцом на конце, и, зачастую, дополненной небольшими незаточенными шипами.");
            slova.Add("Басту", "Небольшие деревянные дома, типичные для скандинавских стран - традиционные шведские бани, известные с глубокой древности;");
            slova.Add("Гардарйки", "Норманнское название Руси, известное в Северной Европе в Средние века, в том числе в скандинавских сагах.");
            slova.Add("Преторианцы ", "Личная стража императора в Римской империи.");
            slova.Add("Benyvirus", "Род патогенных для растений вирусов из монотипного семейства Benyviridae, которое не включают в какой-либо из известных порядков вирусов.");
            slova.Add("Ebolavirus", "Род вирусов из семейства филовирусов (Filoviridae), вызывающих геморрагическую лихорадку Эбола у высших приматов.");
            slova.Add("Сакура", "Японская окультуренная вишня, цветущая пышными розовыми цветами; один из символов Японии. Собирательное название 11 видов и нескольких сортов деревьев подсемейства Сливовые");
            slova.Add("Катана", "Длинный японский меч (дайто:). По форме клинка катана напоминает шашку, однако рукоять у неё прямая и длинная, что позволяет использовать двуручный хват. Навершие отсутствует. Небольшой изгиб клинка и острый конец позволяют наносить также и колющие удары.");
            slova.Add("Отпуск", "Технологический процесс, заключающийся в термической обработке закалённого на мартенсит сплава или металла, при которой основными процессами являются распад мартенсита, а также полигонизация и рекристаллизация.");
            slova.Add("Карасунокути", "Трещина в клинке. Если трещина проходит примерно в параллельной плоскости, она делит закалённую и незакалённую части, и если это отражается на форме, то меч становится бракованным.");
            slova.Add("Кэндзюцу", "Японское искусство владения мечом. Зародилось около 1200 лет тому назад с появлением класса воинов.");

            string userInput = "";

            while (true)
            {
                Console.Write("Введите слово: ");
                userInput = Console.ReadLine();

                if (slova.ContainsKey(userInput))
                    Console.WriteLine(slova[userInput]);
                else
                    Console.WriteLine("Слово не найдено");
            }

        }

        public Int32 levenshtein(String a, String b)
        {
            if (string.IsNullOrEmpty(a))
            {
                if (!string.IsNullOrEmpty(b))
                {
                    return b.Length;
                }
                return 0;
            }

            if (string.IsNullOrEmpty(b))
            {
                if (!string.IsNullOrEmpty(a))
                {
                    return a.Length;
                }
                return 0;
            }
            Int32 cost;
            Int32[,] d = new int[a.Length + 1, b.Length + 1];
            Int32 min1;
            Int32 min2;
            Int32 min3;
            for (Int32 i = 0; i <= d.GetUpperBound(0); i += 1)
            {
                d[i, 0] = i;
            }
            for (Int32 i = 0; i <= d.GetUpperBound(1); i += 1)
            {
                d[0, i] = i;
            }
            for (Int32 i = 1; i <= d.GetUpperBound(0); i += 1)
            {
                for (Int32 j = 1; j <= d.GetUpperBound(1); j += 1)
                {
                    cost = Convert.ToInt32(!(a[i - 1] == b[j - 1]));

                    min1 = d[i - 1, j] + 1;
                    min2 = d[i, j - 1] + 1;
                    min3 = d[i - 1, j - 1] + cost;
                    d[i, j] = Math.Min(Math.Min(min1, min2), min3);
                }
            }
            return d[d.GetUpperBound(0), d.GetUpperBound(1)];
        }
    }
}
