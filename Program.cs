class Program{
    static void Main(string[] args){
        ClassB classB = new();
        ClassA b = new ClassA(classB);
        b.CallMethod();

        ClassA c = new ClassA(1);
        c.CallMethod();
    }
}
