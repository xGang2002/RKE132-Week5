//math >= 90 OR chemistry >= 90;

//math && chemistry  || math && biology || chemistry && biology
int math, chemistry, biology;

Console.WriteLine("Enter your math results:");
math = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your chemistry results:");
chemistry = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your biology results:");
biology = Int32.Parse(Console.ReadLine());

if ((math >= 90 && chemistry >= 90) || (math >= 90 && biology >= 90) || (chemistry >= 90 && biology >= 90))
{
    Console.WriteLine("Congratulations! You got accepted!");
}
else
{
    Console.WriteLine("Your Application cannot be approved.");
}

    