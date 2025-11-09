using Tyuiu.BabenkovTO.Sprint5.Task5.V16.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #5 | Выполнил: Бабенков Т. О. | ИИПб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема: Чтение набора данных из текстового файла                          *");
        Console.WriteLine("* Задание #5                                                              *");
        Console.WriteLine("* Вариант #16                                                             *");
        Console.WriteLine("* Выполнил: Бабенков Трофим Олегович | ИИПб-25-1                          *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Найти максимальное целое число в файле, которое делится на 10.          *");
        Console.WriteLine("* Полученный результат вывести на консоль.Округлить до трёх знаков        *");
        Console.WriteLine("* после запятой.                                                          *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        string path = Path.Combine(new string[] { "C:", "DataSprint5", "InPutDataFileTask5V16.txt" });
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        DataService ds = new DataService();
        double res = ds.LoadFromDataFile(path);
        Console.WriteLine($"Максимальное число, которое делится на 10: {res}");
    }
}