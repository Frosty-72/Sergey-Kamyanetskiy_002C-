// первое решение 

// int a1 = 15;
// int b1 = 21;
// int c1 = 39;
// int a2 = 12;
// int b2 = 23;
// int c2 = 33;
// int a3 = 13;
// int b3 = 23;
// int c3 = 33;

// int max = a1;
// if (b1 > max) max = b1;
// if (c1 > max) max = c1;

// if (a2 > max) max = a2;
// if (b2 > max) max = b2;
// if (c2 > max) max = c2;

// if (a3 > max) max = a3;
// if (b3 > max) max = b3;
// if (c3 > max) max = c3;

// Console.WriteLine(max);


// второе решение 
//     int Max(int arg1, int arg2, int arg3)
//     {
//         int result = arg1;
//         if (arg2 > result) result = arg2;
//         if (arg3 > result) result = arg3;
//         return result;

//     }
// int a1 = 15;
// int b1 = 21;
// int c1 = 390;
// int a2 = 12;
// int b2 = 23;
// int c2 = 33;
// int a3 = 13;
// int b3 = 230;
// int c3 = 3300;

// int max1 = Max(a1, b1, c1);
// int max2 = Max(a2, b2, c2);
// int max3 = Max(a3, b3, c3);

// int max = Max(
//     Max(a1, b1, c1),
//      Max(a2, b2, c2), 
//      Max(a3, b3, c3));

// Console.WriteLine(max); 

// третье решение 
// int Max(int arg1, int arg2, int arg3)
//      {
//          int result = arg1;
//         if (arg2 > result) result = arg2;
//          if (arg3 > result) result = arg3;
//         return result;

//      }

// int[] arrey = {13, 42, 35, 64, 75, 86, 79, 865, 59};
// arrey[0] = 12;
// int result = Max(
//     Max (arrey[0], arrey[1], arrey[2]),
//     Max (arrey[3], arrey[4], arrey[5]),
//     Max (arrey[6], arrey[7], arrey[8])
// );
// Console.WriteLine(result);

// третье задание 


// int[] array = { 1, 23, 3, 44, 55, 65, 7, 58, };

// int n = array.Length;
// int find = 44;

// int index = 0;

// while (index < n)
// {
//     if (array[index] == find)
//     {
//         Console.WriteLine(index);
//         // break;  - в том случае если вассиве несколько одинаковых индексов 
//     }

//     index++;


// }


// задание номер 4




void FillArray(int[] collection)

{
    int Length = collection.Length;
    int index = 0;

    while (index < Length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }

}

void PrintArrey(int[] col)
{
    int count = col.Length;
    int position = 0;

    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int indexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;

    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
        return position;

}


int[] array = new int[10];

FillArray(array);
PrintArrey(array);
Console.WriteLine();

int pos = indexOf(array, 4);
Console.WriteLine(pos);



