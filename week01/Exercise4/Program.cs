using System;

class Program
{
    static void Srt(List<float> myList){
        for(int i=0; i < myList.Count; i++)
        {
            for(int j=0; j < (myList.Count-1); j++)
            {
                if (myList[j] > myList[j + 1])
                {
                    float temp = myList[j];
                    myList[j] = myList[j+1];
                    myList[j+1] = temp;
                }
            }
        }
    }
    static float Max(List<float> myList){
        float max = myList[0];
        for(int i=0; i < myList.Count; i++)
        {
            if (myList[i] > max)
            {
                max = myList[i];
            }
        }
        return max;
    }
    static void Main(string[] args)
    {
        List<float> numbers = new List<float>();
        float num;
        do
        {
            Console.Write("Enter a number: ");
            // string number = ;
            num = float.Parse(Console.ReadLine());
            if (num != 0)
            {
                numbers.Add(num);
            }
        }while (num != 0);
        float total  =  0;
        foreach (float number in numbers)
        {
            total += number;
        }
        Console.WriteLine($"The sum is : {total}");

        Console.WriteLine($"The average of the list of numbers is: {total / numbers.Count}");
        float max = Max(numbers);
        Console.WriteLine($"The Highest number in the list of numbers is: {max}");
        
        Srt(numbers);
        float lowest = numbers[numbers.Count-1];
        foreach (float number in numbers)
        {
            if (number > 0)
            {
                // lowest = number;
                if (number < lowest)
                {
                    lowest = number;
                }
            }
        }
        Console.WriteLine($"The Lowest positive number is : {lowest}");
        Console.WriteLine($"The sorted list is: ");
        foreach (float number in numbers)
        {
            Console.WriteLine(number);
        }
        
        // Console.WriteLine("Hello World! This is the Exercise4 Project.");
    }
}