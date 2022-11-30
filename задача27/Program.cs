int num = new Random().Next(2, 10000);
Console.WriteLine(num);
int sumNum = TotalNum(num);
Console.WriteLine("the sum of the digits in number: " + sumNum);
int TotalNum(int numberN)
{
    int counter = Convert.ToString(num).Length;
    int array = 0;
    int result = 0;

    for (int i = 0; i < counter; i++)
    {
      array = num - num % 10;
      result = result + (num - array);
      num = num / 10;
    }
   return result;
  }