// Задача 1

// Console.Write("Введите первое число: ");
// int firstNumber = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите второе число: ");
// int secondNumber = Convert.ToInt32(Console.ReadLine());

// if (firstNumber < secondNumber) Console.WriteLine("Большее число: " + secondNumber + ", " + "меньшее число: " + firstNumber);
// else if (firstNumber > secondNumber) Console.WriteLine("Большее число: " + firstNumber + ", " + "меньшее число: " + secondNumber);
// else if (firstNumber == secondNumber) Console.WriteLine("Числа равны");


// Задача 2

// Console.Write("Введите первое число: ");
// int firstNumber =  Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите второе число: ");
// int secondNumber = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите третье число: ");
// int thirdNumber =  Convert.ToInt32(Console.ReadLine());

// int maxNumber = firstNumber;

// if (secondNumber > maxNumber) maxNumber = secondNumber;
// if (thirdNumber > maxNumber) maxNumber = thirdNumber;

// Console.WriteLine("Наибольшее число: " + maxNumber);


// Задача 3

// Console.Write("Введите число: ");
// int number =  Convert.ToInt32(Console.ReadLine());

// if (number % 2 != 0) Console.WriteLine("Число нечетное");
// else Console.WriteLine("Число четное");


// Задача 4

Console.Write("Введите число: ");

int number =  Convert.ToInt32(Console.ReadLine());
int i = 1;

while (i <= number)
{
    if (i % 2 == 0) Console.Write(i + " ");
    i++;
}