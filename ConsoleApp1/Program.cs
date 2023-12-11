using System;
using System.Collections;

class Program
{
    static void Main()
    {
        ArrayList list = new ArrayList();
        Random random = new Random();

        // a) Заполняем коллекцию 5 случайными целыми числами
        for (int i = 0; i < 5; i++)
        {
            int randomNumber = random.Next();
            list.Add(randomNumber);
        }

        // b) Добавляем строку к коллекции
        string additionalString = "Дополнительная строка";
        list.Add(additionalString);

        // c) Удаляем элемент по значению
        int elementToRemove = 42; // Значение для удаления
        list.Remove(elementToRemove);

        // d) Выводим количество элементов в коллекции
        int count = list.Count;
        Console.WriteLine("Количество элементов в коллекции: " + count);

        // Выводим содержимое коллекции
        Console.WriteLine("Содержимое коллекции:");
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }

        // e) Выполняем поиск заданного значения в коллекции
        int valueToFind = (int)3.14;

        int index = list.IndexOf(valueToFind);

        if (index != -1)
        {
            Console.WriteLine("Значение " + valueToFind + " найдено в коллекции на позиции " + index);
        }
        else
        {
            Console.WriteLine("Значение " + valueToFind + " не найдено в коллекции.");
        }
    }
}
