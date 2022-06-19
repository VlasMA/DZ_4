// // Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.WriteLine("Введите число 1 : ");
int numb1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2 : ");
int numb2 = Convert.ToInt32(Console.ReadLine());
int step = numb1;

for (int i = 1; i < numb2; i++)
{
    step = step * numb1;  
}
Console.WriteLine(step);


