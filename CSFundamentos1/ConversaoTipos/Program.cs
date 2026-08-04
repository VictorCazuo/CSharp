Console.WriteLine("Conversão de Tipos\n");

//Conversão implícita
int varInt = 100; //4bytes
double varDouble = varInt; //conversão implícita de int para double = 8bytes
Console.WriteLine(varDouble);

//byte -> 1byte
//short -> 2bytes
//int -> 4bytes
//long -> 8bytes
//float -> 4bytes
//double -> 8bytes
//decimal -> 16bytes

int numeroInt = 2145678;
long numeroLong = numeroInt; //conversão implícita de int para long
float numeroFloat = numeroInt; //conversão implícita de int para float
double numeroDouble = numeroInt;
decimal numeroDecimal = numeroInt;

Console.WriteLine(numeroInt);
Console.WriteLine(numeroLong);
Console.WriteLine(numeroFloat);
Console.WriteLine(numeroDouble);
Console.WriteLine(numeroDecimal);

//Conversão implícita

double varDouble2 = 12.456;
int varInt2 = (int)varDouble2; //conversão explícita de double para int, usando o cast


int num1 = 10;
int num2 = 4;

float resultado = (float)num1 / num2; //conversão explícita de int para float, usando o cast, se eu não fizer a conversão, o resultado da divisão é 2, porque é uma divisão de inteiros, se eu fizer a conversão, o resultado é 2.5, porque é uma divisão de float 

