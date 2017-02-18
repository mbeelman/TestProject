public class A<T>
{
    public class B : A<int>
    {
        public void M() { System.Console.WriteLine(typeof(T)); }
        public class C : B { }
    }
}
public class P
{
    public static void Main() { (new A<string>.B.C()).M(); }
}