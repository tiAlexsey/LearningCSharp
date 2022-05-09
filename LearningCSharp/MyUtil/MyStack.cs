using System.Collections;

namespace LearningCSharp.MyUtil;

class myStack<T> : IEnumerable
{
    private int sizeStack = 0;
    private readonly int defaultStackSize;
    private T[] stack;

    public void Push(T item)
    {
        if (stack.Length == sizeStack)
        {
            ChangeStackSize();
        }

        stack[sizeStack] = item;
        sizeStack++;
    }

    public T Pop()
    {
        if (sizeStack == 0)
        {
            Console.Write("Стек пуст ");
            return default(T);
        }
        else
        {
            sizeStack--;
            return stack[sizeStack];
        }
    }

    public IEnumerator GetEnumerator()
    {
        for (int i = 0; i < sizeStack; i++)
        {
            yield return stack[i];
        }
    }

    public myStack(int maxStackSize = 100)
    {
        defaultStackSize = maxStackSize;
        stack = new T[maxStackSize];
    }

    private void ChangeStackSize()
    {
        int maxStackSize = stack.Length + defaultStackSize;
        T[] newStack = new T[maxStackSize];
        for (int i = 0; i < stack.Length; i++)
        {
            newStack[i] = stack[i];
        }

        Console.Write($"(Максимальный размер стека увеличен, теперь он {maxStackSize})\n");
        stack = newStack;
    }
}