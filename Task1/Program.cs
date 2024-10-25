//Составить программу, которая будет генерировать случайные числа в интервале [a;b].
//Заполнить ими двумерный массив размером 10 на 10.
//В массиве необходимо найти номер строки с минимальным элементом.
//Поменять строки массива местами, строку с минимальным элементом и первую строку массива.

var rnd = new Random();
double[,] arr = new double[10, 10];
double a = double.Parse(Console.ReadLine()); 
double b = double.Parse(Console.ReadLine());
double minEl = 0;
int strMinEl = 0;

Console.WriteLine();

// Генерация и вывод  массива
for (int i = 0; i < arr.GetLength(0); i++) {

   for (int j = 0; j < arr.GetLength(1); j++) {

        // Заполнение массива вещественными числами в диапазоне чисел a и b
        arr[i, j] = (a + rnd.NextDouble() * (b - a)); 

        Console.Write(String.Format(" {0:N3} ", arr[i, j]));


        // Поиск минимального элемента в массиве
        if (minEl == 0) {
            minEl = arr[i, j];
        } else {
            
            if (minEl > arr[i, j]) {

                minEl = arr[i, j];

            }

        }

    }

   Console.WriteLine();
   Console.WriteLine();

}

for (int i = 0; i < arr.GetLength(0); i++) {

    for (int j = 0; j < arr.GetLength(1); j++) {


        // Поиск строки с минимальным элементом
        if (minEl == arr[i, j]) {

            strMinEl = i+1;

        }
    }
}

Console.WriteLine($"Строка с минимальным элементом {strMinEl}");
Console.WriteLine($"Минимальный элемент массива {minEl:N3}");
Console.WriteLine();


// Замена первой строки с строкой с минимальным элементом в массиве
for ( int i = 0;i < arr.GetLength(1); i++) {

    var tmp = arr[strMinEl - 1, i];
    arr[strMinEl - 1, i] = arr[0, i];
    arr[0, i] = tmp;

}

// Вывод массива с 1 строкой с минимальным элементом
for (int i = 0; i < arr.GetLength(0); i++) {

    for (int j = 0; j < arr.GetLength(1); j++) {

        Console.Write(String.Format(" {0:N3} ", arr[i, j]));

    }

    Console.WriteLine();
    Console.WriteLine();

}







