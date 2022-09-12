// See https://aka.ms/new-console-template for more information
Console.WriteLine("It's easy to win forgiveness for beimg wrong;");
Console.WriteLine("being right is what gets you into real trouble.");
Console.WriteLine("Bjarne Stroustrup");

////Console.WriteLine("Введите 5 чисел:");
//var b = Console.ReadLine();
//Console.WriteLine(b);
int[] massive = new int[5];
int summary = 0;
int multiply = 1;
int max = 0;
int min = 0;
//string line = Console.ReadLine();
//massive[0] = Int32.Parse(line);
//massive[0] = Int32.Parse(Console.ReadLine());

for (int i = 0; i < 5; i++)
{
    Console.WriteLine("введите число для индекса {0}", i); 
    massive[i] = Int32.Parse(Console.ReadLine());
}
min = massive[0];
max = massive[0];
for (int i = massive.Length - 1; i >= 0; i--)
{
    summary += massive[i];
    multiply *= massive[i];
    if (min > massive[i])  { min = massive[i]; }
    if (max < massive[i])  { max = massive[i]; }

}
Console.WriteLine("Сумма: {0}, Произведение: {1}, Max: {2}, Min: {3}",summary, multiply, max, min);

