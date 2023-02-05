/*Напишите программу, которая принимает на вход число (N) и выдаёт таблицу КУбов чисел 
от 1 до N.
*/
#nullable disable
System.Console.WriteLine("____Tusk 1____");

System.Console.Write("Enter number: ");

int Numbers = int.Parse(Console.ReadLine());
for(int I = 1; I <= Numbers; I++ )
{
     Console.Write(Math.Pow(I, 3)+ " ");
}                                              
System.Console.WriteLine();



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

System.Console.WriteLine("____Tusk 3____");      
                                                   
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




System.Console.WriteLine("____Tusk 3____/VAR2");      //решал уже с помощью вариант с циклом
System.Console.Write("Enter number: ");
int Num = int.Parse(Console.ReadLine());
int invert = 0;
int temp = Num;

while (temp > 0)
{
    int intermediate = temp % 10;    
    temp = temp / 10;
    invert = invert * 10 + intermediate;
}

if (Num == invert) System.Console.WriteLine("Является ПАЛИНДДРОМОМ");
else System.Console.WriteLine("Не является ПАЛИНДРОМОМ");
