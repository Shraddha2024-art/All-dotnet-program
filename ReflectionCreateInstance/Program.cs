namespace ReflectionCreateInstance
{
    internal class Program
    {
        Type t = typeof(TestClass);

        MethodInfo[] method = t.GetMethod();
        foreach (MethodInfo m in method)
        {
          System.Console.WriteLine(m.Name);  
        }
        
        ConstructorInfo ctor = t.GetConstructors(System.Type.EmptyType);
        Method m1 = t.GetMethod("TestMethod");
        object obj = ctor.Invoke(null);
        System.Console.WriteLine("Test");

    }
}