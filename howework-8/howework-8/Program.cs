using System;
using System.Collections.Generic;
using System.Linq;

namespace homework_8
{
    class Film
    {
        public string Name { get; set; }
        public int Year { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var films = new List<Film>
            {
                new Film { Name = "Jaws", Year = 1975},
                new Film { Name = "Singing in the Rain", Year = 1952 },
                new Film { Name = "Some like it Hot", Year = 1959 },
                new Film { Name = "Wizard of Oz", Year = 1939 },
                new Film { Name = "It’s a Wonderful Life", Year = 1946 },
                new Film { Name = "American Beauty", Year = 1999 },
                new Film { Name = "High Fidelity", Year = 2000 },
                new Film { Name = "The Usual Suspects", Year = 1995 }
            };
            //Coздание многократно используемого делегата для вывода списка в консоль
            Action<Film> print = film => Console.WriteLine($"Name={film.Name}, Year={film.Year}");

            //Вывод в консоль исходного списка
            //films.ForEach(print);

            //Создание и вывод отфильтрованного списка
            //films.FindAll(film => film.Year < 1960).ForEach(print);

            //Cортировка исходного списка. Две опции
            films.Sort((f1, f2) => f1.Name.CompareTo(f2.Name));
            films.OrderBy(film => film.Name);

            //OrderByDescending, Skip, SkipWhile, Take, TakeWhile, Select, Concat
            {
                int[] n = { 1, 3, 5, 6, 3, 6, 7, 8, 45, 3, 7, 6 };
                IEnumerable<int> res;
                res = n.OrderByDescending(g => g).Skip(3);
                res = n.OrderByDescending(g => g).Take(3);
                res = n.Select(g => g * 2);
                //deleting 45 from array
                res = n.TakeWhile(g => g != 45).Concat(n.SkipWhile(s => s != 45).Skip(1));
            }

            //Дана последовательность непустых строк.
            //Объединить все строки в одну.
            {
                List<string> str = new List<string> { "1qwerty", "cqwertyc", "cqwe", "c" };
                string amount = str.Aggregate((x, y) => x + y);
            }

            //Дано целое число L (> 0) и строковая последовательность А.
            //Вывести последнюю строку из А, начинающуюся с цифры и имеющую длину L.
            //Если требуемых строк в последовательности А нет, то вывести строку "Not found".
            //Для обработки ситуации, когда требуемые строки отсутствуют - использовать ??
            {
                int length = 8;
                List<string> str = new List<string> { "1qwerty", "2qwerty", "7qwe" };
                string res = str.FirstOrDefault(x => (Char.IsDigit(x[0])) && (x.Length == length)) ?? "Not found";
            }

            //Дан символ С и строковая последовательность А.
            //Найти количество элементов A, которые содержат более одного символа и
            //при этом начинаются и оканчиваются символом С.
            {
                char c = 'c';
                List<string> str = new List<string> { "1qwerty", "cqwertyc", "cqwe", "c" };
                int amount = str.Count(x => x.StartsWith(c.ToString()) && x.EndsWith(c.ToString()) && x.Length > 1);
            }

            //Дана строковая последовательность.
            //Найти сумму длин всех строк, входящих в данную последовательность.
            //TODO
            {
                List<string> str = new List<string> { "javascript", "java", "python", "c#" };
                var sum = str.Aggregate((x, y) => x + y).Length;
            }

            //Дана последовательность непустых строк.
            //Получить строку, состоящую из начальных символов всех строк исходной последовательности.
            //TODO
            {
                List<string> str = new List<string> { ".com", "Nugget", "Element", "Typescript" };
                var result = str.Select(x => x[0].ToString()).Aggregate((x, y) => x + y);
            }

            //Дано целое число К (> 0) и целочисленная последовательность А.
            //Найти теоретико-множественную разность двух фрагментов А: первый содержыт все чётные числа,
            //а второй все числа с порядковыми номерами, большими К.
            //В полученной последовательности (не содержащей одинаковых элементов) поменять порядок элементов на обратный.
            {
                int k = 5;
                IEnumerable<int> n = new int[] { 12, 88, 1, 3, 5, 4, 6, 6, 2, 5, 8, 9, 0, 90 };
                var res = n.Where(x => x % 2 == 0).Except(n.Skip(k)).Reverse();
            }

            //Дано целое число К (> 0) и строковая последовательность А.
            //Строки последовательности содержат только цифры и заглавные буквы латинского алфавита.
            //Извлечь из А все строки длины К, оканчивающиеся цифрой, отсортировав их по возрастанию.
            //TODO
            {
                int k = 5;
                List<string> str = new List<string> { "HTML5", "CSS03", "ECMASCRIPT6", "GIT" };
                var res = str.Where(x => x.Length == k && Char.IsDigit(x[x.Length - 1])).OrderBy(x => x);
            }

            //Даны целые числа D и K (К > 0) и целочисленная последовательность А.
            //Найти теоретико-множественное объединение двух фрагментов А: первый содержит все элементы до первого элемента,
            //большего D (не включая его), а второй все элементы, начиная с элемента с порядковым номером K.
            // Полученную последовательность (не содержащую одинаковвых элементов) отсортировать по убыванию.
            //TODO
            {
                int d = 14;
                int k = 6;
                IEnumerable<int> a = new int[] { 13, 7, 2, 15, 12, 43, 56, 1, 7, 34 };
                var res = a.TakeWhile(x => x < d).Union(a.Skip(k - 1)).OrderByDescending(x => x);
            }

            //Дана последовательность положительных целых чисел.
            //Обрабатывая только нечетные числа, получить последовательность их строковых
            //представлений и отсортировать её по возрастанию.
            {
                IEnumerable<int> n = new int[] { 12, 88, 1, 3, 5, 4, 6, 2, 5, 8, 9, 0, 90 };
                var res = n.Where(x => x % 2 != 0).Select(x => x.ToString()).OrderBy(x => x);
            }

            //Дана последовательность непустых строк.
            //Получить последовательность символов, которая определяется следующим образом:
            //если соответствующая строка исходной последовательности имеет нечетную длину, то в качестве
            //символа берется первый символ этой строки; в противном случае берется последний символ строки.
            //Отсортировать полученные символы по убыванию их кодов.
            //TODO
            {
                List<string> str = new List<string> { "javascript", "java", "python", "c#", "c++" };
                var res = str.Select(x => (x.Length % 2 != 0) ? (x[0]) : (x[x.Length - 1])).OrderByDescending(x => x);
            }

            //Даны целые числа К1 и К2 и целочисленные последовательности А и В.
            //Получить последовательность, содержащую все числа из А, большие К1, и все числа из В, меньше К2.
            //Отсортировать полученные последовательности по возрастанию.
            //TODO
            {
                int k1 = 7;
                int k2 = 14;
                IEnumerable<int> a = new int[] { 78, 88, 1, 3, 5, 4, 6, 2, 5, 98, 0, 98 };
                IEnumerable<int> b = new int[] { 13, 7, 2, 15, 12, 43, 56, 1, 7, 34 };
                var result = a.Where(x => x > k1).Concat(b.Where(x => x < k2)).OrderBy(x => x);
            }

            //Даны последовательности положительных целых чисел А и В; все числа в каждой последовательности различны.
            //Найти последовательность всех пар чисел, соответствующих условиям:
            //первый элемент пары принадлежит последовательности А, второй принадлежит В, и оба элемента оканчиваются одной и той же цифрой.
            //Результирующая последовательность называется внутренним объединением последовательностей А и В по ключу,
            //определяемому последними цифрами исходных чисел.
            //Представить найденное объединение в виде последовательности строк, содержащих первый и второй элементы пары, разделённые дефисом, например, "49 - 129".
            {
                IEnumerable<int> n1 = new int[] { 12, 88, 11, 3, 55, 679, 222, 845, 9245 };
                IEnumerable<int> n2 = new int[] { 123, 888, 551, 443, 69, 222, 780 };
                var res = n1.Join(n2, x => x % 10, y => y % 10, (x, y) => x.ToString() + " - " + y.ToString());
            }

            //Даны строковые последовательности А и В; все строки в каждой последовательности различны,
            //имеют ненулевую длину и содержат только цифры и заглавные буквы латинского алфавита.
            //Найти внутреннее объединение А и В, каждая пара которого должна содержать строки одинаковой длины.
            //Представить найденное объединение в виде последовательнсоти строк, содержащих первый и второй элементы пары,
            //разделенные двоеточием, например "АВ: СВ". Порядок следования пар должен определяться порядком
            //первых элементов пар (по возрастанию), а для равных элементов - порядком вторых элементов пар (по убыванию).
            //TODO
            {
                IEnumerable<string> a = new string[] { "8ANGULAR", "2REACT16", "JAVASCRIPT" };
                IEnumerable<string> b = new string[] { "FRONTEND", "FRONTEND", "AUTOMATION" };
                var res = b.Join(a  ,
                                 x => x.Length,
                                 y => y.Length,
                                 (x, y) => x.ToString() + " : " + y.ToString()).
                                 OrderBy(x => x).ThenByDescending(x => x);
                foreach (var i in res)
                {
                    Console.WriteLine(i);
                }
            }

            //Дана целочисленная последовательность А.
            //Сгрупировать элементы последовательности А, оканчивающиеся одной и той же цифрой, и на основе этой группировки
            //получить последовательность строк вида "D : S", где D - ключ группировки (т.е. некоторая цифра, которой оканчивается
            //хотя бы одно из чисел последовательности А), а S - сумма всех чисел из А, которые оканчиваются цифрой D.
            //Полученную последовательность упорядочить по возрастанию ключей.
            //Иcпользовать метод GroupBy.
            {
                IEnumerable<int> n = new int[] { 12, 88, 11, 3, 55, 679, 222, 845, 9245 };
                List<string> res = new List<string>();
                IEnumerable<IGrouping<int, int>> groups = n.GroupBy(x => x % 10).OrderBy(x => x.Key);
                foreach (IGrouping<int, int> group in groups)
                {
                    string listElement = group.Key.ToString();
                    int summaryValue = 0;
                    foreach (int item in group)
                    {
                        summaryValue += item;
                    }
                    listElement = listElement + ": " + summaryValue.ToString();
                    res.Add(listElement);
                }
            }

            //Исходная последовательность содержит сведения об абитуриентах. Каждый элемент последовательности
            //включает следующие поля: <Номер школы> <Год поступления> <Фамилия>
            //Для каждого года, присуттствующего в исходных данных, вывести число различных школ, которые окончили абитуриенты,
            //поступившие в этом году (вначале указывать число школ, затем год).
            //Сведения о каждом годе выводить на навой строке и упрорядочивать по возрастанию числа школ,
            //а для совпадающих чисел - по возрастанию номера года.
            //TODO
            {

            }

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
