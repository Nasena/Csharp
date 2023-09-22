/*
Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

bool ExistanceInArray(int[,,] array, int number)
{
    bool exist = false;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (array[i,j,k] == number) 
                {
                    exist = true;
                    break;
                }
            }
        }
    }
    return exist;
}
int[,,] GetRandom3DArray(int firstDirectionNumber, int secondDirectionNumber, int thirdDirectionNumber)
{
    int[,,] result = new int[firstDirectionNumber, secondDirectionNumber, thirdDirectionNumber];
    int temp = 0;
    for (int i = 0; i < firstDirectionNumber; i++)
    {
        for (int j = 0; j < secondDirectionNumber; j++)
        {
            for (int k = 0; k < thirdDirectionNumber; k++)
            {
                temp = new Random().Next(0,10);
                while(ExistanceInArray(result,temp)) 
                {
                    temp = new Random().Next(0,24);
                }
                result[i, j, k] = temp;
            }
        }
    }
    return result;
}



void Print3DArray(int[,,] arrayToPrint)
{
    System.Console.WriteLine();
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            for (int k = 0; k < arrayToPrint.GetLength(2); k++)
            {
                Console.Write($"{arrayToPrint[i, j, k]}({i},{j},{k})\t");
            }
            Console.WriteLine();
        }
    }
}

Print3DArray(GetRandom3DArray(2,3,2));