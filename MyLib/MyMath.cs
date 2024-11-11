namespace MyLib;

public class MyMath
{
  public void Add(int a, int b)
  {
    Console.WriteLine($"{a}+{b}={a+b}");
  }
  public void Sub(int a, int b)
  {
    Console.WriteLine($"{a}-{b}={a-b}");
  }
  public void Multi(int a, int b)
  {
    Console.WriteLine($"{a}*{b}={a*b}");
  }
  public void Divide(int a, int b)
  {
    Console.WriteLine($"{a}/{b}={a/b}");
  }
}
