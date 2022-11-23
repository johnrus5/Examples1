Console.Write("Введите число: ");
int numberN = Convert.ToInt32(Console.ReadLine());
//int size = new Random().Next(0, 100);
int [] numbers = new int [numberN];
for (int i=0; i < numbers.Length; i++)
{
    numbers[i] = new Random().Next(0,9);
    Console.Write (numbers [i] + "," + " ");
}
    

