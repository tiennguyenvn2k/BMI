class Program
{
    static void Main(string[] args)
    {
        double weight,height;
        Console.WriteLine("Moi nhap can nang (kg):");
        weight = double.Parse(Console.ReadLine());
        Console.WriteLine("Moi nhap chieu cao (m):");
        height = double.Parse(Console.ReadLine());
        double bmi = weight/(height*height);
        bmi = Math.Round(bmi,1);
        if(bmi<18.5)
        {
            Console.WriteLine("Underweight");
        }
        else if(bmi<25.0)
        {
            Console.WriteLine("Normal");
        }
        else if(bmi<30)
        {
            Console.WriteLine("Overweight");
        }
        else
        {
            Console.WriteLine("Obese");
        }
    }
}