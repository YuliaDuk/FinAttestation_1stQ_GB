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

int count =0;
for (int i = 0; i < size; i++)
{
    int length=array[i].Length;
    if(length>3) count++;
}
string[] newarray = new string[size-count];
int countsize=0;
for (int i = 0; i < size; i++)
{
    int length = array[i].Length;
    if(length>3) countsize++;
    if(length<=3) //else
    {
       newarray[i-countsize]=array[i];
    }
}
Console.WriteLine("Массив из строк, длина которых меньше или равна 3 символам:");
Console.WriteLine('[' + string.Join(',', newarray) + ']');
}
