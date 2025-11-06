using Tyuiu.BabenkovTO.Sprint5.Task2.V28.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #5 | Выполнил: Бабенков Т. О. | ИИПб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема: Класс File. Запись структурированных данных в текстовый файл      *");
        Console.WriteLine("* Задание #2                                                              *");
        Console.WriteLine("* Вариант #28                                                             *");
        Console.WriteLine("* Выполнил: Бабенков Трофим Олегович | ИИПб-25-1                          *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан двумерный целочисленный массив 3 на 3 элементов, заполненный        *");
        Console.WriteLine("* значениями с клавиатуры. Заменить положительные элементы массива на 1,  *");
        Console.WriteLine("* отрицательные на 0. Результат сохранить в файл OutPutFileTask2.csv и    *");
        Console.WriteLine("* вывести на консоль.                                                       *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        int[,] mtrx = new int[3, 3] {{-5, -2, -5},
                                      {3, 1, -3},
                                     {9, -2, -9}};
        for(int i = 0; i <= mtrx.GetUpperBound(0); i++)
        {
            for (int j = 0; j <= mtrx.GetUpperBound(1); j++)
            {
                Console.Write(mtrx[i, j] + " ");
            }
            Console.Write("\n\r");
        }
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        DataService ds = new DataService();
        string res = ds.SaveToFileTextData(mtrx);
        Console.WriteLine($"Файл: {res} \n\r Создан");
    }
}