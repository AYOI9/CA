try {
   Console.WriteLine("Введите трехзначное число: ");
   int originalNumber = Convert.ToInt32(Console.ReadLine());
   if (originalNumber < 100 || originalNumber > 999) 
    { 
    Console.WriteLine("Число не является трехзначным.");
                return;
     }
    int lastDigit = originalNumber % 10;
     int firstTwoDigits = originalNumber / 10;
      int newNumber = lastDigit * 100 + firstTwoDigits;
    Console.WriteLine("Новое число: " + newNumber);
   }
catch {
    Console.WriteLine("Введите правильное занчение:");
}