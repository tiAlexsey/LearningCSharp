using LearningCSharp.MyUtil;

Console.Write("Укажите размер стека: ");
int stackSize = Convert.ToInt32(Console.ReadLine());

myStack<int> fs = new myStack<int>(stackSize);

Console.WriteLine("Добавление элементов в стек");
for (int i = 0; i < stackSize+1; i++)
{
    fs.Push(Convert.ToInt32(Console.ReadLine()));
}

Console.WriteLine($"Перебор {fs.GetType()}");
foreach (var e in fs)
{
    Console.Write(e + " ");
}

Console.WriteLine("\nИзъятие элемента из стека");

for (int i = 0; i < stackSize + 2; i++)
{
    Console.WriteLine(fs.Pop());
}