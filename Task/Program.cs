/*Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []*/

Console.WriteLine("Введите элементы массива, разделенные пробелом:");
        string[] arr = Console.ReadLine().Split();

        // Подсчитываем количество строк длиной <= 3
        int count = 0;
        foreach (string str in arr)
        {
            if (str.Length <= 3)
                count++;
        }

        // Создаем массив нужного размера и заполняем его строками длиной <= 3
        string[] result = new string[count];
        int index = 0;
        foreach (string str in arr)
        {
            if (str.Length <= 3)
                result[index++] = str;
        }

        // Выводим полученный массив
        Console.WriteLine("Результат:");
        foreach (string str in result)
        {
            Console.WriteLine(str);
        }
    
