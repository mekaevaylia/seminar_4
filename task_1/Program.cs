// -------------------------------------------ВСЕ РЕШАТЬ ЧЕРЕЗ МЕТОДЫ---------------------------------------------------

// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A 
// в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите первое число: ");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int B = int.Parse(Console.ReadLine()!);
Console.WriteLine($"{A} в степени {B} равно {Method(A)}");
int Method(int A) {
    int pr = 1;
    for(int i = 0; i < B; i++){
        pr *= A;

    }
    return pr;
}