

using System.Runtime.Intrinsics.X86;

class Passcode
{
    public static void Main(string[] args)
    {
        Console.Write("Emter the passcode :");
        String? passcode=Console.ReadLine(); //To fix this warning, you can use the null - forgiving operator (?) to tell the compiler that you are sure the value will not be null

        if (passcode == "secret")
        {
            Console.WriteLine("Pass");
        }
        else
        {
            Console.WriteLine("Fail");
        }

    }
}