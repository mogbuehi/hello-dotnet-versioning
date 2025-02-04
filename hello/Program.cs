namespace hello;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, CS 690!");
        Console.WriteLine("Enter a number: ");
        var number = int.Parse(Console.ReadLine());
    
        if(number%2 == 0){
            Console.WriteLine(number+ " is even");
        } else {
            Console.WriteLine(number+ " is odd");
        }

    }
}
