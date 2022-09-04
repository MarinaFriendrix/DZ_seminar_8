// Задача 54. Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

// Console.Write("Введите число строк: ");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число столбцов: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] matrix = new int [m, n];

// for (int i =0; i < m; i++)
// {
//     for (int j = 0; j < n; j++)
//     {
//        matrix[i,j] = new Random().Next(1,10);
//        Console.Write($"{matrix[i, j]} ");
//     }
//     Console.WriteLine();
// }
// // Сортировка строк
// int temp;
// for (int i = 0; i < m; i++)
// {
//     for (int j = 0; j< n-1; j++)
//     {
//         for (int k = j+1; k < n; k++)
//         {
//             if ( matrix [i,j] < matrix [ i, k])
//             {
//                 temp = matrix [i,j];
//                 matrix[i,j]= matrix [i,k];
//                 matrix[i, k] = temp;
//             }
               
//         }
           
//     }
 
// }
// for (int i =0; i < m; i++)
// {
//     for (int j = 0; j < n; j++)
//     {
       
//        Console.Write($"{matrix[i, j]} ");
        
//     }
//     Console.WriteLine();
// }

// Задача 60.Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// int[,,] myArray = new int [2,2,2];
// for (int i =0; i < myArray.GetLength(0); i++)
// {
//     for (int j = 0; j < myArray.GetLength(1); j++)
//     {
//         for( int k =0; k < myArray.GetLength(2); k++)
//         {
//             myArray[i,j,k] = new Random().Next(10,100);
//         }
//     }
// }
// for (int i =0; i < myArray.GetLength(0); i++)
// {
//     for (int j = 0; j < myArray.GetLength(1); j++)
//     {
//         for( int k =0; k < myArray.GetLength(2); k++)
//         {
//             // Console.Write(myArray[i,j,k]+ " ");
//             Console.Write($"{myArray[i, j, k]} [{i} {j} {k}]");
//         }
//         Console.WriteLine();
//     }
// }
// Console.ReadLine();


// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// int[,] myArray = new int [4,4];
//  for (int i =0; i < myArray.GetLength(0); i++)
// {
//     for (int j = 0; j < myArray.GetLength(1); j++)
//     {
//         myArray[i,j] = new Random().Next(0,10);
//     }
// }
// for (int i =0; i < myArray.GetLength(0); i++)
// {
//     for (int j = 0; j < myArray.GetLength(1); j++)
//     {
//           Console.Write(myArray[i,j]+ " ");
          
//     }
//     Console.WriteLine();    
// }
      

// int summin = 0;
// int line = 0;
// for (int i =0; i < myArray.GetLength(0); i++)
// {
//     int sum = 0;
//     for (int j = 0; j < myArray.GetLength(1); j++)
//     {      
//         sum+= myArray[i,j];
//     }
//     if ( summin == 0 ) summin = sum;
    
//     if (sum < summin)
//     {
//         summin = sum;
//         line = i+1;
//     }
// }
// Console.WriteLine();
// Console.WriteLine(line);
// Console.WriteLine();
// Console.Write(summin);


// Задача 58: Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.
// int[,] myArray = new int [2,2];
//  for (int i =0; i < myArray.GetLength(0); i++)
// {
//     for (int j = 0; j < myArray.GetLength(1); j++)
//     {
//         myArray[i,j] = new Random().Next(0,10);
//     }
// }
// for (int i =0; i < myArray.GetLength(0); i++)
// {
//     for (int j = 0; j < myArray.GetLength(1); j++)
//     {
//           Console.Write(myArray[i,j]+ " ");
          
//     }
//     Console.WriteLine();    
// }
// Console.WriteLine("=====");  

// int[,] myArray1 = new int [2,2];
//  for (int k =0; k < myArray1.GetLength(0); k++)
// {
//     for (int l = 0; l < myArray1.GetLength(1); l++)
//     {
//         myArray1[k,l] = new Random().Next(0,10);
//     }
// }
// for (int k =0; k < myArray1.GetLength(0); k++)
// {
//     for (int l = 0; l < myArray1.GetLength(1); l++)
//     {
//           Console.Write(myArray1[k,l]+ " ");
          
//     }
//     Console.WriteLine();    
// }

// int[,] ArrayProduct = new int [2,2];
// for (int i =0; i < myArray.GetLength(0); i++)
// {
//        for (int l = 0; l < myArray1.GetLength(1); l++)
//     {
//          int sum = 0;
//         for(int k = 0; k < myArray.GetLength(1); k++)
//         {
//             sum+= myArray[i,k]*myArray1[k,l];
//         }
//         ArrayProduct[i,l]=sum;
//     }
// }
// for (int k =0; k < ArrayProduct.GetLength(0); k++)
// {
//     for (int l = 0; l < ArrayProduct.GetLength(1); l++)
//     {
//           Console.Write(ArrayProduct[k,l]+ " ");
          
//     }
//     Console.WriteLine();    
// }


// Напишите программу, которая заполнит спирально массив 4 на 4.
// размер массива
// int leni = 9, lenj=7; 

// int d=1, i=0, j=0, maxj=lenj-1, maxi=leni-1, minj=0, mini=1;
// int[,] a = new int [leni,lenj];
// for (int counter = 0; counter < leni*lenj; counter ++) {
//     Console.WriteLine(i+ " "+j+ " counter=" + counter +" d=" + d);
//     a[i,j] = counter;
//     if (j==maxj && d==1) 
//     {
//         d=2;
//         maxj=maxj-1;
//     }
//     if (i==maxi && d==2) 
//     {
//         d=3;
//         maxi=maxi-1;
//     }
//     if (j==minj && d==3) 
//     {
//         d=4;
//         minj=minj+1;
//     }
//     if (i==mini && d==4) 
//     {
//         d=1;
//         mini=mini+1;
//     }
//     if (d==1) j=j+1;
//     if (d==2) i=i+1;
//     if (d==3) j=j-1;
//     if (d==4) i=i-1;
// }
// for (int k =0; k < a.GetLength(0); k++)
// {
//     for (int l = 0; l < a.GetLength(1); l++)
//     {
//         Console.Write(a[k,l]+ " ");
//         if (a[k,l] < 10) Console.Write(" ");
//     }
//     Console.WriteLine();    
// }