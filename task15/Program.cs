Console.Write("Введи цифру, обозначающую день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek (int dayNumber) {
  if (dayNumber == 6 || dayNumber == 7) {
  Console.WriteLine("Этот выходной день!");
  }
  else if (dayNumber < 1 || dayNumber > 7) {
    Console.WriteLine("это вообще не день недели");
  }
  else Console.WriteLine("Это не выходной день.");
}

CheckingTheDayOfTheWeek(dayNumber);