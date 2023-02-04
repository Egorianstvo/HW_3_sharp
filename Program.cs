/*Напишите программу, которая принимает на вход число (N) и выдаёт таблицу КУбов чисел 
от 1 до N.
*/



System.Console.WriteLine("Enter number: ");

int Number = int.Parse(Console.ReadLine());

int I = 1;

while(I  <= Number)
{
    Console.Write(Math.Pow(I, 3)+ " ");
                                                       //сделать таблицу кубов
    I+=1;

}





/*
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53

Задача 23

Console.WriteLine("Entre number X1 ");
double numX1 = double.Parse(Console.ReadLine());

Console.WriteLine("Entre number Y1 ");
double numY1 = double.Parse(Console.ReadLine());

Console.WriteLine("Entre number Z1 ");
double numZ1 = double.Parse(Console.ReadLine());



Console.WriteLine("Entre number X2 ");
double numX2 = double.Parse(Console.ReadLine());

Console.WriteLine("Entre number Y2 ");
double numY2 = double.Parse(Console.ReadLine());

Console.WriteLine("Entre number Z2 ");
double numZ2 = double.Parse(Console.ReadLine());



double numSQRT = Math.Sqrt(Math.Pow((numX1-numX2),2)+Math.Pow((numY1-numY2),2)+Math.Pow((numZ1-numZ2),2));

Console.Write(numSQRT)
*/



/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

/*
System.Console.WriteLine("Enter number: ");                                  

int Number = int.Parse(Console.ReadLine());

int Number1 = Number / 10000;
int Number5 = Number % 10;

int Number2 = (Number % 10000) / 1000;
int Number4 = (Number % 100) / 10;

if(Number1 == Number5 && Number2 == Number4)
{
    System.Console.WriteLine("Является ПАЛИНДДРОМОМ");
}
else
{
    System.Console.WriteLine("Не является ПАЛИНДРОМОМ");
}
*/

/*
int Number = Convert.ToInt32(Console.ReadLine());

int i = 10;

if(Number < i)
{
    System.Console.WriteLine("Enter number > 10");
}
else if(Number > i)
{
    while(Number > i)
    {
        i*=10;
    
    }
    if(Number < i)
    {
        i = i/10
    }
    Number1 = Number / i;
    NumberLast = Number % 10;

    Number2 = (Number % i) / (i / 10);
    Number4 = 

    

}

while (i <= Number1)
{
    i*=10;
}

if (Number1 < 11)
{
     System.Console.WriteLine("Erro, enter number > 10");
}
else
{
     System.Console.WriteLine((Number1 % (i / 100)) / (i / 1000));
}
*/