using FSharpProject;

namespace CSharpProject
{
    public class Class1
    {
        public static void Test() 
        {
            MyType.StaticOutParam("test", out var dummy);
        }
    }
}
