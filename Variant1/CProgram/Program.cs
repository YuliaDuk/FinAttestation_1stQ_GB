Console.WriteLine("Введите размер массива из строк: ");
int size = Convert.ToInt32(Console.ReadLine());
if(size<1)
{
    Console.WriteLine("Введите другой размер массива");
}
else
{
string [] array=new string[size];
for (int i = 0; i < size; i++)
{
    Console.WriteLine($"Введите {i} элемент массива");
    array[i]=Console.ReadLine();
}
Console.WriteLine("Задан массив:");
Console.WriteLine('[' + string.Join(',', array) + ']');
Console.WriteLine("Новый массив из строк, длина которых меньше или равна 3 символам:");
Console.Write("[");
for (int i = 0; i < size; i++)
{
    int length=array[i].Length;
    if(length<=3)
    {
        Console.Write(array[i] + ',');
    }
}
Console.Write("]");
}