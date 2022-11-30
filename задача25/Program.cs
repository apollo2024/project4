int num1 = new Random().Next(2, 10);
Console.WriteLine(num1);
int num2 = new Random().Next(2, 10);
Console.WriteLine(num2);
int sum = answer_number(num1, num2);
  Console.WriteLine("answer is = " + sum);
int answer_number(int num1, int num2)
{
  int result = 1;
  for(int i=1; i <= num2; i++){
    result = result * num1;
  }
    return result;
}