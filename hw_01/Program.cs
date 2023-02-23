// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int num = number;
int n = 5;
int[] nums = new int[n];

for (int i = 0; i < n; i++){
    nums[n-1-i] = num%10;
    // Console.WriteLine(nums[n-1-i]);
    num = num/10;
}

// int k = 0;
// while ( k <= n/2){
//     if (nums[n-1-k] != nums[k]) {
//         Console.WriteLine($"Число {number} не является полиндромом");
//         break;
//     }
//     k++;
//     Console.WriteLine($"Число {number} является полиндромом");
// }


if (nums[n-1] == nums[0] && nums[n-2] == nums[1]){
    Console.WriteLine($"Число {number} является полиндромом");
}else{
    Console.WriteLine($"Число {number} не является полиндромом");
}

//проверка на 5-ти значность?
