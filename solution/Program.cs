Console.Clear();
Console.WriteLine("Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо\nравна 3 символам. Первоначальный массив ввести с клавиатуры. При решении не рекомендуется пользоваться коллекциями.");
Console.WriteLine("Примеры: [\"hello\", \"2\", \"world\", \":)\"] -> [\"2\", \":)\"]\n\t [\"1234\", \"1567\", \"-2\", \"computer science\"] -> [\"-2\"]\n\t [\"Russia\", \"Denmark\", \"Kazan\"] -> []");
string[] enterArray() 
{
    Console.WriteLine("Введите несколько элементов текстового массива через пробел, в конце нажмите ввод:");
    return Console.ReadLine().Split(" ");
}
string [] SortArray (string [] array)
{
	int count = 0;
	string arrayValue = string.Empty;
	for (int i = 0; i < array.Length; i++)
	{
		arrayValue = array[i];
		if (arrayValue.Length <= 3) count++;
	}

	string [] endArray = new string [count];
	int index = 0;
	for (int i = 0; i < array.Length; i++)
	{
		arrayValue = array[i];
		if (arrayValue.Length <= 3)
		{
			endArray[index] = array[i];
			index++;
		}
	}
	return endArray;
}
void printArray(string [] incomingArray)
{
    if (incomingArray.Length == 0) Console.Write("В массиве нет ни одного элемента! ");
    Console.Write("[");
    for (int i = 0; i < incomingArray.Length; i++)
    {
        Console.Write($"\"{incomingArray[i]}\"");
        if (i < incomingArray.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
}
string[] firstArray = enterArray();
string [] endArray = SortArray(firstArray);
Console.Write("Исходный массив: ");
printArray(firstArray);
Console.Write("  ->  Итоговый массив: ");
printArray(endArray);
