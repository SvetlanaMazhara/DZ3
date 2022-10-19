/* Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом.
bool Trueorfalse (int num)
{
int ed = num % 10;
int des = num % 100/10;
int tys = num % 10000/1000;
int destys = num/10000;
if (destys==ed && tys==des)
return true;
else
return false;
}
Console.WriteLine ("Input num");
int num = Convert.ToInt32(Console.ReadLine());
bool Palindrom = Trueorfalse(num);
Console.WriteLine (Palindrom);

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов 
чисел от 1 до N.


void Kub (int num)
{
    int step=1;
    while (step<= num)
    {
        Console.Write ($"Kub of {step} are {step*step*step} ");  
    step++;
     }
}
Console.WriteLine ("Input num");
int num = Convert.ToInt32(Console.ReadLine());
Kub (num);
*/

