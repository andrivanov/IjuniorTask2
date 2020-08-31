
//Разберитесь с инкапсуляцией в следующем коде - https://gist.github.com/HolyMonkey/164a6b05eb869781b4562985237f9fa2

//Очень важно чтобы сумка могла сообщить что в ней находится для отображения в интерфейсе.

//Помимо этого, чтобы сообщала она нормальными типами.Т.е если я получил ссылку на ячейку сумки в которой 10 яблок, а потом их стало 15, у меня была актуальная информация что там 15.

//Но при этом нужно сделать так, чтобы я не мог эту ячейку менять.
using System;
using System.Collections.Generic;

class Bag: IBag, IUpdatable
{
    private readonly List<Item> Items = new List<Item>();
    public readonly int MaxWeidth;

    interface IBag
    {
        public void AddItem(string name, int count);
    }

    interface IUpdatable
    {
        public event Action Changed;
    }
}
public Bag(int maxWeidth)
    {
        MaxWeidth = maxWeidth;
    }

    Item item = new Item();

    Item.Changed += () => Console.WriteLine("name.Item");
        Console.WriteLine("test 1");
         Item.Changed -= () => Console.WriteLine("name.Item");

    public void AddItem(string name, int count)
    {
       private int currentWeidth = Items.Sum(item => item.Count);
        Item targetItem = Items.FirstOrDefault(item => item.Name == name);

        if (targetItem == null)
            throw new InvalidOperationException();
   
        if (currentWeidth + count > MaxWeidth)
            throw new InvalidOperationException();

        targetItem.Count += count;

         if (targetItem != null){
        Changed?.Invoke();
   
}
    }

    public IEnumerable<Item> GetAll()
    {
        return Items;
    }






class Item
{
    public readonly int Count;
    public readonly string Name;

    public Item (int count, string name)
    {
        Count = count;
        Name = name;
    }
}

















