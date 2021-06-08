using System;
using System.Collections.Generic;


// Delegate types to describe predicates on ints and actions on ints. 
public delegate bool IntPredicate(int x);
public delegate void IntAction(int x);

// Integer lists with Act and Filter operations. 
// An IntList containing the element 7 9 13 may be constructed as  
// new IntList(7, 9, 13) due to the params modifier. 
class IntList : List<int>
{
    public IntList(params int[] elements) : 
        base(elements) {}

    public void Act(IntAction f) {
        foreach (int i in this)
        {
            f(i);
        }
    }

    public IntList Filter(IntPredicate p) {
        IntList res = new IntList();
        foreach (int i in this)
            if (p(i))
                res.Add(i);
        return res; }
}

class Program
{
    public static void Main(String[] args)
    {
        Console.WriteLine("List:");
        IntList xs = new IntList() {10,15,20,25,30,35,40,45,50};
        xs.Act(Console.WriteLine);
        Console.WriteLine("");

        Console.WriteLine("x%2:");
        xs.Filter(delegate (int x) { return x % 2 == 0; }).Act(Console.WriteLine);
        Console.WriteLine("");

        Console.WriteLine("x >= 25:");
        xs.Filter((int x) => x >= 25).Act(Console.WriteLine);
        Console.WriteLine("");

        Console.WriteLine("Sum:");
        int sum = 0;
        xs.Filter((int x) => { sum = sum + x; return true; });
        Console.WriteLine(sum);

        Console.ReadLine();
    }
}