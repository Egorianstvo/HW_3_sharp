/*Напишите программу, которая принимает на вход число (N) и выдаёт таблицу КУбов чисел 
от 1 до N.
*/
#nullable disable
System.Console.WriteLine("____Tusk 1____");

System.Console.Write("Enter number: ");

int Numbers = int.Parse(Console.ReadLine());

int I = 1;

while(I  <= Numbers)
{
    Console.Write(Math.Pow(I, 3)+ " ");
                                                      
    I+=1;

}
System.Console.WriteLine(".");






//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

System.Console.WriteLine("____Tusk 2____");

Console.Write("Entre number X1 ");
double numX1 = double.Parse(Console.ReadLine());

Console.Write("Entre number Y1 ");
double numY1 = double.Parse(Console.ReadLine());

Console.Write("Entre number Z1 ");
double numZ1 = double.Parse(Console.ReadLine());


Console.Write("Entre number X2 ");
double numX2 = double.Parse(Console.ReadLine());

Console.Write("Entre number Y2 ");
double numY2 = double.Parse(Console.ReadLine());

Console.Write("Entre number Z2 ");
double numZ2 = double.Parse(Console.ReadLine());


double numSQRT = Math.Sqrt(Math.Pow((numX1-numX2),2)+Math.Pow((numY1-numY2),2)+Math.Pow((numZ1-numZ2),2));

Console.WriteLine(numSQRT);





/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

System.Console.WriteLine("____Tusk 3____");      //К сожалению смог решить задачу только как в условие, 5-ти значное число, не нашел решение
                                                   // что бы была для любого числа задача
System.Console.Write("Enter number: ");                                  

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