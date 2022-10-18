/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */
using static System.Console;

int x = 4;
int[,] sMatrix = new int[x,x];

int temp = 1;
int i = 0;
int j = 0;

while(temp <= sMatrix.GetLength(0) * sMatrix.GetLength(1)) {
    sMatrix[i,j] = temp;
    temp++;
    if(i <= j + 1 && i + j < sMatrix.GetLength(1)-1) {
        j++;
    }
    else if (i < j && i + j >= sMatrix.GetLength(0)-1) {
        i++;
    }
    else if (i >= j && i + j > sMatrix.GetLength(1)-1) {
        j--;
    }
    else {
        i--;
    }
}

PrintArray(sMatrix);

void PrintArray(int[,] inArray) {

    for(int i = 0; i < inArray.GetLength(0); i++) {

        for(int j = 0; j < inArray.GetLength(1); j++) {
            
            if(inArray[i,j] / 10 <= 0) 
                Write($" {inArray[i,j]} ");
            
            else 
                Write($"{inArray[i,j]} ");
            
        }
        WriteLine();
    }
}
